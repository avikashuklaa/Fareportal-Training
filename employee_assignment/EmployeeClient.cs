namespace oopseg2{

    public class Client{

        public static void Main(){

            Permanent p = new Permanent();
            Trainee t = new Trainee();

            //FOR PERMANENT EMPLOYEE

            p.AcceptDetails();
            p.DisplayDetails();
            p.GetDetails();
            p.CalculateSalary();
            p.ShowDetails();  

            //FOR TRAINEE

            t.AcceptDetails();
            t.DisplayDetails();
            t.GetTraineeDetails();
            t.CalculateSalary();
            t.ShowTraineeDetails();       
            

        }
    }
}