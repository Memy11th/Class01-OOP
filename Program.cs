namespace Class01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct - OOP Class01
            //Point Node = new Point(1,3);
            //Console.WriteLine(Node);
            #endregion

            #region Encapsulation
            // Applying encapsulation made me know exactly the benefits of encapsulation 
            // Easy to rename or edit source code in class 
            // Validation on data
            // Get or set or both 
            //Employee Emp01 = new Employee(1, "Memy", 25000);
            //Console.WriteLine(Emp01);
            //Emp01.SetName("Memy jr");
            //Console.WriteLine(Emp01);
            //Console.WriteLine(Emp01.Salaryy);
            //Emp01.Salaryy = 25;
            //Console.WriteLine(Emp01.Salaryy);
            #endregion

            #region PhoneBook
            PhoneBook Note = new PhoneBook(3);
            Note.AddNewPerson(0, "Marwa", 111);
            Note.AddNewPerson(1, "Memy jr", 222);
            Note.AddNewPerson(2, "Body", 333);
            
            
            #endregion


        }
    }
}
