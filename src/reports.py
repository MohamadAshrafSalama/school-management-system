from src.database import get_connection


def get_student_grade_report(student_id):
    conn = get_connection()
    rows = conn.execute(
        """SELECT c.name as course, a.title as assignment, g.marks, a.max_marks,
                  ROUND(g.marks * 100.0 / a.max_marks, 1) as percentage
           FROM grades g
           JOIN assignments a ON g.assignment_id = a.id
           JOIN courses c ON a.course_id = c.id
           WHERE g.student_id = ?
           ORDER BY c.name, a.title""", (student_id,)
    ).fetchall()
    conn.close()
    return [dict(r) for r in rows]


def get_course_average(course_id):
    conn = get_connection()
    rows = conn.execute(
        """SELECT a.title, AVG(g.marks) as avg_marks, a.max_marks,
                  COUNT(g.id) as num_graded
           FROM assignments a
           LEFT JOIN grades g ON a.id = g.assignment_id
           WHERE a.course_id = ?
           GROUP BY a.id
           ORDER BY a.title""", (course_id,)
    ).fetchall()
    conn.close()
    return [dict(r) for r in rows]


def get_attendance_report(student_id, course_id=None):
    conn = get_connection()
    if course_id:
        rows = conn.execute(
            """SELECT c.name as course, a.date, a.status
               FROM attendance a JOIN courses c ON a.course_id = c.id
               WHERE a.student_id = ? AND a.course_id = ?
               ORDER BY a.date""", (student_id, course_id)
        ).fetchall()
    else:
        rows = conn.execute(
            """SELECT c.name as course, a.date, a.status
               FROM attendance a JOIN courses c ON a.course_id = c.id
               WHERE a.student_id = ?
               ORDER BY c.name, a.date""", (student_id,)
        ).fetchall()
    conn.close()
    return [dict(r) for r in rows]


def get_attendance_summary(student_id):
    conn = get_connection()
    rows = conn.execute(
        """SELECT c.name as course,
                  SUM(CASE WHEN a.status = 'present' THEN 1 ELSE 0 END) as present,
                  SUM(CASE WHEN a.status = 'absent' THEN 1 ELSE 0 END) as absent,
                  SUM(CASE WHEN a.status = 'late' THEN 1 ELSE 0 END) as late,
                  COUNT(*) as total
           FROM attendance a JOIN courses c ON a.course_id = c.id
           WHERE a.student_id = ?
           GROUP BY c.id""", (student_id,)
    ).fetchall()
    conn.close()
    return [dict(r) for r in rows]


def get_course_roster(course_id):
    from src.database import get_connection
    conn = get_connection()
    rows = conn.execute(
        """SELECT s.id, s.first_name, s.last_name, s.email
           FROM students s
           JOIN enrollments e ON s.id = e.student_id
           WHERE e.course_id = ?
           ORDER BY s.last_name, s.first_name""", (course_id,)
    ).fetchall()
    conn.close()
    return [dict(r) for r in rows]


def get_overall_stats():
    from src.database import get_connection
    conn = get_connection()
    stats = {}
    stats['total_students'] = conn.execute("SELECT COUNT(*) FROM students").fetchone()[0]
    stats['total_teachers'] = conn.execute("SELECT COUNT(*) FROM teachers").fetchone()[0]
    stats['total_courses'] = conn.execute("SELECT COUNT(*) FROM courses").fetchone()[0]
    stats['total_enrollments'] = conn.execute("SELECT COUNT(*) FROM enrollments").fetchone()[0]
    conn.close()
    return stats
