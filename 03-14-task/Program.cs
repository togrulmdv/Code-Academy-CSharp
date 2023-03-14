using _03_14_task.Models;


Group birinci = new(6);
Group ikinci= new(7);
Console.WriteLine(birinci.GroupNo);
Console.WriteLine(ikinci.GroupNo);

Student student1 = new("Togrul",28);
Student student2 = new("Musa", 29);
Student student3 = new("Mehemmed Eli", 36);
Student student4 = new("Qabil", 33);
Student student5 = new("Nihad", 58);
Student student6 = new("Memmed", 97);
Student student7 = new("Feqan", 73);

birinci.AddStudent(student1);
birinci.AddStudent(student2);
birinci.AddStudent(student3);
birinci.AddStudent(student4);
birinci.AddStudent(student5);
birinci.AddStudent(student6);
birinci.AddStudent(student7);

foreach (var student in birinci.GetAllStudents())
{
    student.ShowInfo();
}

Console.WriteLine(birinci.GetAllStudents());