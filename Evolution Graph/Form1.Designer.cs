namespace Evolution_Graph
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox9 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox8 = new TextBox();
            textBox6 = new TextBox();
            groupBox3 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            function = new Label();
            SizeOfGeneration = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(21, 31);
            chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = Color.OrangeRed;
            series1.Legend = "Legend1";
            series1.Name = "Target";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "Best in\\ngeneration";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(838, 272);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveBorder;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(48, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 152);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Evolution";
            // 
            // button4
            // 
            button4.Location = new Point(6, 85);
            button4.Name = "button4";
            button4.Size = new Size(217, 29);
            button4.TabIndex = 4;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;

            // 
            // button3
            // 
            button3.Location = new Point(106, 30);
            button3.Name = "button3";
            button3.Size = new Size(117, 29);
            button3.TabIndex = 2;
            button3.Text = "Do To Target";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 30);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Next Step";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.InactiveBorder;
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(function);
            groupBox2.Controls.Add(SizeOfGeneration);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(285, 334);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(591, 152);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parameters";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(textBox9);
            groupBox4.Location = new Point(231, 15);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(154, 74);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "start generation";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 22);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 21;
            label9.Text = "max";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(10, 43);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(57, 27);
            textBox7.TabIndex = 15;
            textBox7.Text = "-5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 23);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 18;
            label6.Text = "min";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(87, 43);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(62, 27);
            textBox9.TabIndex = 17;
            textBox9.Text = "5";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(148, 85);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 20;
            label8.Text = "round size";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 85);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 19;
            label7.Text = "split count";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(244, 107);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(57, 27);
            textBox8.TabIndex = 16;
            textBox8.Text = "2";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(149, 107);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(67, 27);
            textBox6.TabIndex = 14;
            textBox6.Text = "5";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkSalmon;
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(391, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(190, 125);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mutation";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 92);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(60, 27);
            textBox5.TabIndex = 17;
            textBox5.Text = "3";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(99, 46);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 27);
            textBox4.TabIndex = 16;
            textBox4.Text = "-3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 73);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 15;
            label5.Text = "max spread";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 23);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 14;
            label4.Text = "min spread";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 73);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 13;
            label3.Text = "count";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 27);
            textBox3.TabIndex = 11;
            textBox3.Text = "0,2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 27);
            textBox1.TabIndex = 10;
            textBox1.Text = "5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 12;
            label2.Text = "chance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 30);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 9;
            label1.Text = "target eps";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 108);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(124, 27);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // function
            // 
            function.AutoSize = true;
            function.Location = new Point(6, 30);
            function.Name = "function";
            function.Size = new Size(63, 20);
            function.TabIndex = 7;
            function.Text = "function";
            // 
            // SizeOfGeneration
            // 
            SizeOfGeneration.AutoSize = true;
            SizeOfGeneration.Location = new Point(6, 85);
            SizeOfGeneration.Name = "SizeOfGeneration";
            SizeOfGeneration.Size = new Size(124, 20);
            SizeOfGeneration.TabIndex = 6;
            SizeOfGeneration.Text = "size of generaton";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(64, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "0,5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(694, 110);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 3;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(694, 156);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 4;
            label11.Text = "label11";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 498);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Button button3;
        private Button button1;
        private GroupBox groupBox2;
        private Label SizeOfGeneration;
        private TextBox textBox2;
        private Label function;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private GroupBox groupBox4;
        private Label label10;
        private Button button4;
        private Label label11;
    }
}
