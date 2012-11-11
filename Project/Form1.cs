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

        private List<Profile> projectWorker = new List<Profile>();

        //프로잭트만들기
        private void addProject(object sender, EventArgs e)
        {
            string pj = btPj.Text;
            int x = 10, y = 10;
            doDrawing(pj, x, y);

            treeView1.Nodes.Add(pj);

        }

        //테스크추가하기
 
        private void addTask(object sender, EventArgs e)
        {
            string ts = txtTs.Text;
            string day = date.Text;
            string memo = rtxMemo.Text;
            int num = this.treeView1.SelectedNode.Index;
            this.treeView1.SelectedNode.Nodes.Add(ts);
            projectWorker[num].workerList.Add(new makeTask(ts, day, memo));
            //doDrawing(ts);

        }


        // 프로잭트보기
        private void showProjects(object sender, EventArgs e)
        {
            StreamWriter txProject = new StreamWriter(new FileStream("project.txt", FileMode.Create ));
            int num;
            //인덱스가 null일경우 잡기.
             try
            {
                num = this.treeView1.SelectedNode.Nodes.Count;
            }
            catch (NullReferenceException ex)
             {
                 Trace.WriteLine(ex.ToString());
                 return;
             }
            
            makeTask[] task = new makeTask[projectWorker[num].workerList.Count];
            for (int i = 0; i < projectWorker[num].workerList.Count; i++)
            {
                task[i] = (makeTask)projectWorker[num].workerList[i];
            }
              /*foreach(makeTask i in task){
                txProject.WriteLine("테스크 : {0}, 마감기한 : {1}, 비고 : {2}", */

            
        }

        // 팀원추가하기
        private void addWorking(object sender, EventArgs e)
        {
            string worker = txtWorker.Text;
            string memo = rtxMemo.Text;

            this.treeView1.SelectedNode.Nodes.Add(worker);
            int pjWorker = projectWorker.Count;

            ArrayList myWorker = new ArrayList(); // ArrayList 생성

            //doDrawing(ts);
            //직원데이터베이스만들기
            projectWorker.Add(new Profile(worker, memo, myWorker));
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
    class makeTask
    {
        string name = "";
        string memo = "";
        string day = "";

        public makeTask(string name, string day, string memo)
        {
            this.name = name;
            this.day = day;
            this.memo = memo;
        }

    }

    //테스크 데이터베이스
    class Profile
    {
        private string worker;
        private string memo;
        private ArrayList mWorkersList;
        
        public ArrayList workerList {
            get { return this.mWorkersList; }
            set { this.mWorkersList = value; }
        }

        private void _init()
        {
            this.mWorkersList = new ArrayList();
        }

        public Profile()
        {
            _init();
        }

        public Profile(string worker, string memo, ArrayList myWorker)
        {
            this.worker = worker;
            this.memo = memo;
            this.mWorkersList = myWorker;
        }

        internal void set(string worker, string memo, ArrayList myWorker)
        {
            this.worker = worker;
            this.memo = memo;
            this.mWorkersList = myWorker;
        }
    }


}
