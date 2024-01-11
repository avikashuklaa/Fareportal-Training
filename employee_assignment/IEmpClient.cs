namespace oops{

    public class IEmpClient{

        public static void Main(){

            IEmployee p = new Permanent();
            p.AcceptDetails();
            p.CalculateSalary();
            p.DisplayDetails();

            IEmployee t = new Trainee();
            t.AcceptDetails();
            t.CalculateSalary();
            t.DisplayDetails();

        }
    }
}