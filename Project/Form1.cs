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

        Project project = new Project();
        private WorkerTable workerTable = new WorkerTable();

        //프로잭트만들기
        private void createProject(object sender, EventArgs e)
        {
            string pj = btPj.Text;
            treeView1.Nodes.Add(pj);
            project = new Project(pj);
        }

        // 팀원추가하기
        private void addWorkerToPrj(object sender, EventArgs e)
        {
            string workerName = txtWorker.Text;
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
            this.treeView1.SelectedNode.Nodes.Add(workerName);

            workerTable.addWorker(workerName);
            project.addWorker(workerName);
        }

        //테스크 추가하기
        private void addTask(object sender, EventArgs e)
        {
            string ts = txtTs.Text;
            string day = date.Text;
            string memo = rtxMemo.Text;
            string workerName = this.treeView1.SelectedNode.Text;

            this.treeView1.SelectedNode.Nodes.Add(ts);

            TaskInfo info = new TaskInfo(ts, day, memo);
            workerTable.addTaskToWorker(this.treeView1.SelectedNode.Text, info);
        }

        // 프로잭트보기
        private void outputToFile(object sender, EventArgs e)
        {
            //  FileStream fileStreamOutput = new FileStream(strFileName.txt, FileMode.Create);
            Project prj = null;
            string name = treeView1.SelectedNode.Text;

            // make filename
            var path = @"c:\" + treeView1.SelectedNode.Name.ToString() + "txt";
            StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create), System.Text.Encoding.Default);
            sw.BaseStream.Seek(0, SeekOrigin.End);

            // write to file
            foreach (string workerName in prj.workerList)
            {
                sw.WriteLine(workerName);
            }
            sw.Flush();
            sw.Close();
        }


    }
}
