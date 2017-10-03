namespace Exchange
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
            this.boxFrom = new System.Windows.Forms.ComboBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.boxTo = new System.Windows.Forms.ComboBox();
            this.lblEquals = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.upperGrBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.upperGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxFrom
            // 
            this.boxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFrom.FormatString = "(\"abc\")";
            this.boxFrom.FormattingEnabled = true;
            this.boxFrom.ItemHeight = 13;
            this.boxFrom.Location = new System.Drawing.Point(17, 35);
            this.boxFrom.MaxDropDownItems = 10;
            this.boxFrom.Name = "boxFrom";
            this.boxFrom.Size = new System.Drawing.Size(80, 21);
            this.boxFrom.TabIndex = 0;
            // 
            // txtFrom
            // 
            this.txtFrom.AcceptsReturn = true;
            this.txtFrom.BackColor = System.Drawing.SystemColors.Control;
            this.txtFrom.Location = new System.Drawing.Point(149, 35);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(75, 20);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrom_KeyPress);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(281, 35);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(75, 20);
            this.txtTo.TabIndex = 3;
            // 
            // boxTo
            // 
            this.boxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTo.FormattingEnabled = true;
            this.boxTo.Location = new System.Drawing.Point(413, 35);
            this.boxTo.Name = "boxTo";
            this.boxTo.Size = new System.Drawing.Size(75, 21);
            this.boxTo.TabIndex = 2;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.Location = new System.Drawing.Point(244, 32);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(21, 24);
            this.lblEquals.TabIndex = 4;
            this.lblEquals.Text = "=";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(215, 117);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // upperGrBox
            // 
            this.upperGrBox.Controls.Add(this.label2);
            this.upperGrBox.Controls.Add(this.label1);
            this.upperGrBox.Controls.Add(this.btnConvert);
            this.upperGrBox.Controls.Add(this.lblEquals);
            this.upperGrBox.Controls.Add(this.txtTo);
            this.upperGrBox.Controls.Add(this.boxTo);
            this.upperGrBox.Controls.Add(this.txtFrom);
            this.upperGrBox.Controls.Add(this.boxFrom);
            this.upperGrBox.Enabled = false;
            this.upperGrBox.Location = new System.Drawing.Point(12, 30);
            this.upperGrBox.Name = "upperGrBox";
            this.upperGrBox.Size = new System.Drawing.Size(520, 163);
            this.upperGrBox.TabIndex = 6;
            this.upperGrBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "FROM";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(166, 302);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load Rates";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 273);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(29, 305);
            this.datePicker.MaxDate = new System.DateTime(2117, 1, 1, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(101, 20);
            this.datePicker.TabIndex = 10;
            this.datePicker.Value = new System.DateTime(2017, 10, 18, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 368);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.upperGrBox);
            this.Name = "Form1";
            this.Text = "Exchange";
            this.upperGrBox.ResumeLayout(false);
            this.upperGrBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ComboBox boxTo;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox upperGrBox;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblDate;
        protected System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

