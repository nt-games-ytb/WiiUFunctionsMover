namespace WiiUFunctionsMover
{
    partial class WiiUFunctionMover
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiiUFunctionMover));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.make = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.valueMake = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.destinationAddressMake = new System.Windows.Forms.TextBox();
            this.baseAddressMake = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.destinationAddressFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.valueFind = new System.Windows.Forms.TextBox();
            this.baseAddressFind = new System.Windows.Forms.TextBox();
            this.valueFindLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.make);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.valueMake);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.destinationAddressMake);
            this.groupBox1.Controls.Add(this.baseAddressMake);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make value for move function";
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(486, 25);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(100, 50);
            this.make.TabIndex = 8;
            this.make.Text = "Make";
            this.make.UseVisualStyleBackColor = true;
            this.make.Click += new System.EventHandler(this.make_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(350, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value :";
            // 
            // valueMake
            // 
            this.valueMake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueMake.Location = new System.Drawing.Point(350, 45);
            this.valueMake.MaxLength = 8;
            this.valueMake.Name = "valueMake";
            this.valueMake.Size = new System.Drawing.Size(130, 29);
            this.valueMake.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "--->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "+";
            // 
            // destinationAddressMake
            // 
            this.destinationAddressMake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationAddressMake.Location = new System.Drawing.Point(169, 45);
            this.destinationAddressMake.MaxLength = 8;
            this.destinationAddressMake.Name = "destinationAddressMake";
            this.destinationAddressMake.Size = new System.Drawing.Size(130, 29);
            this.destinationAddressMake.TabIndex = 6;
            // 
            // baseAddressMake
            // 
            this.baseAddressMake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baseAddressMake.Location = new System.Drawing.Point(6, 45);
            this.baseAddressMake.MaxLength = 8;
            this.baseAddressMake.Name = "baseAddressMake";
            this.baseAddressMake.Size = new System.Drawing.Size(130, 29);
            this.baseAddressMake.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(169, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base address :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.find);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.destinationAddressFind);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.valueFind);
            this.groupBox2.Controls.Add(this.baseAddressFind);
            this.groupBox2.Controls.Add(this.valueFindLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find destination address";
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(486, 25);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(100, 50);
            this.find.TabIndex = 16;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(350, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Destination address :";
            // 
            // destinationAddressFind
            // 
            this.destinationAddressFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationAddressFind.Location = new System.Drawing.Point(350, 45);
            this.destinationAddressFind.MaxLength = 8;
            this.destinationAddressFind.Name = "destinationAddressFind";
            this.destinationAddressFind.Size = new System.Drawing.Size(130, 29);
            this.destinationAddressFind.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "--->";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "+";
            // 
            // valueFind
            // 
            this.valueFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueFind.Location = new System.Drawing.Point(169, 45);
            this.valueFind.MaxLength = 8;
            this.valueFind.Name = "valueFind";
            this.valueFind.Size = new System.Drawing.Size(130, 29);
            this.valueFind.TabIndex = 14;
            // 
            // baseAddressFind
            // 
            this.baseAddressFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baseAddressFind.Location = new System.Drawing.Point(6, 45);
            this.baseAddressFind.MaxLength = 8;
            this.baseAddressFind.Name = "baseAddressFind";
            this.baseAddressFind.Size = new System.Drawing.Size(130, 29);
            this.baseAddressFind.TabIndex = 12;
            // 
            // valueFindLabel
            // 
            this.valueFindLabel.AutoSize = true;
            this.valueFindLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueFindLabel.Location = new System.Drawing.Point(169, 25);
            this.valueFindLabel.Name = "valueFindLabel";
            this.valueFindLabel.Size = new System.Drawing.Size(125, 17);
            this.valueFindLabel.TabIndex = 9;
            this.valueFindLabel.Text = "Value : (Auto detect)";
            this.valueFindLabel.Click += new System.EventHandler(this.valueFindLabel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Base address :";
            // 
            // WiiUFunctionMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 191);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WiiUFunctionMover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wii U Functions Mover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox baseAddressMake;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox valueMake;
        private Label label5;
        private Label label4;
        private TextBox destinationAddressMake;
        private Label label6;
        private TextBox destinationAddressFind;
        private Label label7;
        private Label label8;
        private TextBox valueFind;
        private TextBox baseAddressFind;
        private Label valueFindLabel;
        private Label label10;
        private Button make;
        private Button find;
    }
}