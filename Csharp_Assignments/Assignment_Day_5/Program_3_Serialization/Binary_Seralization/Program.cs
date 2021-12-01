using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Binary_seralization
{
    [Serializable]
    class Employee
    {
        int empno;
        [NonSerialized]
        string ename;
        public Employee(int eno, string enm)
        {
            empno = eno;
            ename = enm;
        }
        public override string ToString()
        {
            return "Employee No " + empno + " Employee name " + ename;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "Emp_1");
            FileStream fs = new FileStream("Employee.data", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, e);
            Employee obj = (Employee)formatter.Deserialize(fs);
            Console.WriteLine(obj);
            Console.ReadKey();
        }
    }
}
