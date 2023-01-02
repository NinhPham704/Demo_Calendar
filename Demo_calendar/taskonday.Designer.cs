namespace Demo_calendar
{
    partial class taskonday
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckbDone = new System.Windows.Forms.CheckBox();
            this.txbTask = new System.Windows.Forms.TextBox();
            this.nmuHoursFrom = new System.Windows.Forms.NumericUpDown();
            this.nmuMinutesFrom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmuMinutesTo = new System.Windows.Forms.NumericUpDown();
            this.nmuHoursTo = new System.Windows.Forms.NumericUpDown();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmuHoursFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMinutesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMinutesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuHoursTo)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbDone
            // 
            this.ckbDone.AutoSize = true;
            this.ckbDone.Location = new System.Drawing.Point(3, 7);
            this.ckbDone.Name = "ckbDone";
            this.ckbDone.Size = new System.Drawing.Size(18, 17);
            this.ckbDone.TabIndex = 0;
            this.ckbDone.UseVisualStyleBackColor = true;
            // 
            // txbTask
            // 
            this.txbTask.Location = new System.Drawing.Point(27, 4);
            this.txbTask.Name = "txbTask";
            this.txbTask.Size = new System.Drawing.Size(322, 22);
            this.txbTask.TabIndex = 1;
            // 
            // nmuHoursFrom
            // 
            this.nmuHoursFrom.Location = new System.Drawing.Point(355, 5);
            this.nmuHoursFrom.Name = "nmuHoursFrom";
            this.nmuHoursFrom.Size = new System.Drawing.Size(36, 22);
            this.nmuHoursFrom.TabIndex = 2;
            // 
            // nmuMinutesFrom
            // 
            this.nmuMinutesFrom.Location = new System.Drawing.Point(397, 5);
            this.nmuMinutesFrom.Name = "nmuMinutesFrom";
            this.nmuMinutesFrom.Size = new System.Drawing.Size(36, 22);
            this.nmuMinutesFrom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đến";
            // 
            // nmuMinutesTo
            // 
            this.nmuMinutesTo.Location = new System.Drawing.Point(517, 5);
            this.nmuMinutesTo.Name = "nmuMinutesTo";
            this.nmuMinutesTo.Size = new System.Drawing.Size(36, 22);
            this.nmuMinutesTo.TabIndex = 6;
            // 
            // nmuHoursTo
            // 
            this.nmuHoursTo.Location = new System.Drawing.Point(475, 5);
            this.nmuHoursTo.Name = "nmuHoursTo";
            this.nmuHoursTo.Size = new System.Drawing.Size(36, 22);
            this.nmuHoursTo.TabIndex = 5;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(559, 4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 24);
            this.cboStatus.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(686, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(740, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // taskonday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.nmuMinutesTo);
            this.Controls.Add(this.nmuHoursTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmuMinutesFrom);
            this.Controls.Add(this.nmuHoursFrom);
            this.Controls.Add(this.txbTask);
            this.Controls.Add(this.ckbDone);
            this.Name = "taskonday";
            this.Size = new System.Drawing.Size(804, 30);
            ((System.ComponentModel.ISupportInitialize)(this.nmuHoursFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMinutesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMinutesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuHoursTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbDone;
        private System.Windows.Forms.TextBox txbTask;
        private System.Windows.Forms.NumericUpDown nmuHoursFrom;
        private System.Windows.Forms.NumericUpDown nmuMinutesFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmuMinutesTo;
        private System.Windows.Forms.NumericUpDown nmuHoursTo;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
