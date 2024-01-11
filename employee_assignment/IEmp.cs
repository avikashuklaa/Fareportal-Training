//implementing interface IEmployee

namespace oops {

    public class Permanent:IEmployee
    {

        //properties
        public float Basicpay{get; set;}

        public float Hra{get; set;}

        public float Da{get; set;}

        public float Salary{get; set;}

        public float Pf{get; set;}

        //methods
        public void AcceptDetails(){
            Console.WriteLine("Enter Permanent Employee's basicpay, HRA, DA and PF");
            Basicpay = float.Parse(Console.ReadLine());
            Hra = float.Parse(Console.ReadLine());
            Da = float.Parse(Console.ReadLine());
            Pf = float.Parse(Console.ReadLine());
        }
       

        public void CalculateSalary()
        {
            Salary = ((Basicpay + Hra + Da) - Pf);
        }

         public void DisplayDetails(){
            Console.WriteLine("Permanent Employee Basicpay : " + Basicpay);
            Console.WriteLine("Permanent Employee HRA : " + Hra);
            Console.WriteLine("Permanent Employee DA : " + Da);
            Console.WriteLine("Permanent Employee PF : " + Pf);
            Console.WriteLine("Permanent Employee Salary : " + Salary);
        }

        

        //interface methods

    }
     public class Trainee : IEmployee{

        //properties
        public float Bonus{get; set;}
        public string? Projectname{get; set;}

        public float Salary{get; set;}

        

        //methods
        public void AcceptDetails(){
            Console.WriteLine("Enter Trainee's bonus, projectname and basic salary");
            Bonus = float.Parse(Console.ReadLine());
            Projectname = Console.ReadLine();
            Salary = float.Parse(Console.ReadLine());
            
        }
       

        public void CalculateSalary()
        {
            if(Projectname.Equals("Banking")){
                Salary = (float)(Salary + (0.05*Salary));
            }
            else if(Projectname.Equals("Insurance")){
                Salary = (float)(Salary + (0.1*Salary));
            }
        }

         public void DisplayDetails(){
            Console.WriteLine("Trainee's Bonus : " + Bonus);
            Console.WriteLine("Trainee's project name : " + Projectname);
            Console.WriteLine("Trainee's Salary : " + Salary);
        }



    }
}