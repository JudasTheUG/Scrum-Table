namespace YazilimYapimiScrum
{
    partial class ScrumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAddStory = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.pnlStory = new System.Windows.Forms.Panel();
            this.pnlToDo = new System.Windows.Forms.Panel();
            this.pnlInp = new System.Windows.Forms.Panel();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblStory = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblInp = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(956, 382);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(102, 61);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Scrum Table";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAddStory
            // 
            this.btnAddStory.Location = new System.Drawing.Point(956, 145);
            this.btnAddStory.Name = "btnAddStory";
            this.btnAddStory.Size = new System.Drawing.Size(102, 58);
            this.btnAddStory.TabIndex = 6;
            this.btnAddStory.Text = "Add Story";
            this.btnAddStory.UseVisualStyleBackColor = true;
            this.btnAddStory.Click += new System.EventHandler(this.btnAddStory_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(956, 264);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(102, 62);
            this.btnAddTask.TabIndex = 7;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // pnlStory
            // 
            this.pnlStory.BackColor = System.Drawing.Color.Violet;
            this.pnlStory.Location = new System.Drawing.Point(2, 54);
            this.pnlStory.Name = "pnlStory";
            this.pnlStory.Size = new System.Drawing.Size(233, 597);
            this.pnlStory.TabIndex = 8;
            // 
            // pnlToDo
            // 
            this.pnlToDo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlToDo.Location = new System.Drawing.Point(241, 54);
            this.pnlToDo.Name = "pnlToDo";
            this.pnlToDo.Size = new System.Drawing.Size(233, 597);
            this.pnlToDo.TabIndex = 9;
            // 
            // pnlInp
            // 
            this.pnlInp.BackColor = System.Drawing.Color.Yellow;
            this.pnlInp.Location = new System.Drawing.Point(480, 54);
            this.pnlInp.Name = "pnlInp";
            this.pnlInp.Size = new System.Drawing.Size(233, 597);
            this.pnlInp.TabIndex = 10;
            // 
            // pnlDone
            // 
            this.pnlDone.BackColor = System.Drawing.Color.Lime;
            this.pnlDone.Location = new System.Drawing.Point(719, 54);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(238, 597);
            this.pnlDone.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Violet;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 46);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(241, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 46);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox3.Location = new System.Drawing.Point(480, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(233, 46);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Lime;
            this.pictureBox4.Location = new System.Drawing.Point(719, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(238, 46);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // lblStory
            // 
            this.lblStory.AutoSize = true;
            this.lblStory.BackColor = System.Drawing.Color.Violet;
            this.lblStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStory.Location = new System.Drawing.Point(23, 11);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(201, 32);
            this.lblStory.TabIndex = 18;
            this.lblStory.Text = "     STORIES    ";
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToDo.Location = new System.Drawing.Point(278, 11);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(166, 32);
            this.lblToDo.TabIndex = 19;
            this.lblToDo.Text = "     TO DO    ";
            // 
            // lblInp
            // 
            this.lblInp.AutoSize = true;
            this.lblInp.BackColor = System.Drawing.Color.Yellow;
            this.lblInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInp.Location = new System.Drawing.Point(499, 11);
            this.lblInp.Name = "lblInp";
            this.lblInp.Size = new System.Drawing.Size(202, 32);
            this.lblInp.TabIndex = 20;
            this.lblInp.Text = "INPROGRESS";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.BackColor = System.Drawing.Color.Lime;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDone.Location = new System.Drawing.Point(761, 11);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(159, 32);
            this.lblDone.TabIndex = 21;
            this.lblDone.Text = "     DONE    ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1059, 652);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblInp);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.lblStory);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlDone);
            this.Controls.Add(this.pnlInp);
            this.Controls.Add(this.pnlToDo);
            this.Controls.Add(this.pnlStory);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnAddStory);
            this.Controls.Add(this.btnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAddStory;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Panel pnlStory;
        private System.Windows.Forms.Panel pnlToDo;
        private System.Windows.Forms.Panel pnlInp;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblInp;
        private System.Windows.Forms.Label lblDone;
    }
}

