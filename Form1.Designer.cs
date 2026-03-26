namespace SimpleCalculator
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
            simplecl = new Label();
            story1 = new TextBox();
            story2 = new TextBox();
            btCE = new Button();
            btdel = new Button();
            btC = new Button();
            btdv = new Button();
            btt = new Button();
            bt8 = new Button();
            bt9 = new Button();
            bt7 = new Button();
            btn = new Button();
            bt5 = new Button();
            bt6 = new Button();
            bt4 = new Button();
            btp = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt1 = new Button();
            btr = new Button();
            bt0 = new Button();
            btd = new Button();
            btnp = new Button();
            SuspendLayout();
            // 
            // simplecl
            // 
            simplecl.AutoSize = true;
            simplecl.Font = new Font("한컴 말랑말랑 Bold", 28F, FontStyle.Bold, GraphicsUnit.Point, 129);
            simplecl.ForeColor = SystemColors.MenuHighlight;
            simplecl.Location = new Point(87, 46);
            simplecl.Name = "simplecl";
            simplecl.Size = new Size(495, 72);
            simplecl.TabIndex = 0;
            simplecl.Text = "Simple Calculator";
            // 
            // story1
            // 
            story1.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            story1.Location = new Point(87, 134);
            story1.Name = "story1";
            story1.Size = new Size(495, 50);
            story1.TabIndex = 1;
            // 
            // story2
            // 
            story2.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            story2.Location = new Point(87, 202);
            story2.Name = "story2";
            story2.Size = new Size(495, 50);
            story2.TabIndex = 2;
            // 
            // btCE
            // 
            btCE.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btCE.Location = new Point(87, 282);
            btCE.Name = "btCE";
            btCE.Size = new Size(106, 64);
            btCE.TabIndex = 3;
            btCE.Text = "CE";
            btCE.UseVisualStyleBackColor = true;
            btCE.Click += btCE_Click;
            // 
            // btdel
            // 
            btdel.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btdel.Location = new Point(342, 282);
            btdel.Name = "btdel";
            btdel.Size = new Size(106, 64);
            btdel.TabIndex = 4;
            btdel.Text = "del";
            btdel.UseVisualStyleBackColor = true;
            btdel.Click += btdel_Click;
            // 
            // btC
            // 
            btC.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btC.Location = new Point(216, 282);
            btC.Name = "btC";
            btC.Size = new Size(106, 64);
            btC.TabIndex = 5;
            btC.Text = "C";
            btC.UseVisualStyleBackColor = true;
            btC.Click += btC_Click;
            // 
            // btdv
            // 
            btdv.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btdv.ForeColor = Color.Red;
            btdv.Location = new Point(476, 282);
            btdv.Name = "btdv";
            btdv.Size = new Size(106, 64);
            btdv.TabIndex = 6;
            btdv.Text = "÷";
            btdv.UseVisualStyleBackColor = true;
            btdv.Click += btdv_Click;
            // 
            // btt
            // 
            btt.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btt.ForeColor = Color.Red;
            btt.Location = new Point(476, 363);
            btt.Name = "btt";
            btt.Size = new Size(106, 64);
            btt.TabIndex = 10;
            btt.Text = "×";
            btt.UseVisualStyleBackColor = true;
            btt.Click += btt_Click;
            // 
            // bt8
            // 
            bt8.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt8.ForeColor = SystemColors.Highlight;
            bt8.Location = new Point(216, 363);
            bt8.Name = "bt8";
            bt8.Size = new Size(106, 64);
            bt8.TabIndex = 9;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += bt8_Click;
            // 
            // bt9
            // 
            bt9.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt9.ForeColor = SystemColors.Highlight;
            bt9.Location = new Point(342, 363);
            bt9.Name = "bt9";
            bt9.Size = new Size(106, 64);
            bt9.TabIndex = 8;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += bt9_Click;
            // 
            // bt7
            // 
            bt7.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt7.ForeColor = SystemColors.Highlight;
            bt7.Location = new Point(87, 363);
            bt7.Name = "bt7";
            bt7.Size = new Size(106, 64);
            bt7.TabIndex = 7;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += bt7_Click;
            // 
            // btn
            // 
            btn.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn.ForeColor = Color.Red;
            btn.Location = new Point(476, 445);
            btn.Name = "btn";
            btn.Size = new Size(106, 64);
            btn.TabIndex = 14;
            btn.Text = "-";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // bt5
            // 
            bt5.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt5.ForeColor = SystemColors.Highlight;
            bt5.Location = new Point(216, 445);
            bt5.Name = "bt5";
            bt5.Size = new Size(106, 64);
            bt5.TabIndex = 13;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // bt6
            // 
            bt6.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt6.ForeColor = SystemColors.Highlight;
            bt6.Location = new Point(342, 445);
            bt6.Name = "bt6";
            bt6.Size = new Size(106, 64);
            bt6.TabIndex = 12;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += bt6_Click;
            // 
            // bt4
            // 
            bt4.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt4.ForeColor = SystemColors.Highlight;
            bt4.Location = new Point(87, 445);
            bt4.Name = "bt4";
            bt4.Size = new Size(106, 64);
            bt4.TabIndex = 11;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // btp
            // 
            btp.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btp.ForeColor = Color.Red;
            btp.Location = new Point(476, 526);
            btp.Name = "btp";
            btp.Size = new Size(106, 64);
            btp.TabIndex = 18;
            btp.Text = "+";
            btp.UseVisualStyleBackColor = true;
            btp.Click += btp_Click;
            // 
            // bt2
            // 
            bt2.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt2.ForeColor = SystemColors.Highlight;
            bt2.Location = new Point(216, 526);
            bt2.Name = "bt2";
            bt2.Size = new Size(106, 64);
            bt2.TabIndex = 17;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt3.ForeColor = SystemColors.Highlight;
            bt3.Location = new Point(342, 526);
            bt3.Name = "bt3";
            bt3.Size = new Size(106, 64);
            bt3.TabIndex = 16;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt1
            // 
            bt1.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt1.ForeColor = SystemColors.Highlight;
            bt1.Location = new Point(87, 526);
            bt1.Name = "bt1";
            bt1.Size = new Size(106, 64);
            bt1.TabIndex = 15;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // btr
            // 
            btr.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btr.Location = new Point(476, 606);
            btr.Name = "btr";
            btr.Size = new Size(106, 64);
            btr.TabIndex = 22;
            btr.Text = "=";
            btr.UseVisualStyleBackColor = true;
            btr.Click += btr_Click;
            // 
            // bt0
            // 
            bt0.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bt0.ForeColor = SystemColors.Highlight;
            bt0.Location = new Point(216, 606);
            bt0.Name = "bt0";
            bt0.Size = new Size(106, 64);
            bt0.TabIndex = 21;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // btd
            // 
            btd.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btd.Location = new Point(342, 606);
            btd.Name = "btd";
            btd.Size = new Size(106, 64);
            btd.TabIndex = 20;
            btd.Text = ".";
            btd.UseVisualStyleBackColor = true;
            // 
            // btnp
            // 
            btnp.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnp.Location = new Point(87, 606);
            btnp.Name = "btnp";
            btnp.Size = new Size(106, 64);
            btnp.TabIndex = 19;
            btnp.Text = "+/-";
            btnp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 695);
            Controls.Add(btr);
            Controls.Add(bt0);
            Controls.Add(btd);
            Controls.Add(btnp);
            Controls.Add(btp);
            Controls.Add(bt2);
            Controls.Add(bt3);
            Controls.Add(bt1);
            Controls.Add(btn);
            Controls.Add(bt5);
            Controls.Add(bt6);
            Controls.Add(bt4);
            Controls.Add(btt);
            Controls.Add(bt8);
            Controls.Add(bt9);
            Controls.Add(bt7);
            Controls.Add(btdv);
            Controls.Add(btC);
            Controls.Add(btdel);
            Controls.Add(btCE);
            Controls.Add(story2);
            Controls.Add(story1);
            Controls.Add(simplecl);
            Name = "Form1";
            Text = "Caculator v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label simplecl;
        private TextBox story1;
        private TextBox story2;
        private Button btCE;
        private Button btdel;
        private Button btC;
        private Button btdv;
        private Button btt;
        private Button bt8;
        private Button bt9;
        private Button bt7;
        private Button btn;
        private Button bt5;
        private Button bt6;
        private Button bt4;
        private Button btp;
        private Button bt2;
        private Button bt3;
        private Button bt1;
        private Button btr;
        private Button bt0;
        private Button btd;
        private Button btnp;
    }
}
