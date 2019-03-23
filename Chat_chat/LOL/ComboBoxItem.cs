using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_CODie.LOL
{



    public class ComboBoxItem
   {
    string displayValue;
    int hiddenValue;

    //Constructor
    public ComboBoxItem(string d, int h)
    {
        displayValue = d;
        hiddenValue = h;
    }

    //Accessor
    public int HiddenValue
    {
        get
        {
            return hiddenValue;
        }
    }

        //Override ToString method
        public override string ToString()
        {
            return displayValue;
        }
    }
}


