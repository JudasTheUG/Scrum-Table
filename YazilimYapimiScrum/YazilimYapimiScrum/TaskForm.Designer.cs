namespace YazilimYapimiScrum
{
    partial class TaskForm
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
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtHandler = new System.Windows.Forms.TextBox();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbStory = new System.Windows.Forms.ComboBox();
            this.lblcmbx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFD = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(387, 412);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(297, 35);
            this.btnCreateTask.TabIndex = 13;
            this.btnCreateTask.Text = "Add Task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(387, 250);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(297, 156);
            this.txtDescription.TabIndex = 12;
            // 
            // txtHandler
            // 
            this.txtHandler.Location = new System.Drawing.Point(443, 169);
            this.txtHandler.Multiline = true;
            this.txtHandler.Name = "txtHandler";
            this.txtHandler.Size = new System.Drawing.Size(178, 32);
            this.txtHandler.TabIndex = 11;
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(443, 124);
            this.txtTaskTitle.Multiline = true;
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(178, 30);
            this.txtTaskTitle.TabIndex = 10;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(307, 313);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(72, 13);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Description = ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(307, 172);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(116, 13);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Handler Of The Task =";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(307, 127);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title Of The Task = ";
            // 
            // cbStory
            // 
            this.cbStory.FormattingEnabled = true;
            this.cbStory.Location = new System.Drawing.Point(443, 77);
            this.cbStory.Name = "cbStory";
            this.cbStory.Size = new System.Drawing.Size(178, 21);
            this.cbStory.TabIndex = 14;
            // 
            // lblcmbx
            // 
            this.lblcmbx.AutoSize = true;
            this.lblcmbx.Location = new System.Drawing.Point(307, 80);
            this.lblcmbx.Name = "lblcmbx";
            this.lblcmbx.Size = new System.Drawing.Size(82, 13);
            this.lblcmbx.TabIndex = 15;
            this.lblcmbx.Text = "Choose Story = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ForseenDeadline =";
            // 
            // dtpFD
            // 
            this.dtpFD.Location = new System.Drawing.Point(443, 217);
            this.dtpFD.Name = "dtpFD";
            this.dtpFD.Size = new System.Drawing.Size(178, 20);
            this.dtpFD.TabIndex = 17;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 459);
            this.Controls.Add(this.dtpFD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcmbx);
            this.Controls.Add(this.cbStory);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtHandler);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtHandler;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbStory;
        private System.Windows.Forms.Label lblcmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFD;
    }
}