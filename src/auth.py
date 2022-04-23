import hashlib
from src.database import get_connection


def hash_password(password):
    return hashlib.sha256(password.encode()).hexdigest()


def create_user(username, password, role):
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


def create_default_admin():
    conn = get_connection()
    existing = conn.execute("SELECT id FROM users WHERE username = 'admin'").fetchone()
    conn.close()
    if not existing:
        create_user('admin', 'admin123', 'admin')
