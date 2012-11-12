using System;
using System.Collections;
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

        public TaskInfo(string name, string day, string memo="")
        {
            this.name = name;
            this.day = day;
            this.memo = memo;
        }
        public TaskInfo()
        {
            this.name = "";
            this.memo = "";
            this.day = "";
            
        }

        public string toString()
        {
            String a = "테스크이름 : " + name + "마감기한 : " + day + " 비고 : " + memo;
            return a;
        }
    }

    class WorkerTable
    {
        string workerName;
        private Hashtable mTable = new Hashtable();

        public void addWorker(string name)
        {
            mTable.Add(name, new List<TaskInfo>());
            this.workerName = name;
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

        public string toString() {
            string a = "팀원 : " + workerName;
            return a;
        }
    }

    // 데이터베이스
    class Project
    {
        private string name;
        private List<string> mWorkersList;
        public List<string> workerList
        {
            get { return this.mWorkersList; }
        }

        private void _init()
        {
            this.mWorkersList = new List<string>();
        }

        public Project()
        {
            this.name = "empty";
            this._init();
        }

        public Project(string name)
        {
            this.name = name;
            this._init();
        }

        public Project(string name, List<string> myWorker)
        {
            this.name = name;
            this.mWorkersList = myWorker;
        }

        public void addWorker(string workerName)
        {
            this.workerList.Add(workerName);
        }

        public int getNumOfWoreker()
        {
            return this.mWorkersList.Count;
        }

        public string toString()
        {
            String a = "프로잭트 : "+name;
            return a;
        }
    }
   
}
