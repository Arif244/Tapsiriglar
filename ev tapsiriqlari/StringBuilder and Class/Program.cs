using System.Text;

namespace StringBuilder_and_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SrtingBuilder
            StringBuilder builder = new StringBuilder();
            //for (int i = 0; i < 10; i++)
            //{
            //    builder.AppendLine(i.ToString());

            //}
            //Console.WriteLine(builder);
            //builder.AppendLine("Arif");
            //builder.AppendLine("Kerimli");
            //Console.WriteLine(builder);

            #endregion

            //var sturent = new
            //{
            //    Name = "Arif",
            //    Surname= "Karimli",
            //    Age=29
            //};
            //Console.WriteLine(sturent);

            Student student = new Student();
            Student student1 = new Student();
            Student student2 = new Student();

            student.Age = "29";
            student.FirstName = "Arif";
            student.Surname = "Karinli";
            student.Gender = "Male";
            student.GroupNumber = "P327";
            student.Point = 89;
            student.IsGraduated = "No";


            student.ShowFullName();


        }
    }
}