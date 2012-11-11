using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Diagnostics;


namespace Project
{
    public partial class FormProject : Form
    {
        public FormProject()
        {
            InitializeComponent();
        }

        List<string> projectList = new List<string>();
        private WorkerTable workerTable = new WorkerTable();

        //프로잭트만들기
        private void addProject(object sender, EventArgs e)
        {
            string pj = btPj.Text;

            treeView1.Nodes.Add(pj);


        }

        //테스크 추가하기
        private void addTask(object sender, EventArgs e)
        {
            string ts = txtTs.Text;
            string day = date.Text;
            string memo = rtxMemo.Text;
            this.treeView1.SelectedNode.Nodes.Add(ts);
            string workerName = this.treeView1.SelectedNode.Text;
            TaskInfo info = new TaskInfo(ts, day, memo);
            workerTable.addTaskToWorker(this.treeView1.SelectedNode.Text, info);
        }

        // 프로잭트보기
        private void showProjects(object sender, EventArgs e)
        {
            //  FileStream fileStreamOutput = new FileStream(strFileName.txt, FileMode.Create);
            Project prj = null;
            string name = treeView1.SelectedNode.Text;
            foreach (Project project in projectList)
            {
                if (name == project.worker) {
                    prj = project;
                }
                break;
            }

            // make filename
            var path = @"c:\" + treeView1.SelectedNode.Name.ToString() + "txt";
            StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create), System.Text.Encoding.Default);
            sw.BaseStream.Seek(0, SeekOrigin.End);

            // write to file
            foreach(string workerName in prj.workerList){
                sw.WriteLine(workerName);
            }
            sw.Flush();
            sw.Close();
        }

        // 팀원추가하기
        private void addWorking(object sender, EventArgs e)
        {
            string worker = txtWorker.Text;
            string memo = rtxMemo.Text;
            try
            {
                int num = this.treeView1.SelectedNode.Nodes.Count;
            }
            catch (NullReferenceException ex)
            {
                Trace.WriteLine(ex.ToString());
                return;
            }
            this.treeView1.SelectedNode.Nodes.Add(worker);
            int pjWorker = projectList.Count;

            projectList.Add(worker);


        }



    }

    //테스크 데이터베이스
    class Project
    {
        private string memo;
        private string mWorker;
        public string worker
        {
            get { return this.mWorker; }
        }

        private ArrayList mWorkersList;
        public ArrayList workerList
        {
            get { return this.mWorkersList; }
            set { this.mWorkersList = value; }
        }

        private void _init()
        {
            this.mWorkersList = new ArrayList();
        }

        public Project()
        {
            _init();
        }

        public Project(string worker, string memo, ArrayList myWorker)
        {
            this.mWorker = worker;
            this.memo = memo;
            this.mWorkersList = myWorker;
        }

        internal void set(string worker, string memo, ArrayList myWorker)
        {
            this.mWorker = worker;
            this.memo = memo;
            this.mWorkersList = myWorker;
        }
    }


}
