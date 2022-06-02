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
    def update(student_id, first_name=None, last_name=None, email=None, phone=None):
        conn = get_connection()
        student = conn.execute("SELECT * FROM students WHERE id = ?", (student_id,)).fetchone()
        if not student:
            conn.close()
            raise ValueError("Student not found.")
        conn.execute(
            "UPDATE students SET first_name=?, last_name=?, email=?, phone=? WHERE id=?",
            (first_name or student['first_name'], last_name or student['last_name'],
             email or student['email'], phone or student['phone'], student_id)
        )
        conn.commit()
        conn.close()

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
    def update(teacher_id, first_name=None, last_name=None, email=None, department=None):
        conn = get_connection()
        teacher = conn.execute("SELECT * FROM teachers WHERE id = ?", (teacher_id,)).fetchone()
        if not teacher:
            conn.close()
            raise ValueError("Teacher not found.")
        conn.execute(
            "UPDATE teachers SET first_name=?, last_name=?, email=?, department=? WHERE id=?",
            (first_name or teacher['first_name'], last_name or teacher['last_name'],
             email or teacher['email'], department or teacher['department'], teacher_id)
        )
        conn.commit()
        conn.close()

    @staticmethod
    def delete(teacher_id):
        conn = get_connection()
        conn.execute("DELETE FROM teachers WHERE id = ?", (teacher_id,))
        conn.commit()
        conn.close()


class Course:
    @staticmethod
    def create(code, name, teacher_id=None, max_students=30):
        conn = get_connection()
        cursor = conn.execute(
            "INSERT INTO courses (code, name, teacher_id, max_students) VALUES (?, ?, ?, ?)",
            (code, name, teacher_id, max_students)
        )
        conn.commit()
        course_id = cursor.lastrowid
        conn.close()
        return course_id

    @staticmethod
    def get_all():
        conn = get_connection()
        rows = conn.execute(
            """SELECT c.*, t.first_name || ' ' || t.last_name as teacher_name
               FROM courses c LEFT JOIN teachers t ON c.teacher_id = t.id"""
        ).fetchall()
        conn.close()
        return [dict(r) for r in rows]

    @staticmethod
    def get_by_id(course_id):
        conn = get_connection()
        row = conn.execute("SELECT * FROM courses WHERE id = ?", (course_id,)).fetchone()
        conn.close()
        return dict(row) if row else None

    @staticmethod
    def get_by_teacher(teacher_id):
        conn = get_connection()
        rows = conn.execute("SELECT * FROM courses WHERE teacher_id = ?", (teacher_id,)).fetchall()
        conn.close()
        return [dict(r) for r in rows]

    @staticmethod
    def update(course_id, name=None, teacher_id=None, max_students=None):
        conn = get_connection()
        course = conn.execute("SELECT * FROM courses WHERE id = ?", (course_id,)).fetchone()
        if not course:
            conn.close()
            raise ValueError("Course not found.")
        conn.execute(
            "UPDATE courses SET name=?, teacher_id=?, max_students=? WHERE id=?",
            (name or course['name'], teacher_id if teacher_id is not None else course['teacher_id'],
             max_students or course['max_students'], course_id)
        )
        conn.commit()
        conn.close()

    @staticmethod
    def delete(course_id):
        conn = get_connection()
        conn.execute("DELETE FROM courses WHERE id = ?", (course_id,))
        conn.commit()
        conn.close()


class Assignment:
    @staticmethod
    def create(course_id, title, description=None, due_date=None, max_marks=100):
        conn = get_connection()
        cursor = conn.execute(
            "INSERT INTO assignments (course_id, title, description, due_date, max_marks) VALUES (?, ?, ?, ?, ?)",
            (course_id, title, description, due_date, max_marks)
        )
        conn.commit()
        aid = cursor.lastrowid
        conn.close()
        return aid

    @staticmethod
    def get_by_course(course_id):
        conn = get_connection()
        rows = conn.execute("SELECT * FROM assignments WHERE course_id = ?", (course_id,)).fetchall()
        conn.close()
        return [dict(r) for r in rows]

    @staticmethod
    def get_by_id(assignment_id):
        conn = get_connection()
        row = conn.execute("SELECT * FROM assignments WHERE id = ?", (assignment_id,)).fetchone()
        conn.close()
        return dict(row) if row else None


class Enrollment:
    @staticmethod
    def enroll(student_id, course_id):
        conn = get_connection()
        try:
            conn.execute(
                "INSERT INTO enrollments (student_id, course_id) VALUES (?, ?)",
                (student_id, course_id)
            )
            conn.commit()
        except Exception as e:
            conn.close()
            raise e
        conn.close()

    @staticmethod
    def get_student_courses(student_id):
        conn = get_connection()
        rows = conn.execute(
            """SELECT c.* FROM courses c
               JOIN enrollments e ON c.id = e.course_id
               WHERE e.student_id = ?""", (student_id,)
        ).fetchall()
        conn.close()
        return [dict(r) for r in rows]

    @staticmethod
    def get_course_students(course_id):
        conn = get_connection()
        rows = conn.execute(
            """SELECT s.* FROM students s
               JOIN enrollments e ON s.id = e.student_id
               WHERE e.course_id = ?""", (course_id,)
        ).fetchall()
        conn.close()
        return [dict(r) for r in rows]


class Grade:
    @staticmethod
    def assign_grade(student_id, assignment_id, marks):
        conn = get_connection()
        conn.execute(
            """INSERT OR REPLACE INTO grades (student_id, assignment_id, marks)
               VALUES (?, ?, ?)""",
            (student_id, assignment_id, marks)
        )
        conn.commit()
        conn.close()

    @staticmethod
    def get_student_grades(student_id):
        conn = get_connection()
        rows = conn.execute(
            """SELECT g.marks, a.title, a.max_marks, c.name as course_name
               FROM grades g
               JOIN assignments a ON g.assignment_id = a.id
               JOIN courses c ON a.course_id = c.id
               WHERE g.student_id = ?""", (student_id,)
        ).fetchall()
        conn.close()
        return [dict(r) for r in rows]

    @staticmethod
    def get_assignment_grades(assignment_id):
        conn = get_connection()
        rows = conn.execute(
            """SELECT g.marks, s.first_name, s.last_name
               FROM grades g JOIN students s ON g.student_id = s.id
               WHERE g.assignment_id = ?""", (assignment_id,)
        ).fetchall()
        conn.close()
        return [dict(r) for r in rows]


class Attendance:
    @staticmethod
    def mark(student_id, course_id, date, status):
        conn = get_connection()
        conn.execute(
            "INSERT OR REPLACE INTO attendance (student_id, course_id, date, status) VALUES (?, ?, ?, ?)",
            (student_id, course_id, date, status)
        )
        conn.commit()
        conn.close()

    @staticmethod
    def get_by_student(student_id):
        conn = get_connection()
        rows = conn.execute(
            """SELECT a.*, c.name as course_name FROM attendance a
               JOIN courses c ON a.course_id = c.id
               WHERE a.student_id = ? ORDER BY a.date DESC""",
            (student_id,)
        ).fetchall()
        conn.close()
        return [dict(r) for r in rows]
