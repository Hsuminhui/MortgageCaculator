namespace 房貸試算器
{
    partial class 房貸試算器
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(房貸試算器));
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.input4 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.downpayment = new System.Windows.Forms.ComboBox();
            this.btncaculate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gracelbl = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.borrow = new System.Windows.Forms.Label();
            this.ogmoney = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.GroupBox();
            this.output6 = new System.Windows.Forms.Label();
            this.output5 = new System.Windows.Forms.Label();
            this.output4 = new System.Windows.Forms.Label();
            this.output3 = new System.Windows.Forms.Label();
            this.output2 = new System.Windows.Forms.Label();
            this.output1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.input.SuspendLayout();
            this.output.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(533, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "房貸試算器";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.ControlLight;
            this.input.Controls.Add(this.button1);
            this.input.Controls.Add(this.input4);
            this.input.Controls.Add(this.input3);
            this.input.Controls.Add(this.input2);
            this.input.Controls.Add(this.input1);
            this.input.Controls.Add(this.downpayment);
            this.input.Controls.Add(this.btncaculate);
            this.input.Controls.Add(this.comboBox1);
            this.input.Controls.Add(this.gracelbl);
            this.input.Controls.Add(this.year);
            this.input.Controls.Add(this.borrow);
            this.input.Controls.Add(this.ogmoney);
            this.input.Controls.Add(this.price);
            this.input.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input.Location = new System.Drawing.Point(126, 144);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(485, 534);
            this.input.TabIndex = 1;
            this.input.TabStop = false;
            this.input.Text = "輸入資訊";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.CausesValidation = false;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(106, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(285, 286);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(172, 39);
            this.input4.TabIndex = 4;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(285, 214);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(172, 39);
            this.input3.TabIndex = 3;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(285, 144);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(172, 39);
            this.input2.TabIndex = 2;
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(285, 66);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(172, 39);
            this.input1.TabIndex = 0;
            // 
            // downpayment
            // 
            this.downpayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downpayment.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.downpayment.FormattingEnabled = true;
            this.downpayment.Items.AddRange(new object[] {
            "自備款比例 (%)",
            "自備款金額 (NT$)"});
            this.downpayment.Location = new System.Drawing.Point(40, 145);
            this.downpayment.Name = "downpayment";
            this.downpayment.Size = new System.Drawing.Size(216, 36);
            this.downpayment.TabIndex = 1;
            // 
            // btncaculate
            // 
            this.btncaculate.BackColor = System.Drawing.Color.ForestGreen;
            this.btncaculate.CausesValidation = false;
            this.btncaculate.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btncaculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncaculate.Location = new System.Drawing.Point(266, 445);
            this.btncaculate.Name = "btncaculate";
            this.btncaculate.Size = new System.Drawing.Size(137, 47);
            this.btncaculate.TabIndex = 10;
            this.btncaculate.Text = "開始計算";
            this.btncaculate.UseVisualStyleBackColor = false;
            this.btncaculate.Click += new System.EventHandler(this.btncaculate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "無",
            "1年",
            "2年",
            "3年",
            "4年",
            "5年"});
            this.comboBox1.Location = new System.Drawing.Point(285, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 39);
            this.comboBox1.TabIndex = 5;
            // 
            // gracelbl
            // 
            this.gracelbl.AutoSize = true;
            this.gracelbl.Location = new System.Drawing.Point(34, 359);
            this.gracelbl.Name = "gracelbl";
            this.gracelbl.Size = new System.Drawing.Size(132, 31);
            this.gracelbl.TabIndex = 4;
            this.gracelbl.Text = "寬限期 (年)";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(34, 293);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(156, 31);
            this.year.TabIndex = 3;
            this.year.Text = "貸款年限 (年)";
            // 
            // borrow
            // 
            this.borrow.AutoSize = true;
            this.borrow.Location = new System.Drawing.Point(34, 221);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(154, 31);
            this.borrow.TabIndex = 2;
            this.borrow.Text = "貸款利率 (%)";
            // 
            // ogmoney
            // 
            this.ogmoney.AutoSize = true;
            this.ogmoney.Location = new System.Drawing.Point(34, 148);
            this.ogmoney.Name = "ogmoney";
            this.ogmoney.Size = new System.Drawing.Size(0, 31);
            this.ogmoney.TabIndex = 1;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(34, 73);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(180, 31);
            this.price.TabIndex = 0;
            this.price.Text = "房屋總價 (NT$)";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.output.Controls.Add(this.output6);
            this.output.Controls.Add(this.output5);
            this.output.Controls.Add(this.output4);
            this.output.Controls.Add(this.output3);
            this.output.Controls.Add(this.output2);
            this.output.Controls.Add(this.output1);
            this.output.Controls.Add(this.label7);
            this.output.Controls.Add(this.label6);
            this.output.Controls.Add(this.label5);
            this.output.Controls.Add(this.label4);
            this.output.Controls.Add(this.label3);
            this.output.Controls.Add(this.label2);
            this.output.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output.Location = new System.Drawing.Point(668, 145);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(598, 534);
            this.output.TabIndex = 2;
            this.output.TabStop = false;
            this.output.Text = "輸出結果";
            // 
            // output6
            // 
            this.output6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output6.Location = new System.Drawing.Point(371, 426);
            this.output6.Name = "output6";
            this.output6.Size = new System.Drawing.Size(194, 31);
            this.output6.TabIndex = 23;
            // 
            // output5
            // 
            this.output5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output5.Location = new System.Drawing.Point(371, 362);
            this.output5.Name = "output5";
            this.output5.Size = new System.Drawing.Size(194, 31);
            this.output5.TabIndex = 22;
            // 
            // output4
            // 
            this.output4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output4.Location = new System.Drawing.Point(371, 293);
            this.output4.Name = "output4";
            this.output4.Size = new System.Drawing.Size(194, 31);
            this.output4.TabIndex = 21;
            // 
            // output3
            // 
            this.output3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output3.Location = new System.Drawing.Point(371, 221);
            this.output3.Name = "output3";
            this.output3.Size = new System.Drawing.Size(194, 31);
            this.output3.TabIndex = 20;
            // 
            // output2
            // 
            this.output2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output2.Location = new System.Drawing.Point(371, 145);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(194, 31);
            this.output2.TabIndex = 19;
            // 
            // output1
            // 
            this.output1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output1.Location = new System.Drawing.Point(371, 73);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(194, 31);
            this.output1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "總還款金額";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "總利息支出";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "首期本金";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "首期利息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "每月應繳金額 (本金+利息)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "貸款總金額 (NT$)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(128, 709);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(483, 210);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "【名詞介紹】\n1. 房屋總價：購買房屋的總金額\n2. 自備款：自己先支付的金額\n3. 貸款金額：房屋總價 - 自備款\n4. 年利率：銀行一年收取的利率\n5. 月利" +
    "率：年利率 ÷ 12\n6. 寬限期：只繳利息不還本金的期間";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox2.Location = new System.Drawing.Point(668, 709);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(598, 210);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // 房貸試算器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1394, 1023);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "房貸試算器";
            this.Text = "房貸試算器";
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            this.output.ResumeLayout(false);
            this.output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox input;
        private System.Windows.Forms.Label gracelbl;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label borrow;
        private System.Windows.Forms.Label ogmoney;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btncaculate;
        private System.Windows.Forms.ComboBox downpayment;
        private System.Windows.Forms.GroupBox output;
        private System.Windows.Forms.Label output6;
        private System.Windows.Forms.Label output5;
        private System.Windows.Forms.Label output4;
        private System.Windows.Forms.Label output3;
        private System.Windows.Forms.Label output2;
        private System.Windows.Forms.Label output1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input4;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
    }
}

