using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int VAT_ID_number { get; set; }
        public DateTime Current_Date { get; set; }
        public string Email { get; set; }
        public int Phone_Number { get; set; }
        public string Phone_NumberToString
        {
            get => Phone_Number.ToString();
            set
            {

                if (int.TryParse(value, out int result))
                {
                    Phone_Number = result;
                }
                else
                {

                }
            }
        }
        public string VAT_ID_numberToString
        {
            get => VAT_ID_number.ToString();
            set
            {

                if (int.TryParse(value, out int result))
                {
                    VAT_ID_number = result;
                }
                else
                {

                }
            }
        }
    }
}
