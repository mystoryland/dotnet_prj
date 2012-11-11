using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    class WorkerTable
    {
        private Hashtable mTable = new Hashtable();

        public void addWorker(string name)
        {
            mTable.Add(name, new List<TaskInfo>());
        }

        public void addTaskToWorker(string name, TaskInfo task)
        {
            List<TaskInfo> taskList = (List<TaskInfo>)mTable[name];
            taskList.Add(task);
        }

        public List<TaskInfo> getWorkerTasks(string name)
        {
            return (List<TaskInfo>)mTable[name];
        }
    }
}
