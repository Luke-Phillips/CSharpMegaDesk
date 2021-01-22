using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    enum RushOrderOptions
    {
        FourteenDay,
        SevenDay,
        FiveDay,
        ThreeDay
    }

    class DeskQuote
    {
        public static Dictionary<string, RushOrderOptions> rushOrderOptionDic
            = new Dictionary<string, RushOrderOptions> {
                { "14 day", RushOrderOptions.FourteenDay },
                { "7 day", RushOrderOptions.SevenDay },
                { "5 day", RushOrderOptions.FiveDay },
                { "3 day", RushOrderOptions.ThreeDay }
            };

        public string CustomerName { get; set; }
        public RushOrderOptions RushOrderOption { get; set; }
        public Desk Desk { get; set; }
        public DateTime Date { get; set; }

        public DeskQuote()
        {
            CustomerName = "anonymous";
            RushOrderOption = RushOrderOptions.FourteenDay;
            Desk = new Desk();
            Date = DateTime.Today; // change this to an outrageous date like 1 AD?
        }

        public DeskQuote(string customerName, RushOrderOptions rushOrderOption, Desk desk, DateTime date)
        {
            CustomerName = customerName;
            RushOrderOption = rushOrderOption;
            Desk = desk;
            Date = date;
        }
    }
}
