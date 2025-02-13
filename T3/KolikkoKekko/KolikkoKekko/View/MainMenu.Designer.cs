namespace KolikkoKekko
{
    partial class MainMenu
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            priceMax = new Label();
            priceMin = new Label();
            label2 = new Label();
            volumeMax = new Label();
            volumeMin = new Label();
            BullishEnd = new Label();
            bullishStart = new Label();
            bearishStart = new Label();
            bearishEnd = new Label();
            label5 = new Label();
            buy = new Label();
            sell = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            endDate = new Label();
            startDate = new Label();
            price = new GroupBox();
            volume = new GroupBox();
            bullish = new GroupBox();
            label6 = new Label();
            bearish = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            buySell = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            price.SuspendLayout();
            volume.SuspendLayout();
            bullish.SuspendLayout();
            bearish.SuspendLayout();
            buySell.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 518);
            button1.Name = "button1";
            button1.Size = new Size(160, 51);
            button1.TabIndex = 0;
            button1.Text = "Press me";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(291, 391);
            dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 36);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 67);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 4;
            label1.Text = "0";
            // 
            // priceMax
            // 
            priceMax.AutoSize = true;
            priceMax.Location = new Point(6, 40);
            priceMax.Name = "priceMax";
            priceMax.Size = new Size(37, 20);
            priceMax.TabIndex = 5;
            priceMax.Text = "Max";
            // 
            // priceMin
            // 
            priceMin.AutoSize = true;
            priceMin.Location = new Point(6, 72);
            priceMin.Name = "priceMin";
            priceMin.Size = new Size(34, 20);
            priceMin.TabIndex = 6;
            priceMin.Text = "Min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 72);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 7;
            label2.Text = "0";
            // 
            // volumeMax
            // 
            volumeMax.AutoSize = true;
            volumeMax.Location = new Point(6, 36);
            volumeMax.Name = "volumeMax";
            volumeMax.Size = new Size(37, 20);
            volumeMax.TabIndex = 8;
            volumeMax.Text = "Max";
            // 
            // volumeMin
            // 
            volumeMin.AutoSize = true;
            volumeMin.Location = new Point(6, 67);
            volumeMin.Name = "volumeMin";
            volumeMin.Size = new Size(34, 20);
            volumeMin.TabIndex = 9;
            volumeMin.Text = "Min";
            // 
            // BullishEnd
            // 
            BullishEnd.AutoSize = true;
            BullishEnd.Location = new Point(6, 67);
            BullishEnd.Name = "BullishEnd";
            BullishEnd.Size = new Size(34, 20);
            BullishEnd.TabIndex = 10;
            BullishEnd.Text = "End";
            // 
            // bullishStart
            // 
            bullishStart.AutoSize = true;
            bullishStart.Location = new Point(6, 36);
            bullishStart.Name = "bullishStart";
            bullishStart.Size = new Size(40, 20);
            bullishStart.TabIndex = 11;
            bullishStart.Text = "Start";
            // 
            // bearishStart
            // 
            bearishStart.AutoSize = true;
            bearishStart.Location = new Point(6, 36);
            bearishStart.Name = "bearishStart";
            bearishStart.Size = new Size(40, 20);
            bearishStart.TabIndex = 12;
            bearishStart.Text = "Start";
            // 
            // bearishEnd
            // 
            bearishEnd.AutoSize = true;
            bearishEnd.Location = new Point(6, 63);
            bearishEnd.Name = "bearishEnd";
            bearishEnd.Size = new Size(34, 20);
            bearishEnd.TabIndex = 13;
            bearishEnd.Text = "End";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 36);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 14;
            label5.Text = "0";
            // 
            // buy
            // 
            buy.AutoSize = true;
            buy.Location = new Point(6, 31);
            buy.Name = "buy";
            buy.Size = new Size(33, 20);
            buy.TabIndex = 15;
            buy.Text = "Buy";
            // 
            // sell
            // 
            sell.AutoSize = true;
            sell.Location = new Point(6, 63);
            sell.Name = "sell";
            sell.Size = new Size(33, 20);
            sell.TabIndex = 16;
            sell.Text = "Sell";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(267, 533);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(586, 538);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(240, 27);
            dateTimePicker2.TabIndex = 18;
            // 
            // endDate
            // 
            endDate.AutoSize = true;
            endDate.Location = new Point(510, 538);
            endDate.Name = "endDate";
            endDate.Size = new Size(70, 20);
            endDate.TabIndex = 19;
            endDate.Text = "End Date";
            // 
            // startDate
            // 
            startDate.AutoSize = true;
            startDate.Location = new Point(194, 533);
            startDate.Name = "startDate";
            startDate.Size = new Size(76, 20);
            startDate.TabIndex = 20;
            startDate.Text = "Start Date";
            // 
            // price
            // 
            price.Controls.Add(priceMax);
            price.Controls.Add(priceMin);
            price.Controls.Add(label1);
            price.Controls.Add(label2);
            price.Location = new Point(12, 3);
            price.Name = "price";
            price.Size = new Size(160, 112);
            price.TabIndex = 21;
            price.TabStop = false;
            price.Text = "Price";
            // 
            // volume
            // 
            volume.Controls.Add(volumeMax);
            volume.Controls.Add(volumeMin);
            volume.Controls.Add(label3);
            volume.Controls.Add(label4);
            volume.Location = new Point(188, 3);
            volume.Name = "volume";
            volume.Size = new Size(249, 112);
            volume.TabIndex = 22;
            volume.TabStop = false;
            volume.Text = "Volume";
            // 
            // bullish
            // 
            bullish.Controls.Add(label6);
            bullish.Controls.Add(bullishStart);
            bullish.Controls.Add(BullishEnd);
            bullish.Controls.Add(label5);
            bullish.Location = new Point(309, 142);
            bullish.Name = "bullish";
            bullish.Size = new Size(250, 112);
            bullish.TabIndex = 23;
            bullish.TabStop = false;
            bullish.Text = "Bullish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 67);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 26;
            label6.Text = "0";
            // 
            // bearish
            // 
            bearish.Controls.Add(label8);
            bearish.Controls.Add(label7);
            bearish.Controls.Add(bearishStart);
            bearish.Controls.Add(bearishEnd);
            bearish.Location = new Point(309, 279);
            bearish.Name = "bearish";
            bearish.Size = new Size(250, 103);
            bearish.TabIndex = 24;
            bearish.TabStop = false;
            bearish.Text = "Bearish";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 63);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 26;
            label8.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 36);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 26;
            label7.Text = "0";
            // 
            // buySell
            // 
            buySell.Controls.Add(label10);
            buySell.Controls.Add(buy);
            buySell.Controls.Add(label9);
            buySell.Controls.Add(sell);
            buySell.Location = new Point(315, 388);
            buySell.Name = "buySell";
            buySell.Size = new Size(250, 103);
            buySell.TabIndex = 25;
            buySell.TabStop = false;
            buySell.Text = "Best buy then sell";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 63);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 27;
            label10.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 31);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 26;
            label9.Text = "0";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 581);
            Controls.Add(buySell);
            Controls.Add(bearish);
            Controls.Add(bullish);
            Controls.Add(volume);
            Controls.Add(price);
            Controls.Add(startDate);
            Controls.Add(endDate);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "MainMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            price.ResumeLayout(false);
            price.PerformLayout();
            volume.ResumeLayout(false);
            volume.PerformLayout();
            bullish.ResumeLayout(false);
            bullish.PerformLayout();
            bearish.ResumeLayout(false);
            bearish.PerformLayout();
            buySell.ResumeLayout(false);
            buySell.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label priceMax;
        private Label priceMin;
        private Label label2;
        private Label volumeMax;
        private Label volumeMin;
        private Label BullishEnd;
        private Label bullishStart;
        private Label bearishStart;
        private Label bearishEnd;
        private Label label5;
        private Label buy;
        private Label sell;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label endDate;
        private Label startDate;
        private GroupBox price;
        private GroupBox volume;
        private GroupBox bullish;
        private GroupBox bearish;
        private GroupBox buySell;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
