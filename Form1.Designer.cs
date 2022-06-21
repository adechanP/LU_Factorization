namespace LU_Factorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Make = new System.Windows.Forms.Button();
            this.txtBox_Col = new System.Windows.Forms.TextBox();
            this.txtBox_Row = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridView_Ans = new System.Windows.Forms.DataGridView();
            this.dtGridView_Mtx = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Ans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Mtx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGridView_Mtx);
            this.groupBox1.Controls.Add(this.btn_Calc);
            this.groupBox1.Controls.Add(this.btn_Make);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_Col);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox_Row);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridView_Ans);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btn_Calc
            // 
            resources.ApplyResources(this.btn_Calc, "btn_Calc");
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_Make
            // 
            resources.ApplyResources(this.btn_Make, "btn_Make");
            this.btn_Make.Name = "btn_Make";
            this.btn_Make.UseVisualStyleBackColor = true;
            this.btn_Make.Click += new System.EventHandler(this.btn_Make_Click);
            // 
            // txtBox_Col
            // 
            resources.ApplyResources(this.txtBox_Col, "txtBox_Col");
            this.txtBox_Col.Name = "txtBox_Col";
            // 
            // txtBox_Row
            // 
            resources.ApplyResources(this.txtBox_Row, "txtBox_Row");
            this.txtBox_Row.Name = "txtBox_Row";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dtGridView_Ans
            // 
            this.dtGridView_Ans.AllowUserToAddRows = false;
            this.dtGridView_Ans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtGridView_Ans, "dtGridView_Ans");
            this.dtGridView_Ans.Name = "dtGridView_Ans";
            // 
            // dtGridView_Mtx
            // 
            this.dtGridView_Mtx.AllowUserToAddRows = false;
            this.dtGridView_Mtx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtGridView_Mtx, "dtGridView_Mtx");
            this.dtGridView_Mtx.Name = "dtGridView_Mtx";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Ans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Mtx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridView_Mtx;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_Make;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Col;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Row;
        private System.Windows.Forms.DataGridView dtGridView_Ans;
    }
}

