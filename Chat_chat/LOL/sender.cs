using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_CODie.LOL
{
    public class sender
    {

        public string name { set; get; }
        public string family { set; get; }
        public int Id { set; get; }
        public override string ToString() => $"{name} {family}";
    }
}
