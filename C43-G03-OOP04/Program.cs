using C43_G03_OOP04.Interface_Example_02;

namespace Demo
{
    internal class Program
    {
        static void Printnums(ISeries series)
        {
            if (series == null)

                return;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{series.Current}\n");
                series.getNext();
            }
            series.Reset();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Interface

            #region Interface Ex 01
            //ITypes reference;
            ///Declare for reference of type "IType" Containing garbage values
            ///this ref can refere to an objevt of any type
            ///CLR will alocate for uninitalized bytes in stack for this ref
            ///CLR wil not allocate anything in the heap


            //reference = new ITypes(); Invalid

            ///reference = new TypeA();
            ///reference.MyProperty = 10;
            ///reference.MyMethod();  //Hello World
            ///reference.Print();     //Default Implemented Method


            ///TypeA typea = new TypeA();
            ///typea.MyProperty = 10;
            ///typea.MyMethod(); 
            #endregion

            #region Interface Ex 02

            //TypeA seriesBytwo = new TypeA();
            //Printnums(seriesBytwo);

            //TypeB seriesBythree = new TypeB();
            //Printnums(seriesBythree);

            //TypeC seriesByfour = new TypeC();
            //Printnums(seriesByfour);

            #endregion

            #region Interface Ex 03
            //Airplane air = new Airplane();
            //air.Speed = 480;
            //air.Forward();  Invalid Because Forward is private 

            //IMoveable moveable = air;
            //moveable.Forward();

            //IFlyable flyable = air;
            //flyable.Forward();
            #endregion

            #endregion

            #region Deep Copy VS Shallow Copy

            #region Shallow Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01= {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02= {Arr02.GetHashCode()}");

            //Arr02 = Arr01;
            //Console.WriteLine("After Shallow Copy --> Arr02 = Arr01");
            /////This Called Shallow Copy
            /////Arr02 Unreachable object

            //Console.WriteLine($"Arr01= {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02= {Arr02.GetHashCode()}");

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]); //100 

            #endregion

            #region Deep Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01= {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02= {Arr02.GetHashCode()}");

            //Arr02 = (int[]) Arr01.Clone();
            //This called Deep Copy
            //Clone will generate new object with new and different identity 
            //      this object will add the same state [Data] of the caller object

            //Console.WriteLine("After Deep Copy --> Arr02 = (int[]) Arr01.Clone()");

            //Console.WriteLine($"Arr01= {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02= {Arr02.GetHashCode()}");

            //Arr02[0] = 100;
            //Console.WriteLine();
            //foreach (int number in Arr01)
            //    Console.WriteLine(number);
            //Console.WriteLine();
            //foreach (int number in Arr02)
            //    Console.WriteLine(number);

            //Console.WriteLine(Arr01[0]); //1
            #endregion

            #endregion

            #region IClonable
            //Employee emp1 = new Employee() { ID = 7, Name = "Samer", Salary = 10000, Dep = new Department() { code = 101, Title = "Sales" } };
            //Employee emp2 = new Employee() { ID = 77, Name = "Samir", Salary = 10000, Dep = new Department() { code = 102, Title = "HR" } };
            //Console.WriteLine($"Employee 1= {emp1.GetHashCode()}");
            //Console.WriteLine($"Employee 2= {emp2.GetHashCode()}");

            //emp2 = (Employee)emp1.Clone();
            //if (emp2.Dep != null)
            //{
            //    emp2.Dep.Title = "NEW";
            //}

            //Console.WriteLine("After Copy");
            //Console.WriteLine($"Employee 1= {emp1.GetHashCode()}");
            //Console.WriteLine($"Employee 2= {emp2.GetHashCode()}");
            //Console.WriteLine();
            //Console.WriteLine($"Employee 1= {emp1}");
            //Console.WriteLine($"Employee 2= {emp2}");

            #endregion

            #region ICompareable
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Array.Sort(nums);

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //Employee[] emps = {
            //    new Employee() {ID=10, Name="Samer", Salary=10000 },
            //    new Employee() {ID=20, Name= "Ahmed", Salary=20000 },
            //    new Employee() {ID=30, Name= "Mohamed", Salary=30000 },
            //    new Employee() {ID=40, Name= "Saad", Salary=70000 }
            //};

            //Array.Sort(emps);

            //foreach (Employee emp in emps)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region IComparer
            //Employee[] emps = {
            //    new Employee() {ID=10, Name="Samer", Salary=10000 },
            //    new Employee() {ID=20, Name= "Ahmed", Salary=20000 },
            //    new Employee() {ID=30, Name= "Mohamed", Salary=30000 },
            //    new Employee() {ID=40, Name= "Saad", Salary=70000 }
            //};

            //Array.Sort(emps, new EmpComparer());

            //foreach (Employee emp in emps)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion
        }
    }
}