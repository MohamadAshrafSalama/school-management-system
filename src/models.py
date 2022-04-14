from src.database import get_connection


class Student:
    def __init__(self, id=None, user_id=None, first_name=None, last_name=None,
                 email=None, phone=None):
        self.id = id
        self.user_id = user_id
        self.first_name = first_name
        self.last_name = last_name
        self.email = email
        self.phone = phone

    @staticmethod
    def create(user_id, first_name, last_name, email=None, phone=None):
        conn = get_connection()
        cursor = conn.execute(
            "INSERT INTO students (user_id, first_name, last_name, email, phone) VALUES (?, ?, ?, ?, ?)",
            (user_id, first_name, last_name, email, phone)
        )
        conn.commit()
        student_id = cursor.lastrowid
        conn.close()
        return student_id

    @staticmethod
    def get_by_user_id(user_id):
        conn = get_connection()
        row = conn.execute("SELECT * FROM students WHERE user_id = ?", (user_id,)).fetchone()
        conn.close()
        return dict(row) if row else None

    @staticmethod
    def get_all():
        conn = get_connection()
        rows = conn.execute("SELECT * FROM students").fetchall()
        conn.close()
        return [dict(r) for r in rows]

    @staticmethod
    def delete(student_id):
        conn = get_connection()
        conn.execute("DELETE FROM students WHERE id = ?", (student_id,))
        conn.commit()
        conn.close()


class Teacher:
    def __init__(self, id=None, user_id=None, first_name=None, last_name=None,
                 email=None, department=None):
        self.id = id
        self.user_id = user_id
        self.first_name = first_name
        self.last_name = last_name
        self.email = email
        self.department = department

    @staticmethod
    def create(user_id, first_name, last_name, email=None, department=None):
        conn = get_connection()
        cursor = conn.execute(
            "INSERT INTO teachers (user_id, first_name, last_name, email, department) VALUES (?, ?, ?, ?, ?)",
            (user_id, first_name, last_name, email, department)
        )
        conn.commit()
        teacher_id = cursor.lastrowid
        conn.close()
        return teacher_id

    @staticmethod
    def get_by_user_id(user_id):
        conn = get_connection()
        row = conn.execute("SELECT * FROM teachers WHERE user_id = ?", (user_id,)).fetchone()
        conn.close()
        return dict(row) if row else None

    @staticmethod
    def get_all():
        conn = get_connection()
        rows = conn.execute("SELECT * FROM teachers").fetchall()
        conn.close()
        return [dict(r) for r in rows]

    @staticmethod
    def delete(teacher_id):
        conn = get_connection()
        conn.execute("DELETE FROM teachers WHERE id = ?", (teacher_id,))
        conn.commit()
        conn.close()
