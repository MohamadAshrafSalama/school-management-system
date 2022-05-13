import hashlib
from src.database import get_connection


def hash_password(password):
    return hashlib.sha256(password.encode()).hexdigest()


def validate_username(username):
    if not username or len(username) < 3:
        raise ValueError("Username must be at least 3 characters.")
    if not username.isalnum():
        raise ValueError("Username must be alphanumeric.")
    return True


def create_user(username, password, role):
    validate_username(username)
    if len(password) < 4:
        raise ValueError("Password must be at least 4 characters.")
    if role not in ('admin', 'teacher', 'student'):
        raise ValueError("Invalid role.")

    conn = get_connection()
    try:
        cursor = conn.execute(
            "INSERT INTO users (username, password, role) VALUES (?, ?, ?)",
            (username, hash_password(password), role)
        )
        conn.commit()
        user_id = cursor.lastrowid
    except Exception as e:
        conn.close()
        raise e
    conn.close()
    return user_id


def login(username, password):
    conn = get_connection()
    row = conn.execute(
        "SELECT * FROM users WHERE username = ? AND password = ?",
        (username, hash_password(password))
    ).fetchone()
    conn.close()
    if row:
        return dict(row)
    return None


def get_user_by_id(user_id):
    conn = get_connection()
    row = conn.execute("SELECT * FROM users WHERE id = ?", (user_id,)).fetchone()
    conn.close()
    return dict(row) if row else None


def change_password(user_id, old_password, new_password):
    conn = get_connection()
    user = conn.execute(
        "SELECT * FROM users WHERE id = ? AND password = ?",
        (user_id, hash_password(old_password))
    ).fetchone()
    if not user:
        conn.close()
        raise ValueError("Current password is incorrect.")
    if len(new_password) < 4:
        conn.close()
        raise ValueError("New password must be at least 4 characters.")
    conn.execute(
        "UPDATE users SET password = ? WHERE id = ?",
        (hash_password(new_password), user_id)
    )
    conn.commit()
    conn.close()


def create_default_admin():
    conn = get_connection()
    existing = conn.execute("SELECT id FROM users WHERE username = 'admin'").fetchone()
    conn.close()
    if not existing:
        create_user('admin', 'admin123', 'admin')
