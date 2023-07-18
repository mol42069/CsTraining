using accounting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csaccounting
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
    public class SaveHandler {
        protected string filename = "D:/Coding/cs/csaccounting/csaccounting/save/accounts.csv";
        public StringBuilder output;
        private Debit[] da = { };
        private Credit[] ca = { };
        public SaveHandler()
        {
            LoadFromFile();
        }

        public void NewDebit(Debit da) {
            this.da = this.da.Concat(new Debit [] { da }).ToArray();
            SaveToFile();
            return;
        }

        public void NewCredit(Credit ca) {
            this.ca = this.ca.Concat(new Credit[] { ca }).ToArray();
            SaveToFile();
            return;
        }

        public void SaveToFile() {
            string separator = ",";
            this.output = new StringBuilder();
            String[] heading = { "Username", "password", "balance", "max_credit", "intrest_rates", "last_fee" };
            output.AppendLine(string.Join(separator, heading));

            foreach (Debit acc in da)
            {
                output = acc.Save(output);
            }
            foreach (Credit acc in ca)
            {
                output = acc.Save(output);
            }

            File.WriteAllText(this.filename, output.ToString());
        }

        public Debit GetDebAcc(string username, int password) {
            foreach (Debit acc in da) {
                if (username.Equals(acc.UserName)&& password == acc.password) {
                    return acc;
                }
            }
            return null;
        }
        public bool DebitAccountXsts(string username) {
            
            foreach(Debit debacc in da) {
                if (username.Equals(debacc.UserName)) { 
                    return true;
                }
            }
            return false;
        }
        public bool CreditAccountXsts(string username)
        {

            foreach (Credit creacc in ca)
            {
                if (creacc.UserName.Equals(username))
                {
                    return true;
                }
            }
            return false;

        }

        public bool Login(string username, int password) {

            foreach (Debit debacc in da)
            {
                if (debacc.UserName == username)
                {
                    if (debacc.password == password)
                    {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            return false;

        }



        public void LoadFromFile(){
            string input = File.ReadAllText(this.filename);

            using (StreamReader rd = new StreamReader(this.filename))
            {
                while (!rd.EndOfStream)
                {
                    String[] value = null;
                    string splits = rd.ReadLine();
                    value = splits.Split(',');
                    if (value[0] == "Username") {
                    
                    }
                    else if (value.Length < 5)
                    {
                        Debit deb = new Debit (int.Parse(value[1]), float.Parse(value[2]), value[0]);
                        this.da = this.da.Concat(new Debit [] { deb }).ToArray();
                    }
                    else {
                        Credit cre = new Credit(int.Parse(value[1]), float.Parse(value[2]), value[0], float.Parse(value[3]), float.Parse(value[4]), int.Parse(value[5]));
                        this.ca = this.ca.Concat(new Credit[] { cre }).ToArray();

                    }
                }
            }

        }
    }
}

namespace accounting
{
    public class Account
    {
        public int password, wrongTrys = 0;
        public float balance;
        public bool frozen = false;
        public string UserName;

        public Account(int password, float balance, string UserName)
        {
            this.password = password;
            this.balance = balance;
            this.UserName = UserName;
        }
        protected virtual string[] Save() {
            String[] newLine = { this.UserName, this.password.ToString(), this.balance.ToString() };
            return newLine;
        }
        public float Balance_check(int password)
        {

            if (Password_check(password))
            {
                return balance;
            }
            else
            {
                return 0;
            }

        }
        public void Deposit(int ammount)
        {
            this.balance += ammount;
        }

        public virtual bool Withdraw(int ammount)
        {
            return false;
        }

        protected bool Password_check(int password)
        {

            if (this.frozen)
            {
                return false;
            }
            if (password == this.password)
            {
                return true;
            }
            else
            {
                this.wrongTrys++;
                if (this.wrongTrys == 3)
                {
                    this.frozen = true;
                }
                return false;
            }
        }
        public bool Change_pw(int password, int newPassword)
        {
            if (Password_check(password))
            {
                this.password = password;
                return true;
            }
            else return false;
        }
    }

    public class Debit : Account
    {

        public Debit(int password, float balance, string UserName) : base(password, balance, UserName)
        {

        }
        public StringBuilder Save(StringBuilder output)
        {
            string separator = ",";

            string[] newLine = base.Save();
            output.AppendLine(string.Join(separator, newLine));

            return output;

        }
        public override bool Withdraw(int ammount)
        {
            if (this.balance >= ammount)
            {
                this.balance -= ammount;
                return true;
            }
            else {
                return false;
            }
        }
    }
    

    public class Credit : Account
    {

        private float max_credit, intrest_rates;
        private int last_fee;
        public Credit(int password, float balance, string UserName, float max_credit, float intrest_rates, int last_fee) : base(password, balance, UserName)
        {
            this.last_fee = last_fee;
            this.max_credit = max_credit;
            this.intrest_rates = intrest_rates;
        }

        public StringBuilder Save(StringBuilder output) {
            string separator = ",";

            string[] newLine = base.Save();
            
            newLine = newLine.Concat(new string[] {this.max_credit.ToString(), this.intrest_rates.ToString(), this.last_fee.ToString()}).ToArray();

            output.AppendLine(string.Join(separator, newLine));

            return output;

        }

        public void TakeFee()
        {
            if (last_fee > 30)
            {
                last_fee = 0;
                if (this.balance < 0)
                {
                    this.balance -= this.balance * (intrest_rates / 100);
                }
            }
        }

        public override bool Withdraw(int ammount)
        {
            if (this.balance + max_credit >= ammount)
            {
                this.balance -= ammount;
                return true;
            }
            else {
                return false;
            }
        }
    }

   
}
