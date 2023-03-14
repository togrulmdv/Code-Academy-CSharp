namespace _03_14_task.Models;

internal class Group
{
    private static int _groupNo=99;
    public string GroupNo { get; set; }
    private int _studentlimit;
    internal int StudentLimit
    {
        get { return _studentlimit; } 
        set
        {
            if (value>=5 && value<=18)
            {
                _studentlimit= value;
            }
        }
    }
    private Student[] students;
    public Group(int studentLimit)
    {
        _groupNo++;
        GroupNo = "P" + _groupNo;
        StudentLimit = studentLimit;
        students= new Student[0];
    }
    public void AddStudent(Student student)
    {
        if (students.Length < _studentlimit)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
    }
    public Student[] GetAllStudents()
    {
        return students;
    }
    public Student GetStudent(int id)
    {
        foreach (var student in students)
        {
            if (student.Id == id)
                return student;
        }

        return null;
    }
}