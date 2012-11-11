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

        private List<Project> projectList = new List<Project>();

        //프로잭트만들기
        private void addProject(object sender, EventArgs e)
        {
            string pj = btPj.Text;
            int x = 10, y = 10;
            doDrawing(pj, x, y);

            treeView1.Nodes.Add(pj);

        }

        //테스크 추가하기
        private void addTask(object sender, EventArgs e)
        {
            string ts = txtTs.Text;
            string day = date.Text;
            string memo = rtxMemo.Text;
            int num = this.treeView1.SelectedNode.Index;
            this.treeView1.SelectedNode.Nodes.Add(ts);
            projectList[num].workerList.Add(new TaskInfo(ts, day, memo));
            //doDrawing(ts);
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

            ArrayList myWorker = new ArrayList(); // ArrayList 생성

            //doDrawing(ts);
            //직원데이터베이스만들기
            projectList.Add(new Project(worker, memo, myWorker));
        }

        //도형그리기
        private void doDrawing(string name, int xx, int yy)
        {
            string pjName = name;
            int x = xx;
            int y = yy;
            Graphics graphics = Graphics.FromHwnd(this.Handle);
            Pen pen = Pens.Firebrick;
            Rectangle rectangle = new Rectangle(x, y, 60, 30);
            graphics.DrawRectangle(Pens.Black, rectangle);
            graphics.DrawString(pjName, new Font("돋움체", 18), Brushes.Red, rectangle);
        }

    }

    //테스크인포클래스
    class TaskInfo
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
