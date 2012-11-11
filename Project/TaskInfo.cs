using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    //테스크인포클래스
    internal class TaskInfo
    {
        string name = "";
        string memo = "";
        string day = "";

        public TaskInfo(string name, string day, string memo)
        {
            this.name = name;
            this.day = day;
            this.memo = memo;
        }
    }

}
