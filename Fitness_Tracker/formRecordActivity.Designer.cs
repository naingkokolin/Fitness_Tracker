namespace Fitness_Tracker
{
    partial class formRecordActivity
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
            lblCaloryBurned = new Label();
            tbCaloryBurn = new TextBox();
            label1 = new Label();
            lbMetric1 = new Label();
            lbMetric2 = new Label();
            lbMetric3 = new Label();
            tbMetric1 = new TextBox();
            tbMetric2 = new TextBox();
            tbMetric3 = new TextBox();
            btnChooseActiviy = new Button();
            btnCalculateCalory = new Button();
            comboBoxActivities = new ComboBox();
            SuspendLayout();
            // 
            // lblCaloryBurned
            // 
            lblCaloryBurned.AutoSize = true;
            lblCaloryBurned.Location = new Point(41, 38);
            lblCaloryBurned.Name = "lblCaloryBurned";
            lblCaloryBurned.Size = new Size(164, 18);
            lblCaloryBurned.TabIndex = 0;
            lblCaloryBurned.Text = "Target Calory you want to burn:";
            // 
            // tbCaloryBurn
            // 
            tbCaloryBurn.Location = new Point(235, 38);
            tbCaloryBurn.Name = "tbCaloryBurn";
            tbCaloryBurn.Size = new Size(100, 25);
            tbCaloryBurn.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 134);
            label1.Name = "label1";
            label1.Size = new Size(83, 18);
            label1.TabIndex = 2;
            label1.Text = "Choose Activity";
            // 
            // lbMetric1
            // 
            lbMetric1.AutoSize = true;
            lbMetric1.Location = new Point(41, 236);
            lbMetric1.Name = "lbMetric1";
            lbMetric1.Size = new Size(46, 18);
            lbMetric1.TabIndex = 3;
            lbMetric1.Text = "Metric 1";
            // 
            // lbMetric2
            // 
            lbMetric2.AutoSize = true;
            lbMetric2.Location = new Point(41, 282);
            lbMetric2.Name = "lbMetric2";
            lbMetric2.Size = new Size(46, 18);
            lbMetric2.TabIndex = 4;
            lbMetric2.Text = "Metric 2";
            // 
            // lbMetric3
            // 
            lbMetric3.AutoSize = true;
            lbMetric3.Location = new Point(41, 332);
            lbMetric3.Name = "lbMetric3";
            lbMetric3.Size = new Size(46, 18);
            lbMetric3.TabIndex = 6;
            lbMetric3.Text = "Metric 3";
            // 
            // tbMetric1
            // 
            tbMetric1.Location = new Point(235, 233);
            tbMetric1.Name = "tbMetric1";
            tbMetric1.Size = new Size(100, 25);
            tbMetric1.TabIndex = 8;
            // 
            // tbMetric2
            // 
            tbMetric2.Location = new Point(235, 282);
            tbMetric2.Name = "tbMetric2";
            tbMetric2.Size = new Size(100, 25);
            tbMetric2.TabIndex = 9;
            // 
            // tbMetric3
            // 
            tbMetric3.Location = new Point(235, 332);
            tbMetric3.Name = "tbMetric3";
            tbMetric3.Size = new Size(100, 25);
            tbMetric3.TabIndex = 10;
            // 
            // btnChooseActiviy
            // 
            btnChooseActiviy.Location = new Point(235, 185);
            btnChooseActiviy.Name = "btnChooseActiviy";
            btnChooseActiviy.Size = new Size(100, 23);
            btnChooseActiviy.TabIndex = 11;
            btnChooseActiviy.Text = "Choose Activity";
            btnChooseActiviy.UseVisualStyleBackColor = true;
            btnChooseActiviy.Click += btnChooseActiviy_Click;
            // 
            // btnCalculateCalory
            // 
            btnCalculateCalory.Location = new Point(235, 384);
            btnCalculateCalory.Name = "btnCalculateCalory";
            btnCalculateCalory.Size = new Size(100, 23);
            btnCalculateCalory.TabIndex = 12;
            btnCalculateCalory.Text = "Calculate Calory";
            btnCalculateCalory.UseVisualStyleBackColor = true;
            // 
            // comboBoxActivities
            // 
            comboBoxActivities.FormattingEnabled = true;
            comboBoxActivities.Items.AddRange(new object[] { "Walking", "Swimming", "Running", "Cycling", "Yoga", "Strength training" });
            comboBoxActivities.Location = new Point(235, 134);
            comboBoxActivities.Name = "comboBoxActivities";
            comboBoxActivities.Size = new Size(121, 26);
            comboBoxActivities.TabIndex = 13;
            // 
            // formRecordActivity
            // 
            AutoScaleDimensions = new SizeF(6F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxActivities);
            Controls.Add(btnCalculateCalory);
            Controls.Add(btnChooseActiviy);
            Controls.Add(tbMetric3);
            Controls.Add(tbMetric2);
            Controls.Add(tbMetric1);
            Controls.Add(lbMetric3);
            Controls.Add(lbMetric2);
            Controls.Add(lbMetric1);
            Controls.Add(label1);
            Controls.Add(tbCaloryBurn);
            Controls.Add(lblCaloryBurned);
            Name = "formRecordActivity";
            Text = "formRecordActivity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCaloryBurned;
        private TextBox tbCaloryBurn;
        private Label label1;
        private Label lbMetric1;
        private Label lbMetric2;
        private Label lbMetric3;
        private TextBox tbMetric1;
        private TextBox tbMetric2;
        private TextBox tbMetric3;
        private Button btnChooseActiviy;
        private Button btnCalculateCalory;
        private ComboBox comboBoxActivities;
    }
}