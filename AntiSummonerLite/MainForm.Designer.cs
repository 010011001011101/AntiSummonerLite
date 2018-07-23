namespace AntiSummonerLite
{
  partial class MainForm
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.DC = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.CL = new System.Windows.Forms.NumericUpDown();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
      this.Label7 = new System.Windows.Forms.Label();
      this.Save = new System.Windows.Forms.NumericUpDown();
      this.Evasion = new System.Windows.Forms.CheckBox();
      this.ImprovedEvasion = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SR = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.Resist = new System.Windows.Forms.NumericUpDown();
      this.Count = new System.Windows.Forms.NumericUpDown();
      this.CalcBtn = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.Attacks = new System.Windows.Forms.TextBox();
      this.OutputText = new System.Windows.Forms.RichTextBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.flowLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DC)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.CL)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.flowLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Save)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SR)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Resist)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.groupBox2, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.Attacks, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.OutputText, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.CalcBtn, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.Count, 2, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 412);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
      this.groupBox1.Controls.Add(this.flowLayoutPanel2);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(164, 47);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Attacker Stats";
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.label1);
      this.flowLayoutPanel2.Controls.Add(this.DC);
      this.flowLayoutPanel2.Controls.Add(this.label2);
      this.flowLayoutPanel2.Controls.Add(this.CL);
      this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Size = new System.Drawing.Size(158, 28);
      this.flowLayoutPanel2.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(22, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "DC";
      // 
      // DC
      // 
      this.DC.Location = new System.Drawing.Point(31, 3);
      this.DC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.DC.Name = "DC";
      this.DC.Size = new System.Drawing.Size(40, 20);
      this.DC.TabIndex = 1;
      this.DC.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(77, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(20, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "CL";
      // 
      // CL
      // 
      this.CL.Location = new System.Drawing.Point(103, 3);
      this.CL.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.CL.Name = "CL";
      this.CL.Size = new System.Drawing.Size(40, 20);
      this.CL.TabIndex = 3;
      this.CL.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.flowLayoutPanel3);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBox2.Location = new System.Drawing.Point(173, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(456, 47);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Defender Stats";
      // 
      // flowLayoutPanel3
      // 
      this.flowLayoutPanel3.Controls.Add(this.Label7);
      this.flowLayoutPanel3.Controls.Add(this.Save);
      this.flowLayoutPanel3.Controls.Add(this.Evasion);
      this.flowLayoutPanel3.Controls.Add(this.ImprovedEvasion);
      this.flowLayoutPanel3.Controls.Add(this.label4);
      this.flowLayoutPanel3.Controls.Add(this.SR);
      this.flowLayoutPanel3.Controls.Add(this.label3);
      this.flowLayoutPanel3.Controls.Add(this.Resist);
      this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
      this.flowLayoutPanel3.Name = "flowLayoutPanel3";
      this.flowLayoutPanel3.Size = new System.Drawing.Size(450, 28);
      this.flowLayoutPanel3.TabIndex = 0;
      // 
      // Label7
      // 
      this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.Label7.AutoSize = true;
      this.Label7.Location = new System.Drawing.Point(3, 6);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(32, 13);
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Save";
      // 
      // Save
      // 
      this.Save.Location = new System.Drawing.Point(41, 3);
      this.Save.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.Save.Name = "Save";
      this.Save.Size = new System.Drawing.Size(40, 20);
      this.Save.TabIndex = 1;
      this.Save.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // Evasion
      // 
      this.Evasion.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.Evasion.AutoSize = true;
      this.Evasion.Location = new System.Drawing.Point(87, 4);
      this.Evasion.Name = "Evasion";
      this.Evasion.Size = new System.Drawing.Size(64, 17);
      this.Evasion.TabIndex = 2;
      this.Evasion.Text = "Evasion";
      this.Evasion.UseVisualStyleBackColor = true;
      // 
      // ImprovedEvasion
      // 
      this.ImprovedEvasion.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ImprovedEvasion.AutoSize = true;
      this.ImprovedEvasion.Location = new System.Drawing.Point(157, 4);
      this.ImprovedEvasion.Name = "ImprovedEvasion";
      this.ImprovedEvasion.Size = new System.Drawing.Size(111, 17);
      this.ImprovedEvasion.TabIndex = 3;
      this.ImprovedEvasion.Text = "Improved Evasion";
      this.ImprovedEvasion.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(274, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(22, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "SR";
      // 
      // SR
      // 
      this.SR.Location = new System.Drawing.Point(302, 3);
      this.SR.Name = "SR";
      this.SR.Size = new System.Drawing.Size(40, 20);
      this.SR.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(348, 6);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(36, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Resist";
      // 
      // Resist
      // 
      this.Resist.Location = new System.Drawing.Point(390, 3);
      this.Resist.Name = "Resist";
      this.Resist.Size = new System.Drawing.Size(40, 20);
      this.Resist.TabIndex = 7;
      // 
      // Count
      // 
      this.Count.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.Count.Location = new System.Drawing.Point(103, 83);
      this.Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.Count.Name = "Count";
      this.Count.Size = new System.Drawing.Size(40, 20);
      this.Count.TabIndex = 6;
      this.Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // CalcBtn
      // 
      this.CalcBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.CalcBtn.Location = new System.Drawing.Point(4, 82);
      this.CalcBtn.Name = "CalcBtn";
      this.CalcBtn.Size = new System.Drawing.Size(75, 23);
      this.CalcBtn.TabIndex = 4;
      this.CalcBtn.Text = "Calculate";
      this.CalcBtn.UseVisualStyleBackColor = true;
      this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(85, 87);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(12, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "X";
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(36, 59);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(43, 13);
      this.label6.TabIndex = 2;
      this.label6.Text = "Attacks";
      // 
      // Attacks
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.Attacks, 3);
      this.Attacks.Dock = System.Windows.Forms.DockStyle.Top;
      this.Attacks.Location = new System.Drawing.Point(85, 56);
      this.Attacks.Name = "Attacks";
      this.Attacks.Size = new System.Drawing.Size(546, 20);
      this.Attacks.TabIndex = 3;
      // 
      // OutputText
      // 
      this.OutputText.BackColor = System.Drawing.SystemColors.Window;
      this.tableLayoutPanel1.SetColumnSpan(this.OutputText, 4);
      this.OutputText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OutputText.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OutputText.Location = new System.Drawing.Point(3, 111);
      this.OutputText.Name = "OutputText";
      this.OutputText.ReadOnly = true;
      this.OutputText.Size = new System.Drawing.Size(628, 298);
      this.OutputText.TabIndex = 7;
      this.OutputText.Text = "";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(634, 412);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(650, 100);
      this.Name = "MainForm";
      this.ShowIcon = false;
      this.Text = "Anti Summoner (Lite)";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.flowLayoutPanel2.ResumeLayout(false);
      this.flowLayoutPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DC)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.CL)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.flowLayoutPanel3.ResumeLayout(false);
      this.flowLayoutPanel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Save)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SR)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Resist)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown DC;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown CL;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    private System.Windows.Forms.Label Label7;
    private System.Windows.Forms.NumericUpDown Save;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown SR;
    private System.Windows.Forms.Button CalcBtn;
    private System.Windows.Forms.TextBox Attacks;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown Count;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox Evasion;
    private System.Windows.Forms.CheckBox ImprovedEvasion;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown Resist;
    private System.Windows.Forms.RichTextBox OutputText;
  }
}

