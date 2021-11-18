using System;

namespace FirstDay_Assignment1_ClassAndMethods
{

    /*program 3 and 5*/

    /*    Create a class Employee with data members empno, ename, designation and salary.
            Write public methods to accept and print values of all the data members.
            Call and verify class functionality using main method.*/



   /* Use class created in Example-3 and accept and 
   print values for 10 employees(using loops)*/
    class Employee
    {
        int empNo;
        String eName, designation;
        float salary;
        public void acceptEmpDetails()
        {
            Console.WriteLine("Enter emp no, name, designation and salary - ");
            empNo = Convert.ToInt32(Console.ReadLine());
            eName = Console.ReadLine();
            designation = Console.ReadLine();
            salary = Convert.ToSingle(Console.ReadLine());
        }


        public void showEmpDetails()
        {
           
            Console.WriteLine( "Emp no = {0}, ename is {1} and  designation is  {2} with  salary  {3} rs/month", empNo,eName,designation,salary);
              
        }

        static void Main(string[] args)
        {

            // Employee e = new Employee();
            // e.acceptEmpDetails();
            // e.showEmpDetails();
            // Console.ReadKey();

            Emp e1 = new Emp();
            e1.display();

        }
    }
}

namespace FirstDay_Assignment1_ClassAndMethods
{
    class Emp
    {
        public void display()
        {
            for (int i = 0; i < =10;i++)
            {
                Employee e2 = new Employee();
                e2.acceptEmpDetails();
                e2.showEmpDetails();

            }

        /*    Employee [] empArr  = new Employee[2];
            for (int i = 0; i < empArr.Length; i++)
            {
                empArr[i] = new Employee();
                empArr[i].acceptEmpDetails();        

            }

            for (int i = 0; i < empArr.Length; i++)
            {
                empArr[i].showEmpDetails();

            }  */
            Console.ReadKey();
        }
    }

}
