namespace bankproject{

    public class BankClient{

        public static void Main(){

            IBankRepository obj = new BankRepository();

            Console.WriteLine("Enter 1 to create a new account, 2 to display all accounts details, 3 to get a particular account details, 4 to deposit, 5 to withdraw and 6 to see all the transactions");
            int i=Convert.ToInt32(Console.ReadLine);
            switch(i){
                case 1: 
                  Console.WriteLine("Enter the account number, name, address, and the balance");
                  int num = Convert.ToInt32(Console.ReadLine());
                  string name = Console.ReadLine();
                  string add = Console.ReadLine();
                  decimal bal = decimal.Parse(Console.ReadLine());
                  obj.NewAccount(new SBAccount(num, name, add, bal));
                  break;

                case 2:
                  obj.GetAllAccounts();
                  break;

                case 3:
                  Console.WriteLine("Enter the account number");
                  int anum = Convert.ToInt32(Console.ReadLine());
                  obj.GetAccountDetails(anum);
                  break;    

                case 4:
                  Console.WriteLine("Enter the account number and the amount to deposit");
                  int acnum = Convert.ToInt32(Console.ReadLine());
                  decimal amt = decimal.Parse(Console.ReadLine());
                  obj.DepositAmount(acnum, amt);
                  break;

                case 5:
                  Console.WriteLine("Enter the account number and the amount to withdraw");
                  int accnum = Convert.ToInt32(Console.ReadLine());
                  decimal amtt = decimal.Parse(Console.ReadLine());
                  obj.DepositAmount(accnum, amtt);
                  break;  

                case 6:
                  Console.WriteLine("Enter the account number");
                  int numacc = Convert.ToInt32(Console.ReadLine());                      
                  obj.GetTransactions(numacc);
                  break;

                default:
                  Console.WriteLine("Invalid Choice!");
                  break;  
            }
        }
    }
}