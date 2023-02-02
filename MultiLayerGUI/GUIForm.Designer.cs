
namespace MultiLayerGUI
{
    partial class GUIForm
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
            this.NoCustLbl = new System.Windows.Forms.Label();
            this.recListView = new System.Windows.Forms.ListView();
            this.recordsNoBox = new System.Windows.Forms.Label();
            this.EmpBtn = new System.Windows.Forms.RadioButton();
            this.OrdersBtn = new System.Windows.Forms.RadioButton();
            this.custBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // NoCustLbl
            // 
            this.NoCustLbl.AutoSize = true;
            this.NoCustLbl.Location = new System.Drawing.Point(24, 19);
            this.NoCustLbl.Name = "NoCustLbl";
            this.NoCustLbl.Size = new System.Drawing.Size(102, 13);
            this.NoCustLbl.TabIndex = 0;
            this.NoCustLbl.Text = "Number of Records:";
            // 
            // recListView
            // 
            this.recListView.HideSelection = false;
            this.recListView.Location = new System.Drawing.Point(15, 60);
            this.recListView.Name = "recListView";
            this.recListView.Size = new System.Drawing.Size(217, 137);
            this.recListView.TabIndex = 1;
            this.recListView.UseCompatibleStateImageBehavior = false;
            this.recListView.View = System.Windows.Forms.View.List;
            // 
            // recordsNoBox
            // 
            this.recordsNoBox.AutoSize = true;
            this.recordsNoBox.Location = new System.Drawing.Point(132, 19);
            this.recordsNoBox.Name = "recordsNoBox";
            this.recordsNoBox.Size = new System.Drawing.Size(0, 13);
            this.recordsNoBox.TabIndex = 2;
            // 
            // EmpBtn
            // 
            this.EmpBtn.AutoSize = true;
            this.EmpBtn.Location = new System.Drawing.Point(15, 37);
            this.EmpBtn.Name = "EmpBtn";
            this.EmpBtn.Size = new System.Drawing.Size(76, 17);
            this.EmpBtn.TabIndex = 3;
            this.EmpBtn.TabStop = true;
            this.EmpBtn.Text = "Employees";
            this.EmpBtn.UseVisualStyleBackColor = true;
            this.EmpBtn.CheckedChanged += new System.EventHandler(this.EmpBtn_CheckedChanged);
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.AutoSize = true;
            this.OrdersBtn.Location = new System.Drawing.Point(97, 37);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(56, 17);
            this.OrdersBtn.TabIndex = 4;
            this.OrdersBtn.TabStop = true;
            this.OrdersBtn.Text = "Orders";
            this.OrdersBtn.UseVisualStyleBackColor = true;
            this.OrdersBtn.CheckedChanged += new System.EventHandler(this.OrdersBtn_CheckedChanged);
            // 
            // custBtn
            // 
            this.custBtn.AutoSize = true;
            this.custBtn.Location = new System.Drawing.Point(160, 37);
            this.custBtn.Name = "custBtn";
            this.custBtn.Size = new System.Drawing.Size(74, 17);
            this.custBtn.TabIndex = 5;
            this.custBtn.TabStop = true;
            this.custBtn.Text = "Customers";
            this.custBtn.UseVisualStyleBackColor = true;
            this.custBtn.CheckedChanged += new System.EventHandler(this.custBtn_CheckedChanged);
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 209);
            this.Controls.Add(this.custBtn);
            this.Controls.Add(this.OrdersBtn);
            this.Controls.Add(this.EmpBtn);
            this.Controls.Add(this.recordsNoBox);
            this.Controls.Add(this.recListView);
            this.Controls.Add(this.NoCustLbl);
            this.Name = "GUIForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.GUIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoCustLbl;
        private System.Windows.Forms.ListView recListView;
        private System.Windows.Forms.Label recordsNoBox;
        private System.Windows.Forms.RadioButton EmpBtn;
        private System.Windows.Forms.RadioButton OrdersBtn;
        private System.Windows.Forms.RadioButton custBtn;
    }
}

