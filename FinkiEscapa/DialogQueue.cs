using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinkiEscapa
{
    public class DialogQueue
    {
        List<string> dialogs = new List<string>();
        int id = 0;

        public DialogQueue()
        {
            addDialogs();

        }

        public bool hasNext()
        {
            return id < dialogs.Count;
        }

        public String next()
        {
            string ret = dialogs[id];
            id++;
            return ret;
        }


        
        private void addDialogs()
        {
            dialogs.Add("test1");
            dialogs.Add("test2");
            dialogs.Add("test3");
            dialogs.Add("test4");
            dialogs.Add("test5");
            dialogs.Add("test6");
        }

    }


}
