using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinkiEscapa
{
    public class StringData
    {
        public readonly static List<string> startGameDialogs = new List<string>() 
        {
            "str1",
            "blablablablablablba",
            "this is a very very very very very very very very very very very long text",
            "this is a super long text 123 very very long text bla bla bla bal abcdefgjhklmnoasda 12343456789 test 123 long text",
            "str5",
            "hi"

        };

        public readonly static List<string> powerOffDialog = new List<string>()
        {
            "нема струја",
            "уклуци струја",
            "hi"

        };

        public static List<string> finishLevelMessage = new List<string>()
        {
            "lvl1",
            "lvl2",
            "lvl3",
            "lvl4",
            "lvl5"

        };
    }
}
