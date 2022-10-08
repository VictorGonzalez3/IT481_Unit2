
using System;

namespace IT481_Unit3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConnecttoDB = new System.Windows.Forms.Button();
            this.btnGetCusCount = new System.Windows.Forms.Button();
            this.btnGetCusList = new System.Windows.Forms.Button();
            this.btnGetOrderCount = new System.Windows.Forms.Button();
            this.btnGetOrderList = new System.Windows.Forms.Button();
            this.btnGetEmployeeCount = new System.Windows.Forms.Button();
            this.btnGetEmployee = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boxUser = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.boxServer = new System.Windows.Forms.TextBox();
            this.boxDatabase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Count Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Get Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Count Order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 580);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Get Orders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Count Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 709);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Get Employees";
            // 
            // btnConnecttoDB
            // 
            this.btnConnecttoDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnecttoDB.Location = new System.Drawing.Point(452, 319);
            this.btnConnecttoDB.Name = "btnConnecttoDB";
            this.btnConnecttoDB.Size = new System.Drawing.Size(260, 47);
            this.btnConnecttoDB.TabIndex = 7;
            this.btnConnecttoDB.Text = "Connect to Database";
            this.btnConnecttoDB.UseVisualStyleBackColor = true;
            // 
            // btnGetCusCount
            // 
            this.btnGetCusCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCusCount.Location = new System.Drawing.Point(452, 379);
            this.btnGetCusCount.Name = "btnGetCusCount";
            this.btnGetCusCount.Size = new System.Drawing.Size(260, 47);
            this.btnGetCusCount.TabIndex = 8;
            this.btnGetCusCount.Text = "Get Customer Count";
            this.btnGetCusCount.UseVisualStyleBackColor = true;
            // 
            // btnGetCusList
            // 
            this.btnGetCusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCusList.Location = new System.Drawing.Point(452, 444);
            this.btnGetCusList.Name = "btnGetCusList";
            this.btnGetCusList.Size = new System.Drawing.Size(260, 47);
            this.btnGetCusList.TabIndex = 9;
            this.btnGetCusList.Text = "Get Customers List";
            this.btnGetCusList.UseVisualStyleBackColor = true;
            // 
            // btnGetOrderCount
            // 
            this.btnGetOrderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetOrderCount.Location = new System.Drawing.Point(452, 509);
            this.btnGetOrderCount.Name = "btnGetOrderCount";
            this.btnGetOrderCount.Size = new System.Drawing.Size(260, 47);
            this.btnGetOrderCount.TabIndex = 10;
            this.btnGetOrderCount.Text = "Get Order Count";
            this.btnGetOrderCount.UseVisualStyleBackColor = true;
            // 
            // btnGetOrderList
            // 
            this.btnGetOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetOrderList.Location = new System.Drawing.Point(452, 569);
            this.btnGetOrderList.Name = "btnGetOrderList";
            this.btnGetOrderList.Size = new System.Drawing.Size(260, 47);
            this.btnGetOrderList.TabIndex = 11;
            this.btnGetOrderList.Text = "Get Orders List";
            this.btnGetOrderList.UseVisualStyleBackColor = true;
            // 
            // btnGetEmployeeCount
            // 
            this.btnGetEmployeeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetEmployeeCount.Location = new System.Drawing.Point(452, 630);
            this.btnGetEmployeeCount.Name = "btnGetEmployeeCount";
            this.btnGetEmployeeCount.Size = new System.Drawing.Size(260, 47);
            this.btnGetEmployeeCount.TabIndex = 12;
            this.btnGetEmployeeCount.Text = "Get Employee Count";
            this.btnGetEmployeeCount.UseVisualStyleBackColor = true;
            // 
            // btnGetEmployee
            // 
            this.btnGetEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetEmployee.Location = new System.Drawing.Point(452, 698);
            this.btnGetEmployee.Name = "btnGetEmployee";
            this.btnGetEmployee.Size = new System.Drawing.Size(260, 47);
            this.btnGetEmployee.TabIndex = 13;
            this.btnGetEmployee.Text = "Get Employees";
            this.btnGetEmployee.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Database";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Server";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "User";
            // 
            // boxUser
            // 
            this.boxUser.Location = new System.Drawing.Point(452, 79);
            this.boxUser.Name = "boxUser";
            this.boxUser.Size = new System.Drawing.Size(260, 22);
            this.boxUser.TabIndex = 18;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(452, 137);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(260, 22);
            this.boxPassword.TabIndex = 19;
            // 
            // boxServer
            // 
            this.boxServer.Location = new System.Drawing.Point(452, 206);
            this.boxServer.Name = "boxServer";
            this.boxServer.Size = new System.Drawing.Size(260, 22);
            this.boxServer.TabIndex = 20;
            // 
            // boxDatabase
            // 
            this.boxDatabase.Location = new System.Drawing.Point(452, 271);
            this.boxDatabase.Name = "boxDatabase";
            this.boxDatabase.Size = new System.Drawing.Size(260, 22);
            this.boxDatabase.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 782);
            this.Controls.Add(this.boxDatabase);
            this.Controls.Add(this.boxServer);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGetEmployee);
            this.Controls.Add(this.btnGetEmployeeCount);
            this.Controls.Add(this.btnGetOrderList);
            this.Controls.Add(this.btnGetOrderCount);
            this.Controls.Add(this.btnGetCusList);
            this.Controls.Add(this.btnGetCusCount);
            this.Controls.Add(this.btnConnecttoDB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConnecttoDB;
        private System.Windows.Forms.Button btnGetCusCount;
        private System.Windows.Forms.Button btnGetCusList;
        private System.Windows.Forms.Button btnGetOrderCount;
        private System.Windows.Forms.Button btnGetOrderList;
        private System.Windows.Forms.Button btnGetEmployeeCount;
        private System.Windows.Forms.Button btnGetEmployee;
        private EventHandler btnGetCusList_Click;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxUser;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.TextBox boxServer;
        private System.Windows.Forms.TextBox boxDatabase;
    }
}

