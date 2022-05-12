# School Management System

A command-line school management system built with Python and SQLite. Supports role-based access for administrators, teachers, and students.

## Features

- **Role-based authentication** (admin, teacher, student)
- **Admin panel**: register students/teachers, manage courses, enroll students
- **Teacher panel**: create assignments, grade students, mark attendance
- **Student panel**: view courses, grades, and attendance
- **SQLite database** for persistent storage
- **Grade reports** and attendance tracking

## Requirements

- Python 3.6+
- No external dependencies for core functionality

## Setup

1. Clone the repository:
   ```
   git clone https://github.com/yourusername/school-management-system.git
   cd school-management-system
   ```

2. (Optional) Install extra dependencies:
   ```
   pip install -r requirements.txt
   ```

3. Run the application:
   ```
   python -m src.main
   ```

4. Default admin credentials:
   - Username: `admin`
   - Password: `admin123`

## Database

The SQLite database (`school.db`) is created automatically on first run. The schema is defined in `schema.sql`.

## Project Structure

```
school-management-system/
├── src/
│   ├── __init__.py
│   ├── main.py          # CLI interface and menu system
│   ├── models.py        # Data models (Student, Teacher, Course, etc.)
│   ├── database.py      # Database connection and initialization
│   ├── auth.py          # Authentication and user management
│   └── reports.py       # Grade and attendance reports
├── schema.sql           # Database schema
├── requirements.txt
├── .gitignore
└── README.md
```

## Usage

After logging in, the menu system will show options based on your role:

**Admin** can register new students and teachers, create courses, assign teachers to courses, and enroll students.

**Teachers** can view their assigned courses, create assignments, grade students, and mark attendance.

**Students** can view their enrolled courses, check their grades, and see attendance records.
