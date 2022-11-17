namespace FileADO3
{
    partial class Form1
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
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.lblStudRollno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAllStudents
            // 
            this.btnShowAllStudents.Location = new System.Drawing.Point(536, 289);
            this.btnShowAllStudents.Name = "btnShowAllStudents";
            this.btnShowAllStudents.Size = new System.Drawing.Size(153, 23);
            this.btnShowAllStudents.TabIndex = 33;
            this.btnShowAllStudents.Text = "Show All Student";
            this.btnShowAllStudents.UseVisualStyleBackColor = true;
            this.btnShowAllStudents.Click += new System.EventHandler(this.btnShowAllStudents_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(340, 150);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(282, 94);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 31;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(282, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(173, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(63, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(130, 208);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 27;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(40, 208);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 26;
            this.lblCity.Text = "City";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(130, 264);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtPercentage.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 148);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 24;
            // 
            // txtRollno
            // 
            this.txtRollno.Location = new System.Drawing.Point(130, 94);
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.Size = new System.Drawing.Size(100, 22);
            this.txtRollno.TabIndex = 23;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(30, 264);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(77, 16);
            this.lblPercentage.TabIndex = 22;
            this.lblPercentage.Text = "Percentage";
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Location = new System.Drawing.Point(30, 148);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(74, 16);
            this.lblStudName.TabIndex = 21;
            this.lblStudName.Text = "Stud Name";
            // 
            // lblStudRollno
            // 
            this.lblStudRollno.AutoSize = true;
            this.lblStudRollno.Location = new System.Drawing.Point(30, 94);
            this.lblStudRollno.Name = "lblStudRollno";
            this.lblStudRollno.Size = new System.Drawing.Size(76, 16);
            this.lblStudRollno.TabIndex = 20;
            this.lblStudRollno.Text = "Stud Rollno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAllStudents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRollno);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblStudName);
            this.Controls.Add(this.lblStudRollno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRollno;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.Label lblStudRollno;
    }
}

