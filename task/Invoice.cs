using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Invoice
    {
        private readonly string _account;
        private readonly string _customer;
        private readonly string _provider;
        public string Article { get; set; }
        public string Quantity { get; set; }

        float cost;
        float edv;
        public Invoice(string account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }



        private void GetCost()
        {
            switch (Article)
            {
                case "Iphone7":
                    {
                        cost = 200;
                        break;
                    }
                case "Iphone8":
                    {
                        cost = 300;
                        break;
                    }
                case "Iphone5":
                    {
                        cost = 100;
                        break;
                    }
            }

        }
        public void CostCalculation(bool needEdv)
        {
            GetCost();

            if (needEdv)
            {
                edv = cost * 0.18F;
                cost = cost * float.Parse(Quantity) + edv;


            }
            else if (!needEdv)
            {
                cost = cost * float.Parse(Quantity);
            }
            Console.WriteLine($"Account:{_account} Customer:{_customer} Provider:{_provider}  Article:{Article}- { cost} Azn Quantity:{Quantity} ");

        }
    }
}
