namespace ListSharePoint
{
    partial class FormSP
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
            this.lblsite = new System.Windows.Forms.Label();
            this.txtsite = new System.Windows.Forms.TextBox();
            this.btnsite = new System.Windows.Forms.Button();
            this.lblmessage1 = new System.Windows.Forms.Label();
            this.gridlist = new System.Windows.Forms.DataGridView();
            this.lblsubsite = new System.Windows.Forms.Label();
            this.cmbsubsite = new System.Windows.Forms.ComboBox();
            this.lblmessage2 = new System.Windows.Forms.Label();
            this.btnsubsite1 = new System.Windows.Forms.Button();
            this.lbllist = new System.Windows.Forms.Label();
            this.cmblist = new System.Windows.Forms.ComboBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.lblmessage3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblallowance = new System.Windows.Forms.Label();
            this.lbllevel = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtallowance = new System.Windows.Forms.TextBox();
            this.txtlevel = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblmessage4 = new System.Windows.Forms.Label();
            this.lblmessage5 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblmessage6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridlist)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsite
            // 
            this.lblsite.AutoSize = true;
            this.lblsite.Location = new System.Drawing.Point(7, 10);
            this.lblsite.Name = "lblsite";
            this.lblsite.Size = new System.Drawing.Size(152, 13);
            this.lblsite.TabIndex = 0;
            this.lblsite.Text = "Enter Your Site Collection URL";
            // 
            // txtsite
            // 
            this.txtsite.Location = new System.Drawing.Point(169, 3);
            this.txtsite.Name = "txtsite";
            this.txtsite.Size = new System.Drawing.Size(176, 20);
            this.txtsite.TabIndex = 1;
            // 
            // btnsite
            // 
            this.btnsite.Location = new System.Drawing.Point(366, 2);
            this.btnsite.Name = "btnsite";
            this.btnsite.Size = new System.Drawing.Size(113, 25);
            this.btnsite.TabIndex = 2;
            this.btnsite.Text = "Retrieve Sub Sites";
            this.btnsite.UseVisualStyleBackColor = true;
            this.btnsite.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lblmessage1
            // 
            this.lblmessage1.AutoSize = true;
            this.lblmessage1.ForeColor = System.Drawing.Color.Red;
            this.lblmessage1.Location = new System.Drawing.Point(495, 8);
            this.lblmessage1.Name = "lblmessage1";
            this.lblmessage1.Size = new System.Drawing.Size(61, 13);
            this.lblmessage1.TabIndex = 3;
            this.lblmessage1.Text = "<message>";
            this.lblmessage1.Visible = false;
            // 
            // gridlist
            // 
            this.gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridlist.Location = new System.Drawing.Point(6, 156);
            this.gridlist.Name = "gridlist";
            this.gridlist.Size = new System.Drawing.Size(694, 259);
            this.gridlist.TabIndex = 4;
            // 
            // lblsubsite
            // 
            this.lblsubsite.AutoSize = true;
            this.lblsubsite.Location = new System.Drawing.Point(8, 36);
            this.lblsubsite.Name = "lblsubsite";
            this.lblsubsite.Size = new System.Drawing.Size(86, 13);
            this.lblsubsite.TabIndex = 5;
            this.lblsubsite.Text = "Choose Subsites";
            this.lblsubsite.Visible = false;
            // 
            // cmbsubsite
            // 
            this.cmbsubsite.FormattingEnabled = true;
            this.cmbsubsite.Location = new System.Drawing.Point(169, 33);
            this.cmbsubsite.Name = "cmbsubsite";
            this.cmbsubsite.Size = new System.Drawing.Size(176, 21);
            this.cmbsubsite.TabIndex = 6;
            this.cmbsubsite.Visible = false;
            // 
            // lblmessage2
            // 
            this.lblmessage2.AutoSize = true;
            this.lblmessage2.ForeColor = System.Drawing.Color.Red;
            this.lblmessage2.Location = new System.Drawing.Point(495, 38);
            this.lblmessage2.Name = "lblmessage2";
            this.lblmessage2.Size = new System.Drawing.Size(61, 13);
            this.lblmessage2.TabIndex = 7;
            this.lblmessage2.Text = "<message>";
            this.lblmessage2.Visible = false;
            // 
            // btnsubsite1
            // 
            this.btnsubsite1.Location = new System.Drawing.Point(366, 33);
            this.btnsubsite1.Name = "btnsubsite1";
            this.btnsubsite1.Size = new System.Drawing.Size(113, 22);
            this.btnsubsite1.TabIndex = 8;
            this.btnsubsite1.Text = "Retrieve List";
            this.btnsubsite1.UseVisualStyleBackColor = true;
            this.btnsubsite1.Visible = false;
            this.btnsubsite1.Click += new System.EventHandler(this.btnsubsite1_Click);
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Location = new System.Drawing.Point(9, 62);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(62, 13);
            this.lbllist.TabIndex = 9;
            this.lbllist.Text = "Choose List";
            this.lbllist.Visible = false;
            // 
            // cmblist
            // 
            this.cmblist.FormattingEnabled = true;
            this.cmblist.Location = new System.Drawing.Point(169, 61);
            this.cmblist.Name = "cmblist";
            this.cmblist.Size = new System.Drawing.Size(176, 21);
            this.cmblist.TabIndex = 10;
            this.cmblist.Visible = false;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(366, 61);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(113, 21);
            this.btnlist.TabIndex = 11;
            this.btnlist.Text = "Retrieve Data";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Visible = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // lblmessage3
            // 
            this.lblmessage3.AutoSize = true;
            this.lblmessage3.ForeColor = System.Drawing.Color.Red;
            this.lblmessage3.Location = new System.Drawing.Point(495, 65);
            this.lblmessage3.Name = "lblmessage3";
            this.lblmessage3.Size = new System.Drawing.Size(61, 13);
            this.lblmessage3.TabIndex = 12;
            this.lblmessage3.Text = "<message>";
            this.lblmessage3.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 447);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblmessage6);
            this.tabPage1.Controls.Add(this.btndelete);
            this.tabPage1.Controls.Add(this.gridlist);
            this.tabPage1.Controls.Add(this.lblmessage3);
            this.tabPage1.Controls.Add(this.lblsite);
            this.tabPage1.Controls.Add(this.lblmessage2);
            this.tabPage1.Controls.Add(this.btnlist);
            this.tabPage1.Controls.Add(this.lblsubsite);
            this.tabPage1.Controls.Add(this.btnsubsite1);
            this.tabPage1.Controls.Add(this.cmblist);
            this.tabPage1.Controls.Add(this.lbllist);
            this.tabPage1.Controls.Add(this.txtsite);
            this.tabPage1.Controls.Add(this.lblmessage1);
            this.tabPage1.Controls.Add(this.cmbsubsite);
            this.tabPage1.Controls.Add(this.btnsite);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Display Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblmessage5);
            this.tabPage2.Controls.Add(this.lblmessage4);
            this.tabPage2.Controls.Add(this.btnsave);
            this.tabPage2.Controls.Add(this.txtlevel);
            this.tabPage2.Controls.Add(this.txtallowance);
            this.tabPage2.Controls.Add(this.txtname);
            this.tabPage2.Controls.Add(this.txttitle);
            this.tabPage2.Controls.Add(this.lbllevel);
            this.tabPage2.Controls.Add(this.lblallowance);
            this.tabPage2.Controls.Add(this.lblname);
            this.tabPage2.Controls.Add(this.lbltitle);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add/Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Data Resource Level";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(220, 123);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(27, 13);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Title";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(220, 146);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // lblallowance
            // 
            this.lblallowance.AutoSize = true;
            this.lblallowance.Location = new System.Drawing.Point(221, 171);
            this.lblallowance.Name = "lblallowance";
            this.lblallowance.Size = new System.Drawing.Size(56, 13);
            this.lblallowance.TabIndex = 3;
            this.lblallowance.Text = "Allowance";
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Location = new System.Drawing.Point(222, 195);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(33, 13);
            this.lbllevel.TabIndex = 4;
            this.lbllevel.Text = "Level";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(301, 121);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(202, 20);
            this.txttitle.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(301, 143);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(202, 20);
            this.txtname.TabIndex = 6;
            // 
            // txtallowance
            // 
            this.txtallowance.Location = new System.Drawing.Point(301, 165);
            this.txtallowance.Name = "txtallowance";
            this.txtallowance.Size = new System.Drawing.Size(202, 20);
            this.txtallowance.TabIndex = 7;
            // 
            // txtlevel
            // 
            this.txtlevel.Location = new System.Drawing.Point(301, 187);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(202, 20);
            this.txtlevel.TabIndex = 8;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(261, 226);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(82, 26);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblmessage4
            // 
            this.lblmessage4.AutoSize = true;
            this.lblmessage4.ForeColor = System.Drawing.Color.Red;
            this.lblmessage4.Location = new System.Drawing.Point(258, 61);
            this.lblmessage4.Name = "lblmessage4";
            this.lblmessage4.Size = new System.Drawing.Size(61, 13);
            this.lblmessage4.TabIndex = 10;
            this.lblmessage4.Text = "<message>";
            this.lblmessage4.Visible = false;
            // 
            // lblmessage5
            // 
            this.lblmessage5.AutoSize = true;
            this.lblmessage5.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblmessage5.Location = new System.Drawing.Point(258, 89);
            this.lblmessage5.Name = "lblmessage5";
            this.lblmessage5.Size = new System.Drawing.Size(61, 13);
            this.lblmessage5.TabIndex = 11;
            this.lblmessage5.Text = "<message>";
            this.lblmessage5.Visible = false;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(623, 94);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(77, 21);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblmessage6
            // 
            this.lblmessage6.AutoSize = true;
            this.lblmessage6.ForeColor = System.Drawing.Color.Red;
            this.lblmessage6.Location = new System.Drawing.Point(229, 130);
            this.lblmessage6.Name = "lblmessage6";
            this.lblmessage6.Size = new System.Drawing.Size(61, 13);
            this.lblmessage6.TabIndex = 14;
            this.lblmessage6.Text = "<message>";
            this.lblmessage6.Visible = false;
            // 
            // FormSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 449);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSP";
            this.Text = "SharePoint List";
            ((System.ComponentModel.ISupportInitialize)(this.gridlist)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblsite;
        private System.Windows.Forms.TextBox txtsite;
        private System.Windows.Forms.Button btnsite;
        private System.Windows.Forms.Label lblmessage1;
        private System.Windows.Forms.DataGridView gridlist;
        private System.Windows.Forms.Label lblsubsite;
        private System.Windows.Forms.ComboBox cmbsubsite;
        private System.Windows.Forms.Label lblmessage2;
        private System.Windows.Forms.Button btnsubsite1;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.ComboBox cmblist;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Label lblmessage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtlevel;
        private System.Windows.Forms.TextBox txtallowance;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.Label lblallowance;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblmessage4;
        private System.Windows.Forms.Label lblmessage5;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblmessage6;
    }
}

