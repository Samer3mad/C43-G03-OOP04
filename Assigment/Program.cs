namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            //Question 01 --> b) To define a blueprint for a class

            //Question 02 --> a) private

            //Question 03 --> c) Only if they are static

            //Question 04 --> b) Yes, interfaces can inherit from multiple interfaces

            //Question 05 --> d) implements

            //Question 06 --> a) Yes

            //Question 07 --> c) Yes, but only for abstract members

            //Question 08 --> b) To provide a clear separation between interface and class members

            //Question 09 --> b) No, interfaces cannot have constructors

            //Question 10 --> c) By separating interface names with commas
            #endregion

            #region Patr 02

            #region Question 01
            //ICircle c = new Circle(7);

            //IRectangle r = new Rectangle(3, 4);

            //c.DisplayShapeInfo();
            //Console.WriteLine();
            //r.DisplayShapeInfo();
            #endregion

            #region Question 02
            //IAuthenticationService authService = new BasicAuthenticationService();

            //if (authService.AuthenticateUser("user", "password"))
            //{
            //    Console.WriteLine("User Authenticated Succefully");

            //    if (authService.AuthorizeUser("user", "admin"))
            //    {
            //        Console.WriteLine("User Authorized Succefully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("User not Authorized.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("User not Authenticated.");
            //}
            #endregion

            #region Question 03
            //INotificationService email = new EmailNotificationService();
            //INotificationService sms = new SmsNotificationService();
            //INotificationService push = new PushNotificationService();

            //email.SendNotification("Hello ",  "smaer@yahoo.com");
            //sms.SendNotification("Hello", "+201062227503");
            //push.SendNotification("Hello", "Samer");

            #endregion

            #endregion
        }
    }
}
