namespace Project
{
    partial class FormProject
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectMaking = new System.Windows.Forms.Button();
            this.btPj = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.taskMaking = new System.Windows.Forms.Button();
            this.txtTs = new System.Windows.Forms.TextBox();
            this.rtxMemo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.co_worker = new System.Windows.Forms.Button();
            this.txtWorker = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectMaking
            // 
            this.projectMaking.Location = new System.Drawing.Point(153, 20);
            this.projectMaking.Name = "projectMaking";
            this.projectMaking.Size = new System.Drawing.Size(65, 28);
            this.projectMaking.TabIndex = 1;
            this.projectMaking.Text = "프로잭트";
            this.projectMaking.UseVisualStyleBackColor = true;
            this.projectMaking.Click += new System.EventHandler(this.addProject);
            // 
            // btPj
            // 
            this.btPj.Location = new System.Drawing.Point(14, 24);
            this.btPj.Name = "btPj";
            this.btPj.Size = new System.Drawing.Size(133, 21);
            this.btPj.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 267);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(188, 295);
            this.treeView1.TabIndex = 4;
            // 
            // taskMaking
            // 
            this.taskMaking.Location = new System.Drawing.Point(153, 78);
            this.taskMaking.Name = "taskMaking";
            this.taskMaking.Size = new System.Drawing.Size(65, 24);
            this.taskMaking.TabIndex = 5;
            this.taskMaking.Text = "테스크";
            this.taskMaking.UseVisualStyleBackColor = true;
            this.taskMaking.Click += new System.EventHandler(this.addTask);
            // 
            // txtTs
            // 
            this.txtTs.Location = new System.Drawing.Point(14, 78);
            this.txtTs.Name = "txtTs";
            this.txtTs.Size = new System.Drawing.Size(133, 21);
            this.txtTs.TabIndex = 6;
            // 
            // rtxMemo
            // 
            this.rtxMemo.Location = new System.Drawing.Point(26, 152);
            this.rtxMemo.Name = "rtxMemo";
            this.rtxMemo.Size = new System.Drawing.Size(188, 100);
            this.rtxMemo.TabIndex = 8;
            this.rtxMemo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "메모";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "마감기한";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "프로잭트 보기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.outputToFile);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.co_worker);
            this.groupBox1.Controls.Add(this.txtWorker);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.projectMaking);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btPj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.taskMaking);
            this.groupBox1.Controls.Add(this.rtxMemo);
            this.groupBox1.Controls.Add(this.txtTs);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 622);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "프로잭트 만들기";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(70, 111);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(161, 21);
            this.date.TabIndex = 13;
            // 
            // co_worker
            // 
            this.co_worker.Location = new System.Drawing.Point(153, 49);
            this.co_worker.Name = "co_worker";
            this.co_worker.Size = new System.Drawing.Size(65, 23);
            this.co_worker.TabIndex = 13;
            this.co_worker.Text = "팀원";
            this.co_worker.UseVisualStyleBackColor = true;
            this.co_worker.Click += new System.EventHandler(this.addWorkerToPrj);
            // 
            // txtWorker
            // 
            this.txtWorker.Location = new System.Drawing.Point(13, 51);
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(134, 21);
            this.txtWorker.TabIndex = 12;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(290, 585);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProject";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button projectMaking;
        private System.Windows.Forms.TextBox btPj;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button taskMaking;
        private System.Windows.Forms.TextBox txtTs;
        private System.Windows.Forms.RichTextBox rtxMemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button co_worker;
        private System.Windows.Forms.TextBox txtWorker;
    }
}

