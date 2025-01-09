namespace Demo
{
    internal class Program
    {
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
        }
    }
}