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
            "Добредојде драг играчу во FinkiEscape. Ти си заробен во лабораторија 13 на ТМФ.",
            "Твојата задача е успешно да побегнеш од лабораторија 13, каде што бравата е електронски заклучена.",
            "Има само еден начин како да побегнеш од овде...",
            "Треба да го вклучиш компјутерот и да ја хакираш бравата за успешно да побегнеш.",
            "Вклучи го компјутерот пред себе и започни со хакирањето."
            

        };

        public readonly static List<string> powerOffDialog = new List<string>()
        {
            "Хмм.. компјутерот не сака да се вклучи, изгледа нема струја во просторијата.. ",
            "Треба да ја вклучиш струјата во просторијата и отпосле да го направиш бараното."
            

        };
    }
}
