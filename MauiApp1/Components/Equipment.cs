using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components
{
    public class Equipment
    {
        public string Equipment_Name { get; set; }
        public int Equipment_ID { get; set; }
        public string Equipment_IDToString
        {
            get => Equipment_ID.ToString();
            set
            {

                if (int.TryParse(value, out int result))
                {
                    Equipment_ID = result;
                }
                else
                {

                }
            }
        }
        
        public int Category_ID { get; set; }
        public string Category_IDToString
        {
            get => Category_ID.ToString();
            set
            {

                if (int.TryParse(value, out int result))
                {
                    Category_ID = result;
                }
                else
                {

                }
            }
        }
        public int Daily_Rate { get; set; }
        public string Daily_RateToString
        {
            get => Daily_Rate.ToString();
            set
            {

                if (int.TryParse(value, out int result))
                {
                    Daily_Rate = result;
                }
                else
                {

                }
            }
        }
        
        public string Description { get; set; }
       
    }
}
