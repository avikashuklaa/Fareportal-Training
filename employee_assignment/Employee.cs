
//Employee, Permanent and Trainee Classes (inheritance)


namespace oopseg2{

    public abstract class Employee {

        public int Empid{get; set;}

        public string? Empname{get; set;}

        public float Salary{get; set;}

        public DateTime Doj{get; set;}

        //methods
        public void AcceptDetails(){
            Console.WriteLine("Enter Employee Id, name, salary and date of joining");
            Empid = Convert.ToInt32(Console.ReadLine());
            Empname = Console.ReadLine();
            Salary = float.Parse(Console.ReadLine());
            Doj = Convert.ToDateTime(Console.ReadLine());
        }

        public void DisplayDetails(){
            Console.WriteLine("Employee ID : " + Empid);
            Console.WriteLine("Employee Name : " + Empname);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee Date of joining : " + Doj.ToShortDateString);
        }

        public abstract void CalculateSalary();
    }

    public class Permanent : Employee{

        //properties
        public float Basicpay{get; set;}

        public float Hra{get; set;}

        public float Da{get; set;}

        public float Pf{get; set;}

        //methods
        public void GetDetails(){
            Console.WriteLine("Enter Permanent Employee's basicpay, HRA, DA and PF");
            Basicpay = float.Parse(Console.ReadLine());
            Hra = float.Parse(Console.ReadLine());
            Da = float.Parse(Console.ReadLine());
            Pf = float.Parse(Console.ReadLine());
        }
       

        public override void CalculateSalary()
        {
            Salary = ((Basicpay + Hra + Da) - Pf);
        }

         public void ShowDetails(){
            Console.WriteLine("Permanent Employee Basicpay : " + Basicpay);
            Console.WriteLine("Permanent Employee HRA : " + Hra);
            Console.WriteLine("Permanent Employee DA : " + Da);
            Console.WriteLine("Permanent Employee PF : " + Pf);
            Console.WriteLine("Permanent Employee Salary : " + Salary);
        }

        //interface methods

    }
     public class Trainee : Employee{

        //properties
        public float Bonus{get; set;}
        public string Projectname{get; set;}

        

        //methods
        public void GetTraineeDetails(){
            Console.WriteLine("Enter Trainee's bonus, projectname");
            Bonus = float.Parse(Console.ReadLine());
            Projectname = Console.ReadLine();
            
        }
       

        public override void CalculateSalary()
        {
            if(Projectname.Equals("Banking")){
                Salary = (float)(Salary + (0.05*Salary));
            }
            else if(Projectname.Equals("Insurance")){
                Salary = (float)(Salary + (0.1*Salary));
            }
        }

         public void ShowTraineeDetails(){
            Console.WriteLine("Trainee's Bonus : " + Bonus);
            Console.WriteLine("Trainee's project name : " + Projectname);
            Console.WriteLine("Trainee's Salary : " + Salary);
        }



    }
}