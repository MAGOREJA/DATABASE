namespace EvaluationSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.studentlogo = new System.Windows.Forms.PictureBox();
            this.student = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.components1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.attendencelogo = new System.Windows.Forms.PictureBox();
            this.attendencebutton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.assessments = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.clo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rubric = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.TextBox();
            this.UETLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentlogo)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendencelogo)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UETLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.header);
            this.panel1.Controls.Add(this.UETLogo);
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(-1, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 328);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 219);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.studentlogo);
            this.panel3.Controls.Add(this.student);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 103);
            this.panel3.TabIndex = 18;
            // 
            // studentlogo
            // 
            this.studentlogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentlogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentlogo.Image = global::EvaluationSystem.Properties.Resources.icons8_user_account_32;
            this.studentlogo.Location = new System.Drawing.Point(0, 0);
            this.studentlogo.Name = "studentlogo";
            this.studentlogo.Size = new System.Drawing.Size(82, 103);
            this.studentlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.studentlogo.TabIndex = 5;
            this.studentlogo.TabStop = false;
            this.studentlogo.Click += new System.EventHandler(this.studentlogo_Click);
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.Color.Brown;
            this.student.Dock = System.Windows.Forms.DockStyle.Right;
            this.student.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.White;
            this.student.Location = new System.Drawing.Point(82, 0);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(118, 103);
            this.student.TabIndex = 6;
            this.student.Text = "STUDENT";
            this.student.UseVisualStyleBackColor = false;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.components1);
            this.panel7.Location = new System.Drawing.Point(511, 112);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 19;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::EvaluationSystem.Properties.Resources.icons8_menu_32;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // components1
            // 
            this.components1.BackColor = System.Drawing.Color.Brown;
            this.components1.Dock = System.Windows.Forms.DockStyle.Right;
            this.components1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.components1.ForeColor = System.Drawing.Color.White;
            this.components1.Location = new System.Drawing.Point(56, 0);
            this.components1.Name = "components1";
            this.components1.Size = new System.Drawing.Size(144, 100);
            this.components1.TabIndex = 16;
            this.components1.Text = "ASSESSMENT COMPONENTS";
            this.components1.UseVisualStyleBackColor = false;
            this.components1.Click += new System.EventHandler(this.components1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.attendencelogo);
            this.panel2.Controls.Add(this.attendencebutton);
            this.panel2.Location = new System.Drawing.Point(257, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 17;
            // 
            // attendencelogo
            // 
            this.attendencelogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.attendencelogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendencelogo.Image = global::EvaluationSystem.Properties.Resources.icons8_attendance_32;
            this.attendencelogo.Location = new System.Drawing.Point(0, 0);
            this.attendencelogo.Name = "attendencelogo";
            this.attendencelogo.Size = new System.Drawing.Size(70, 100);
            this.attendencelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.attendencelogo.TabIndex = 4;
            this.attendencelogo.TabStop = false;
            // 
            // attendencebutton
            // 
            this.attendencebutton.BackColor = System.Drawing.Color.Brown;
            this.attendencebutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.attendencebutton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendencebutton.ForeColor = System.Drawing.Color.White;
            this.attendencebutton.Location = new System.Drawing.Point(70, 0);
            this.attendencebutton.Name = "attendencebutton";
            this.attendencebutton.Size = new System.Drawing.Size(130, 100);
            this.attendencebutton.TabIndex = 7;
            this.attendencebutton.Text = "ATTENDENCE";
            this.attendencebutton.UseVisualStyleBackColor = false;
            this.attendencebutton.Click += new System.EventHandler(this.attendencebutton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.assessments);
            this.panel4.Location = new System.Drawing.Point(257, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EvaluationSystem.Properties.Resources.icons8_no_connection_32;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // assessments
            // 
            this.assessments.BackColor = System.Drawing.Color.Brown;
            this.assessments.Dock = System.Windows.Forms.DockStyle.Right;
            this.assessments.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assessments.ForeColor = System.Drawing.Color.White;
            this.assessments.Location = new System.Drawing.Point(70, 0);
            this.assessments.Name = "assessments";
            this.assessments.Size = new System.Drawing.Size(130, 100);
            this.assessments.TabIndex = 8;
            this.assessments.Text = "ASSESSMENTS";
            this.assessments.UseVisualStyleBackColor = false;
            this.assessments.Click += new System.EventHandler(this.assessments_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.clo);
            this.panel6.Location = new System.Drawing.Point(511, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::EvaluationSystem.Properties.Resources.icons8_active_directory_32;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // clo
            // 
            this.clo.BackColor = System.Drawing.Color.Brown;
            this.clo.Dock = System.Windows.Forms.DockStyle.Right;
            this.clo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clo.ForeColor = System.Drawing.Color.White;
            this.clo.Location = new System.Drawing.Point(56, 0);
            this.clo.Name = "clo";
            this.clo.Size = new System.Drawing.Size(144, 100);
            this.clo.TabIndex = 12;
            this.clo.Text = "CLO\'s";
            this.clo.UseVisualStyleBackColor = false;
            this.clo.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.rubric);
            this.panel5.Location = new System.Drawing.Point(3, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::EvaluationSystem.Properties.Resources.icons8_edit_property_32;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // rubric
            // 
            this.rubric.BackColor = System.Drawing.Color.Brown;
            this.rubric.Dock = System.Windows.Forms.DockStyle.Right;
            this.rubric.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubric.ForeColor = System.Drawing.Color.White;
            this.rubric.Location = new System.Drawing.Point(82, 0);
            this.rubric.Name = "rubric";
            this.rubric.Size = new System.Drawing.Size(118, 100);
            this.rubric.TabIndex = 9;
            this.rubric.Text = "RUBRICS";
            this.rubric.UseVisualStyleBackColor = false;
            this.rubric.Click += new System.EventHandler(this.rubric_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Image = global::EvaluationSystem.Properties.Resources.icons8_home_page_32;
            this.pictureBox4.Location = new System.Drawing.Point(757, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.header.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(106, 17);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(683, 45);
            this.header.TabIndex = 3;
            this.header.Text = "EVALUATION SYSTEM";
            this.header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header.TextChanged += new System.EventHandler(this.header_TextChanged);
            // 
            // UETLogo
            // 
            this.UETLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UETLogo.Image = global::EvaluationSystem.Properties.Resources.UETCS;
            this.UETLogo.Location = new System.Drawing.Point(0, -1);
            this.UETLogo.Name = "UETLogo";
            this.UETLogo.Size = new System.Drawing.Size(100, 98);
            this.UETLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UETLogo.TabIndex = 1;
            this.UETLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Evaluation System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentlogo)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attendencelogo)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UETLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox studentlogo;
        private System.Windows.Forms.PictureBox attendencelogo;
        private System.Windows.Forms.TextBox header;
        private System.Windows.Forms.PictureBox UETLogo;
        private System.Windows.Forms.Button attendencebutton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button clo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rubric;
        private System.Windows.Forms.Button assessments;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button components1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button student;
    }
}

