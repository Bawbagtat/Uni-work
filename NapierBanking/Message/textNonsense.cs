using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBanking.Message
{
    class textNonsense
    { 
        //In order to expand text speak getters and setters for both are set in here 
    public string textExpand  { get; set; }
    public string textExpanded { get; set; }

    public textNonsense(string textIn, string textOut)
    {
            textExpand = textIn;
            textExpanded = textOut;
    }
}
}
