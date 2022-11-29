//var student = new
//{
//firstname="Arif",
//surname= "Karimli",
//age=29
//};
//Console.WriteLine(student.firstname);

string[] student_names = { "Arif","Asiman","Orxan","Hemid","Ziya"};

Console.WriteLine(student_names[1]);

for (int i = 0; i < student_names.Length; i++)
{
    Console.WriteLine(student_names[i]);
}

int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 1, 2 } };

Console.WriteLine(numbers[3,0]);