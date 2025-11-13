using System.Windows.Forms;

namespace BankApplicationForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cbo;
        private TextBox txtAmount;
        private ListBox lst;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnInterest;
        private Button btnInfo;
        private Label lblAmount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cbo = new ComboBox();
            txtAmount = new TextBox();
            lst = new ListBox();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnInterest = new Button();
            btnInfo = new Button();
            lblAmount = new Label();

            SuspendLayout();

            // cbo
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.Location = new System.Drawing.Point(24, 24);
            cbo.Name = "cbo";
            cbo.Size = new System.Drawing.Size(180, 28);

            // txtAmount
            txtAmount.Location = new System.Drawing.Point(224, 24);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new System.Drawing.Size(120, 27);

            // lblAmount
            lblAmount.AutoSize = true;
            lblAmount.Location = new System.Drawing.Point(224, 4);
            lblAmount.Name = "lblAmount";
            lblAmount.Text = "Amount";

            // btnDeposit
            btnDeposit.Location = new System.Drawing.Point(24, 70);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new System.Drawing.Size(120, 32);
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;

            // btnWithdraw
            btnWithdraw.Location = new System.Drawing.Point(24, 110);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new System.Drawing.Size(120, 32);
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;

            // btnInterest
            btnInterest.Location = new System.Drawing.Point(24, 150);
            btnInterest.Name = "btnInterest";
            btnInterest.Size = new System.Drawing.Size(120, 32);
            btnInterest.Text = "Interest";
            btnInterest.UseVisualStyleBackColor = true;
            btnInterest.Click += btnInterest_Click;

            // btnInfo
            btnInfo.Location = new System.Drawing.Point(24, 190);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(120, 32);
            btnInfo.Text = "Info";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;

            // lst
            lst.Location = new System.Drawing.Point(224, 70);
            lst.Name = "lst";
            lst.Size = new System.Drawing.Size(380, 164);

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 260);
            Controls.Add(cbo);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnInterest);
            Controls.Add(btnInfo);
            Controls.Add(lst);
            Name = "Form1";
            Text = "Bank Application Form";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
