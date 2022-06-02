import sys
import os

sys.path.insert(0, os.path.dirname(os.path.dirname(__file__)))

from src.database import init_db
from src.auth import login, create_default_admin, create_user
from src.models import Student, Teacher, Course, Assignment, Enrollment, Grade, Attendance
from src.reports import get_student_grade_report, get_course_average, get_attendance_summary, get_overall_stats


def print_header(title):
    print("\n" + "=" * 50)
    print(f"  {title}")
    print("=" * 50)


def print_menu(options):
    for i, option in enumerate(options, 1):
        print(f"  {i}. {option}")
    print(f"  0. Back / Logout")
    print("-" * 30)


def get_choice(max_val):
    try:
        choice = int(input("Enter choice: "))
        if 0 <= choice <= max_val:
            return choice
    except ValueError:
        pass
    print("Invalid choice. Try again.")
    return -1


def main_menu():
    print_header("School Management System")
    print_menu(["Login", "Exit"])
    choice = get_choice(2)
    if choice == 2:
        print("Goodbye!")
        sys.exit(0)
    return choice


# ---- Admin functions ----

def admin_menu(user):
    while True:
        print_header(f"Admin Panel - {user['username']}")
        options = [
            "Register Student",
            "Register Teacher",
            "Manage Courses",
            "View All Students",
            "View All Teachers",
            "View All Courses",
            "System Statistics",
        ]
        print_menu(options)
        choice = get_choice(len(options))
        if choice == 0:
            break
        elif choice == 1:
            register_student()
        elif choice == 2:
            register_teacher()
        elif choice == 3:
            manage_courses()
        elif choice == 4:
            view_all_students()
        elif choice == 5:
            view_all_teachers()
        elif choice == 6:
            view_all_courses()
        elif choice == 7:
            show_stats()


def show_stats():
    stats = get_overall_stats()
    print_header("System Statistics")
    print(f"  Total Students:    {stats['total_students']}")
    print(f"  Total Teachers:    {stats['total_teachers']}")
    print(f"  Total Courses:     {stats['total_courses']}")
    print(f"  Total Enrollments: {stats['total_enrollments']}")


def register_student():
    print_header("Register New Student")
    username = input("Username: ").strip()
    password = input("Password: ").strip()
    first_name = input("First name: ").strip()
    last_name = input("Last name: ").strip()
    email = input("Email: ").strip()
    phone = input("Phone: ").strip()

    if not username or not password or not first_name or not last_name:
        print("Error: Required fields cannot be empty.")
        return

    try:
        user_id = create_user(username, password, 'student')
        Student.create(user_id, first_name, last_name, email or None, phone or None)
        print(f"Student '{first_name} {last_name}' registered successfully.")
    except Exception as e:
        print(f"Error: {e}")


def register_teacher():
    print_header("Register New Teacher")
    username = input("Username: ").strip()
    password = input("Password: ").strip()
    first_name = input("First name: ").strip()
    last_name = input("Last name: ").strip()
    email = input("Email: ").strip()
    department = input("Department: ").strip()

    if not username or not password or not first_name or not last_name:
        print("Error: Required fields cannot be empty.")
        return

    try:
        user_id = create_user(username, password, 'teacher')
        Teacher.create(user_id, first_name, last_name, email or None, department or None)
        print(f"Teacher '{first_name} {last_name}' registered successfully.")
    except Exception as e:
        print(f"Error: {e}")


def manage_courses():
    print_header("Course Management")
    options = ["Add Course", "Delete Course", "Enroll Student"]
    print_menu(options)
    choice = get_choice(len(options))

    if choice == 1:
        add_course()
    elif choice == 2:
        delete_course()
    elif choice == 3:
        enroll_student()


def add_course():
    code = input("Course code: ").strip()
    name = input("Course name: ").strip()
    max_students = input("Max students (default 30): ").strip()

    teachers = Teacher.get_all()
    if teachers:
        print("\nAvailable teachers:")
        for t in teachers:
            print(f"  ID: {t['id']} - {t['first_name']} {t['last_name']}")
        teacher_id = input("Assign teacher ID (or leave blank): ").strip()
        teacher_id = int(teacher_id) if teacher_id else None
    else:
        teacher_id = None
        print("No teachers available yet.")

    try:
        max_s = int(max_students) if max_students else 30
        Course.create(code, name, teacher_id, max_s)
        print(f"Course '{code} - {name}' created.")
    except Exception as e:
        print(f"Error: {e}")


def delete_course():
    courses = Course.get_all()
    if not courses:
        print("No courses found.")
        return
    for c in courses:
        print(f"  ID: {c['id']} - {c['code']} {c['name']}")
    try:
        cid = int(input("Course ID to delete: "))
        Course.delete(cid)
        print("Course deleted.")
    except Exception as e:
        print(f"Error: {e}")


def enroll_student():
    students = Student.get_all()
    courses = Course.get_all()
    if not students or not courses:
        print("Need at least one student and one course.")
        return

    print("Students:")
    for s in students:
        print(f"  ID: {s['id']} - {s['first_name']} {s['last_name']}")
    print("Courses:")
    for c in courses:
        print(f"  ID: {c['id']} - {c['code']} {c['name']}")

    try:
        sid = int(input("Student ID: "))
        cid = int(input("Course ID: "))
        Enrollment.enroll(sid, cid)
        print("Student enrolled successfully.")
    except Exception as e:
        print(f"Error: {e}")


def view_all_students():
    students = Student.get_all()
    if not students:
        print("No students registered.")
        return
    print_header("All Students")
    for s in students:
        print(f"  [{s['id']}] {s['first_name']} {s['last_name']} - {s['email'] or 'N/A'}")


def view_all_teachers():
    teachers = Teacher.get_all()
    if not teachers:
        print("No teachers registered.")
        return
    print_header("All Teachers")
    for t in teachers:
        print(f"  [{t['id']}] {t['first_name']} {t['last_name']} - {t['department'] or 'N/A'}")


def view_all_courses():
    courses = Course.get_all()
    if not courses:
        print("No courses found.")
        return
    print_header("All Courses")
    for c in courses:
        teacher = c.get('teacher_name') or 'Unassigned'
        print(f"  [{c['id']}] {c['code']} - {c['name']} (Teacher: {teacher})")


# ---- Teacher functions ----

def teacher_menu(user):
    teacher = Teacher.get_by_user_id(user['id'])
    if not teacher:
        print("Teacher profile not found.")
        return

    while True:
        print_header(f"Teacher Panel - {teacher['first_name']} {teacher['last_name']}")
        options = [
            "My Courses",
            "Create Assignment",
            "Grade Assignment",
            "View Course Students",
            "Mark Attendance",
        ]
        print_menu(options)
        choice = get_choice(len(options))
        if choice == 0:
            break
        elif choice == 1:
            my_courses(teacher)
        elif choice == 2:
            create_assignment(teacher)
        elif choice == 3:
            grade_assignment(teacher)
        elif choice == 4:
            view_course_students(teacher)
        elif choice == 5:
            mark_attendance(teacher)


def my_courses(teacher):
    courses = Course.get_by_teacher(teacher['id'])
    if not courses:
        print("You have no assigned courses.")
        return
    print_header("My Courses")
    for c in courses:
        print(f"  [{c['id']}] {c['code']} - {c['name']}")


def create_assignment(teacher):
    courses = Course.get_by_teacher(teacher['id'])
    if not courses:
        print("No courses assigned to you.")
        return

    print("Your courses:")
    for c in courses:
        print(f"  [{c['id']}] {c['code']} - {c['name']}")

    try:
        cid = int(input("Course ID: "))
        title = input("Assignment title: ").strip()
        desc = input("Description: ").strip()
        due = input("Due date (YYYY-MM-DD): ").strip()
        max_marks = input("Max marks (default 100): ").strip()
        max_m = float(max_marks) if max_marks else 100
        Assignment.create(cid, title, desc or None, due or None, max_m)
        print(f"Assignment '{title}' created.")
    except Exception as e:
        print(f"Error: {e}")


def grade_assignment(teacher):
    courses = Course.get_by_teacher(teacher['id'])
    if not courses:
        print("No courses assigned.")
        return

    for c in courses:
        print(f"  [{c['id']}] {c['code']} - {c['name']}")
    try:
        cid = int(input("Course ID: "))
        assignments = Assignment.get_by_course(cid)
        if not assignments:
            print("No assignments for this course.")
            return

        for a in assignments:
            print(f"  [{a['id']}] {a['title']} (max: {a['max_marks']})")

        aid = int(input("Assignment ID: "))
        students = Enrollment.get_course_students(cid)
        if not students:
            print("No students enrolled.")
            return

        for s in students:
            marks = input(f"  {s['first_name']} {s['last_name']} - Marks (skip to leave blank): ").strip()
            if marks:
                Grade.assign_grade(s['id'], aid, float(marks))
        print("Grades saved.")
    except Exception as e:
        print(f"Error: {e}")


def view_course_students(teacher):
    courses = Course.get_by_teacher(teacher['id'])
    if not courses:
        print("No courses assigned.")
        return
    for c in courses:
        print(f"  [{c['id']}] {c['code']} - {c['name']}")
    try:
        cid = int(input("Course ID: "))
        students = Enrollment.get_course_students(cid)
        if not students:
            print("No students enrolled.")
            return
        print_header("Enrolled Students")
        for s in students:
            print(f"  {s['first_name']} {s['last_name']} - {s['email'] or 'N/A'}")
    except Exception as e:
        print(f"Error: {e}")


def mark_attendance(teacher):
    courses = Course.get_by_teacher(teacher['id'])
    if not courses:
        print("No courses assigned.")
        return
    for c in courses:
        print(f"  [{c['id']}] {c['code']} - {c['name']}")

    try:
        cid = int(input("Course ID: "))
        date = input("Date (YYYY-MM-DD): ").strip()
        students = Enrollment.get_course_students(cid)
        if not students:
            print("No students enrolled.")
            return

        for s in students:
            status = input(f"  {s['first_name']} {s['last_name']} (present/absent/late): ").strip().lower()
            if status in ('present', 'absent', 'late'):
                Attendance.mark(s['id'], cid, date, status)
        print("Attendance recorded.")
    except Exception as e:
        print(f"Error: {e}")


# ---- Student functions ----

def student_menu(user):
    student = Student.get_by_user_id(user['id'])
    if not student:
        print("Student profile not found.")
        return

    while True:
        print_header(f"Student Panel - {student['first_name']} {student['last_name']}")
        options = [
            "My Courses",
            "My Grades",
            "My Attendance",
        ]
        print_menu(options)
        choice = get_choice(len(options))
        if choice == 0:
            break
        elif choice == 1:
            student_courses(student)
        elif choice == 2:
            student_grades(student)
        elif choice == 3:
            student_attendance(student)


def student_courses(student):
    courses = Enrollment.get_student_courses(student['id'])
    if not courses:
        print("You are not enrolled in any courses.")
        return
    print_header("My Courses")
    for c in courses:
        print(f"  {c['code']} - {c['name']}")


def student_grades(student):
    grades = get_student_grade_report(student['id'])
    if not grades:
        print("No grades available yet.")
        return
    print_header("My Grades")
    for g in grades:
        print(f"  {g['course']} | {g['assignment']}: {g['marks']}/{g['max_marks']} ({g['percentage']}%)")


def student_attendance(student):
    summary = get_attendance_summary(student['id'])
    if not summary:
        print("No attendance records.")
        return
    print_header("Attendance Summary")
    for s in summary:
        rate = round(s['present'] * 100 / s['total'], 1) if s['total'] > 0 else 0
        print(f"  {s['course']}: {s['present']}/{s['total']} present ({rate}%)")


# ---- Main ----

def run():
    init_db()
    create_default_admin()
    print("\nWelcome to the School Management System")
    print("Default admin login: admin / admin123\n")

    while True:
        choice = main_menu()
        if choice == 1:
            username = input("Username: ").strip()
            password = input("Password: ").strip()
            user = login(username, password)
            if not user:
                print("Invalid credentials.")
                continue
            print(f"\nLogged in as {user['username']} ({user['role']})")

            if user['role'] == 'admin':
                admin_menu(user)
            elif user['role'] == 'teacher':
                teacher_menu(user)
            elif user['role'] == 'student':
                student_menu(user)


if __name__ == '__main__':
    run()
