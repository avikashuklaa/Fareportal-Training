using System.Collections;

namespace bankproject{

    public class BankRepository : IBankRepository{

        List<SBAccount> accdets = new List<SBAccount>();
        int count=1;
        List<SBTransaction> transdets = new List<SBTransaction>();

        public void DepositAmount(int accno, decimal amt)
        {
            foreach(SBAccount acc in accdets){
                if(acc.AccountNumber == accno && amt>0){
                    acc.CurrentBalance = acc.CurrentBalance + amt;
                    transdets.Add(new SBTransaction(count++, DateTime.Now, accno, amt, "Deposit"));
                }
                else{
                    throw new Exception("The amount to deposit should be greater than 0!");
                }
            }
        }

        public SBAccount GetAccountDetails(int accno)
        {
            foreach(SBAccount acc in accdets){
                if(acc.AccountNumber == accno){
                    return acc;
                }
                
            }
            throw new Exception("Account number not found!");
            
        }

        public List<SBAccount> GetAllAccounts()
        {
            return accdets;
        }

        public List<SBTransaction> GetTransactions(int accno)
        {
            
            foreach(SBTransaction tran in transdets){
                if(tran.AccountNumber==accno){
                    return transdets;
                }
            }
            throw new Exception("No trasaction found!");
        }

        public void NewAccount(SBAccount acc)
        {
            accdets.Add(new SBAccount(acc.AccountNumber, acc.CustomerName, acc.CustomerAddress, acc.CurrentBalance));
        }

        public void WithdrawAmount(int accno, decimal amt)
        {
             foreach(SBAccount acc in accdets){
                if(acc.AccountNumber == accno && acc.CurrentBalance >= amt){
                    acc.CurrentBalance = acc.CurrentBalance - amt;
                    transdets.Add(new SBTransaction(count++, DateTime.Now, accno, amt, "Withdraw"));
                }
                else{
                    throw new Exception("Current balance not enough!");
                }
            }
        }
    }
}