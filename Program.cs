namespace Class01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct - OOP Class01
            Point Node = new Point(1,3);
            Console.WriteLine(Node);
            #endregion

            #region Encapsulation
            Employee Emp01 = new Employee(1, "Memy", 25000);
            Console.WriteLine(Emp01);
            Emp01.SetName("Memy jr");
            Console.WriteLine(Emp01);
            Console.WriteLine(Emp01.Salaryy);
            Emp01.Salaryy = 25;
            Console.WriteLine(Emp01.Salaryy);
            #endregion
        }
    }
}
