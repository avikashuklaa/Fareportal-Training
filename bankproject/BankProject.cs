namespace bankproject{

    public class SBAccount{

        public int AccountNumber{get; set;}

        public string? CustomerName{get; set;}

        public string? CustomerAddress{get; set;}

        public decimal CurrentBalance{get; set;}

        public SBAccount(){}

        public SBAccount(int accnum, string custn, string custadd, decimal cb){
            AccountNumber=accnum;
            CustomerName=custn;
            CustomerAddress=custadd;
            CurrentBalance=cb;
        }

        public override string ToString()
        {
            return AccountNumber + " " + CustomerName + " " + CustomerAddress + " " + CurrentBalance;
        }


    }

    public class SBTransaction{

        public int TransactionId{get; set;}

        public DateTime TransactionDate{get; set;}

        public int AccountNumber{get; set;}

        public decimal Amount{get; set;}

        public string? TransactionType{get; set;}

        public SBTransaction(){}

        public SBTransaction(int tid, DateTime tdate, int accn, decimal am, string tt){
            TransactionId=tid;
            TransactionDate=tdate;
            AccountNumber=accn;
            Amount=am;
            TransactionType=tt;
        }
    }
}