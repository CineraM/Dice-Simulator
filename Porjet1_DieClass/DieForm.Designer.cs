
namespace Porjet1_DieClass
{
    partial class DieForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.die2 = new System.Windows.Forms.PictureBox();
            this.buttonStats = new System.Windows.Forms.Button();
            this.die1 = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_InputSeed_d1 = new System.Windows.Forms.Label();
            this.buttonSetSeed_d1 = new System.Windows.Forms.Button();
            this.labelSeed_d1 = new System.Windows.Forms.Label();
            this.listBox_Stats = new System.Windows.Forms.ListBox();
            this.textSeedInput_d1 = new System.Windows.Forms.TextBox();
            this.label_mean_d1 = new System.Windows.Forms.Label();
            this.button_sum_of_2_dice = new System.Windows.Forms.Button();
            this.pictureBox_die_1_max = new System.Windows.Forms.PictureBox();
            this.label_die1_max = new System.Windows.Forms.Label();
            this.label_die1_min = new System.Windows.Forms.Label();
            this.pictureBox_die_1_min = new System.Windows.Forms.PictureBox();
            this.pictureBox_die_2_min = new System.Windows.Forms.PictureBox();
            this.pictureBox_die_2_max = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_die2_min = new System.Windows.Forms.Label();
            this.label_die2_max = new System.Windows.Forms.Label();
            this.label_mean_d2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_die_sum_max = new System.Windows.Forms.Label();
            this.pictureBox_die_sum_max = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_die_sum_min = new System.Windows.Forms.Label();
            this.pictureBox_die_sum_min = new System.Windows.Forms.PictureBox();
            this.label_die_sum_mean = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_die_1_title = new System.Windows.Forms.Label();
            this.label_die_2_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_1_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_1_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_2_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_2_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_sum_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_sum_min)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRoll
            // 
            this.buttonRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoll.Location = new System.Drawing.Point(28, 257);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(240, 67);
            this.buttonRoll.TabIndex = 2;
            this.buttonRoll.Text = "ROLL!";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // die2
            // 
            this.die2.BackColor = System.Drawing.Color.Transparent;
            this.die2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.die2.InitialImage = global::Porjet1_DieClass.Properties.Resources.d6;
            this.die2.Location = new System.Drawing.Point(283, 35);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(239, 211);
            this.die2.TabIndex = 3;
            this.die2.TabStop = false;
            // 
            // buttonStats
            // 
            this.buttonStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStats.Location = new System.Drawing.Point(28, 338);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(240, 67);
            this.buttonStats.TabIndex = 3;
            this.buttonStats.Text = "STATISTICS!";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // die1
            // 
            this.die1.BackColor = System.Drawing.Color.Transparent;
            this.die1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.die1.InitialImage = global::Porjet1_DieClass.Properties.Resources.d6;
            this.die1.Location = new System.Drawing.Point(12, 35);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(239, 211);
            this.die1.TabIndex = 7;
            this.die1.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Location = new System.Drawing.Point(28, 495);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(380, 67);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // chartHistogram
            // 
            this.chartHistogram.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend5);
            this.chartHistogram.Location = new System.Drawing.Point(429, 340);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Size = new System.Drawing.Size(510, 237);
            this.chartHistogram.TabIndex = 10;
            this.chartHistogram.Text = "Histogram";
            this.chartHistogram.Click += new System.EventHandler(this.chartHistogram_Click);
            // 
            // label_InputSeed_d1
            // 
            this.label_InputSeed_d1.AutoSize = true;
            this.label_InputSeed_d1.Location = new System.Drawing.Point(538, 22);
            this.label_InputSeed_d1.Name = "label_InputSeed_d1";
            this.label_InputSeed_d1.Size = new System.Drawing.Size(45, 17);
            this.label_InputSeed_d1.TabIndex = 12;
            this.label_InputSeed_d1.Text = "Seed:";
            this.label_InputSeed_d1.Click += new System.EventHandler(this.label_Input_Click);
            // 
            // buttonSetSeed_d1
            // 
            this.buttonSetSeed_d1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetSeed_d1.Location = new System.Drawing.Point(702, 17);
            this.buttonSetSeed_d1.Name = "buttonSetSeed_d1";
            this.buttonSetSeed_d1.Size = new System.Drawing.Size(100, 30);
            this.buttonSetSeed_d1.TabIndex = 14;
            this.buttonSetSeed_d1.Text = "Set Seed";
            this.buttonSetSeed_d1.UseVisualStyleBackColor = true;
            this.buttonSetSeed_d1.Click += new System.EventHandler(this.buttonSetSeed_Click);
            // 
            // labelSeed_d1
            // 
            this.labelSeed_d1.AutoSize = true;
            this.labelSeed_d1.Location = new System.Drawing.Point(814, 22);
            this.labelSeed_d1.Name = "labelSeed_d1";
            this.labelSeed_d1.Size = new System.Drawing.Size(46, 17);
            this.labelSeed_d1.TabIndex = 15;
            this.labelSeed_d1.Text = "label1";
            // 
            // listBox_Stats
            // 
            this.listBox_Stats.FormattingEnabled = true;
            this.listBox_Stats.ItemHeight = 16;
            this.listBox_Stats.Location = new System.Drawing.Point(283, 258);
            this.listBox_Stats.Name = "listBox_Stats";
            this.listBox_Stats.Size = new System.Drawing.Size(125, 228);
            this.listBox_Stats.TabIndex = 6;
            // 
            // textSeedInput_d1
            // 
            this.textSeedInput_d1.Location = new System.Drawing.Point(587, 20);
            this.textSeedInput_d1.Name = "textSeedInput_d1";
            this.textSeedInput_d1.Size = new System.Drawing.Size(100, 22);
            this.textSeedInput_d1.TabIndex = 7;
            this.textSeedInput_d1.Text = "999";
            this.textSeedInput_d1.TextChanged += new System.EventHandler(this.textSeedInput_d1_TextChanged);
            // 
            // label_mean_d1
            // 
            this.label_mean_d1.AutoSize = true;
            this.label_mean_d1.Location = new System.Drawing.Point(580, 69);
            this.label_mean_d1.Name = "label_mean_d1";
            this.label_mean_d1.Size = new System.Drawing.Size(96, 17);
            this.label_mean_d1.TabIndex = 32;
            this.label_mean_d1.Text = "Die 1 Mean: 0";
            // 
            // button_sum_of_2_dice
            // 
            this.button_sum_of_2_dice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sum_of_2_dice.Location = new System.Drawing.Point(28, 416);
            this.button_sum_of_2_dice.Name = "button_sum_of_2_dice";
            this.button_sum_of_2_dice.Size = new System.Drawing.Size(240, 67);
            this.button_sum_of_2_dice.TabIndex = 4;
            this.button_sum_of_2_dice.Text = "SUM OF 2 DICE";
            this.button_sum_of_2_dice.UseVisualStyleBackColor = true;
            this.button_sum_of_2_dice.Click += new System.EventHandler(this.button_sum_of_2_dice_Click);
            // 
            // pictureBox_die_1_max
            // 
            this.pictureBox_die_1_max.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_die_1_max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_1_max.InitialImage = global::Porjet1_DieClass.Properties.Resources.d6;
            this.pictureBox_die_1_max.Location = new System.Drawing.Point(541, 119);
            this.pictureBox_die_1_max.Name = "pictureBox_die_1_max";
            this.pictureBox_die_1_max.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_1_max.TabIndex = 36;
            this.pictureBox_die_1_max.TabStop = false;
            // 
            // label_die1_max
            // 
            this.label_die1_max.AutoSize = true;
            this.label_die1_max.Location = new System.Drawing.Point(537, 204);
            this.label_die1_max.Name = "label_die1_max";
            this.label_die1_max.Size = new System.Drawing.Size(36, 17);
            this.label_die1_max.TabIndex = 37;
            this.label_die1_max.Text = "f = 0";
            // 
            // label_die1_min
            // 
            this.label_die1_min.AutoSize = true;
            this.label_die1_min.Location = new System.Drawing.Point(628, 204);
            this.label_die1_min.Name = "label_die1_min";
            this.label_die1_min.Size = new System.Drawing.Size(36, 17);
            this.label_die1_min.TabIndex = 39;
            this.label_die1_min.Text = "f = 0";
            // 
            // pictureBox_die_1_min
            // 
            this.pictureBox_die_1_min.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_die_1_min.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_1_min.InitialImage = global::Porjet1_DieClass.Properties.Resources.d6;
            this.pictureBox_die_1_min.Location = new System.Drawing.Point(632, 119);
            this.pictureBox_die_1_min.Name = "pictureBox_die_1_min";
            this.pictureBox_die_1_min.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_1_min.TabIndex = 38;
            this.pictureBox_die_1_min.TabStop = false;
            // 
            // pictureBox_die_2_min
            // 
            this.pictureBox_die_2_min.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_die_2_min.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_2_min.InitialImage = global::Porjet1_DieClass.Properties.Resources.d6;
            this.pictureBox_die_2_min.Location = new System.Drawing.Point(834, 118);
            this.pictureBox_die_2_min.Name = "pictureBox_die_2_min";
            this.pictureBox_die_2_min.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_2_min.TabIndex = 42;
            this.pictureBox_die_2_min.TabStop = false;
            // 
            // pictureBox_die_2_max
            // 
            this.pictureBox_die_2_max.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_die_2_max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_2_max.InitialImage = global::Porjet1_DieClass.Properties.Resources.d6;
            this.pictureBox_die_2_max.Location = new System.Drawing.Point(743, 118);
            this.pictureBox_die_2_max.Name = "pictureBox_die_2_max";
            this.pictureBox_die_2_max.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_2_max.TabIndex = 40;
            this.pictureBox_die_2_max.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Die 1 MIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Die 1 MAX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(838, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Die 2 MIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Die 2 MAX";
            // 
            // label_die2_min
            // 
            this.label_die2_min.AutoSize = true;
            this.label_die2_min.Location = new System.Drawing.Point(830, 204);
            this.label_die2_min.Name = "label_die2_min";
            this.label_die2_min.Size = new System.Drawing.Size(36, 17);
            this.label_die2_min.TabIndex = 49;
            this.label_die2_min.Text = "f = 0";
            // 
            // label_die2_max
            // 
            this.label_die2_max.AutoSize = true;
            this.label_die2_max.Location = new System.Drawing.Point(739, 204);
            this.label_die2_max.Name = "label_die2_max";
            this.label_die2_max.Size = new System.Drawing.Size(36, 17);
            this.label_die2_max.TabIndex = 48;
            this.label_die2_max.Text = "f = 0";
            // 
            // label_mean_d2
            // 
            this.label_mean_d2.AutoSize = true;
            this.label_mean_d2.Location = new System.Drawing.Point(782, 69);
            this.label_mean_d2.Name = "label_mean_d2";
            this.label_mean_d2.Size = new System.Drawing.Size(96, 17);
            this.label_mean_d2.TabIndex = 50;
            this.label_mean_d2.Text = "Die 2 Mean: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Sum of 2 Dice";
            // 
            // label_die_sum_max
            // 
            this.label_die_sum_max.AutoSize = true;
            this.label_die_sum_max.Location = new System.Drawing.Point(526, 323);
            this.label_die_sum_max.Name = "label_die_sum_max";
            this.label_die_sum_max.Size = new System.Drawing.Size(36, 17);
            this.label_die_sum_max.TabIndex = 53;
            this.label_die_sum_max.Text = "f = 0";
            // 
            // pictureBox_die_sum_max
            // 
            this.pictureBox_die_sum_max.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_die_sum_max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_sum_max.InitialImage = global::Porjet1_DieClass.Properties.Resources.d12;
            this.pictureBox_die_sum_max.Location = new System.Drawing.Point(530, 238);
            this.pictureBox_die_sum_max.Name = "pictureBox_die_sum_max";
            this.pictureBox_die_sum_max.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_sum_max.TabIndex = 52;
            this.pictureBox_die_sum_max.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Sum of 2 Dice";
            // 
            // label_die_sum_min
            // 
            this.label_die_sum_min.AutoSize = true;
            this.label_die_sum_min.Location = new System.Drawing.Point(715, 323);
            this.label_die_sum_min.Name = "label_die_sum_min";
            this.label_die_sum_min.Size = new System.Drawing.Size(36, 17);
            this.label_die_sum_min.TabIndex = 59;
            this.label_die_sum_min.Text = "f = 0";
            // 
            // pictureBox_die_sum_min
            // 
            this.pictureBox_die_sum_min.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_die_sum_min.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_die_sum_min.InitialImage = global::Porjet1_DieClass.Properties.Resources.d0;
            this.pictureBox_die_sum_min.Location = new System.Drawing.Point(719, 238);
            this.pictureBox_die_sum_min.Name = "pictureBox_die_sum_min";
            this.pictureBox_die_sum_min.Size = new System.Drawing.Size(82, 82);
            this.pictureBox_die_sum_min.TabIndex = 58;
            this.pictureBox_die_sum_min.TabStop = false;
            // 
            // label_die_sum_mean
            // 
            this.label_die_sum_mean.AutoSize = true;
            this.label_die_sum_mean.Location = new System.Drawing.Point(817, 281);
            this.label_die_sum_mean.Name = "label_die_sum_mean";
            this.label_die_sum_mean.Size = new System.Drawing.Size(59, 17);
            this.label_die_sum_mean.TabIndex = 63;
            this.label_die_sum_mean.Text = "Mean: 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(816, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 62;
            this.label12.Text = "Sum of 2 Dice";
            // 
            // label_die_1_title
            // 
            this.label_die_1_title.AutoSize = true;
            this.label_die_1_title.BackColor = System.Drawing.Color.Transparent;
            this.label_die_1_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_die_1_title.Location = new System.Drawing.Point(91, 1);
            this.label_die_1_title.Name = "label_die_1_title";
            this.label_die_1_title.Size = new System.Drawing.Size(86, 32);
            this.label_die_1_title.TabIndex = 64;
            this.label_die_1_title.Text = "Die 1";
            // 
            // label_die_2_title
            // 
            this.label_die_2_title.AutoSize = true;
            this.label_die_2_title.BackColor = System.Drawing.Color.Transparent;
            this.label_die_2_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_die_2_title.Location = new System.Drawing.Point(359, 1);
            this.label_die_2_title.Name = "label_die_2_title";
            this.label_die_2_title.Size = new System.Drawing.Size(86, 32);
            this.label_die_2_title.TabIndex = 65;
            this.label_die_2_title.Text = "Die 2";
            // 
            // DieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(946, 579);
            this.Controls.Add(this.label_die_2_title);
            this.Controls.Add(this.label_die_1_title);
            this.Controls.Add(this.label_die_sum_mean);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_die_sum_min);
            this.Controls.Add(this.pictureBox_die_sum_min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_die_sum_max);
            this.Controls.Add(this.pictureBox_die_sum_max);
            this.Controls.Add(this.label_mean_d2);
            this.Controls.Add(this.label_die2_min);
            this.Controls.Add(this.label_die2_max);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox_die_2_min);
            this.Controls.Add(this.pictureBox_die_2_max);
            this.Controls.Add(this.label_die1_min);
            this.Controls.Add(this.pictureBox_die_1_min);
            this.Controls.Add(this.label_die1_max);
            this.Controls.Add(this.pictureBox_die_1_max);
            this.Controls.Add(this.button_sum_of_2_dice);
            this.Controls.Add(this.label_mean_d1);
            this.Controls.Add(this.textSeedInput_d1);
            this.Controls.Add(this.listBox_Stats);
            this.Controls.Add(this.labelSeed_d1);
            this.Controls.Add(this.buttonSetSeed_d1);
            this.Controls.Add(this.label_InputSeed_d1);
            this.Controls.Add(this.chartHistogram);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.buttonRoll);
            this.Name = "DieForm";
            this.Text = "Roll!";
            this.Load += new System.EventHandler(this.DieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.die2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_1_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_1_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_2_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_2_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_sum_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_die_sum_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.PictureBox die2;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.PictureBox die1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
        private System.Windows.Forms.Label label_InputSeed_d1;
        private System.Windows.Forms.Button buttonSetSeed_d1;
        private System.Windows.Forms.Label labelSeed_d1;
        private System.Windows.Forms.ListBox listBox_Stats;
        private System.Windows.Forms.TextBox textSeedInput_d1;
        private System.Windows.Forms.Label label_mean_d1;
        private System.Windows.Forms.Button button_sum_of_2_dice;
        private System.Windows.Forms.PictureBox pictureBox_die_1_max;
        private System.Windows.Forms.Label label_die1_max;
        private System.Windows.Forms.Label label_die1_min;
        private System.Windows.Forms.PictureBox pictureBox_die_1_min;
        private System.Windows.Forms.PictureBox pictureBox_die_2_min;
        private System.Windows.Forms.PictureBox pictureBox_die_2_max;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_die2_min;
        private System.Windows.Forms.Label label_die2_max;
        private System.Windows.Forms.Label label_mean_d2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_die_sum_max;
        private System.Windows.Forms.PictureBox pictureBox_die_sum_max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_die_sum_min;
        private System.Windows.Forms.PictureBox pictureBox_die_sum_min;
        private System.Windows.Forms.Label label_die_sum_mean;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_die_1_title;
        private System.Windows.Forms.Label label_die_2_title;
    }
}

