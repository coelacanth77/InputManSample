namespace InputManSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder11 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder12 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder13 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder14 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder15 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder16 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder17 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder18 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder19 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder20 = new GrapeCity.Win.Editors.CharBoxBorder();
            this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            this.gcMask1 = new GrapeCity.Win.Editors.GcMask(this.components);
            this.gcCharMask1 = new GrapeCity.Win.Editors.GcCharMask(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcTextBox2 = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcShortcut2 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcMask1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCharMask1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMask1
            // 
            this.gcMask1.Location = new System.Drawing.Point(90, 90);
            this.gcMask1.Name = "gcMask1";
            this.gcShortcut1.SetShortcuts(this.gcMask1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcMask1)),
                ((object)(this.gcMask1))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
            this.gcMask1.Size = new System.Drawing.Size(120, 20);
            this.gcMask1.TabIndex = 1;
            // 
            // gcCharMask1
            // 
            this.gcCharMask1.CharBoxes.AddRange(new GrapeCity.Win.Editors.CharBox[] {
            new GrapeCity.Win.Editors.LiteralBox(true, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder11, null, System.Drawing.ContentAlignment.MiddleCenter, "〒"),
            new GrapeCity.Win.Editors.InputBox(true, new System.Drawing.Size(28, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder12, null, System.Drawing.ContentAlignment.MiddleCenter),
            new GrapeCity.Win.Editors.InputBox(true, new System.Drawing.Size(28, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder13, null, System.Drawing.ContentAlignment.MiddleCenter),
            new GrapeCity.Win.Editors.InputBox(true, new System.Drawing.Size(28, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder14, null, System.Drawing.ContentAlignment.MiddleCenter),
            new GrapeCity.Win.Editors.InputBox(true, new System.Drawing.Size(28, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder15, null, System.Drawing.ContentAlignment.MiddleCenter),
            new GrapeCity.Win.Editors.SeparatorBox(true, new System.Drawing.Size(10, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder16, null, System.Drawing.ContentAlignment.MiddleCenter, GrapeCity.Win.Editors.SeparatorBox.SeparatorShape.Rectangle, new System.Drawing.Size(6, 3)),
            new GrapeCity.Win.Editors.InputBox(true, new System.Drawing.Size(28, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder17, null, System.Drawing.ContentAlignment.MiddleCenter),
            new GrapeCity.Win.Editors.InputBox(true, new System.Drawing.Size(28, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder18, null, System.Drawing.ContentAlignment.MiddleCenter),
            new GrapeCity.Win.Editors.InputBox(true, new System.Drawing.Size(28, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder19, null, System.Drawing.ContentAlignment.MiddleCenter),
            new GrapeCity.Win.Editors.InputBox(true, new System.Drawing.Size(28, 16), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder20, null, System.Drawing.ContentAlignment.MiddleCenter)});
            this.gcCharMask1.Location = new System.Drawing.Point(90, 150);
            this.gcCharMask1.Name = "gcCharMask1";
            this.gcShortcut1.SetShortcuts(this.gcCharMask1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcCharMask1)),
                ((object)(this.gcCharMask1))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
            this.gcCharMask1.Size = new System.Drawing.Size(256, 30);
            this.gcCharMask1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "標準TextBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "GcMask";
            // 
            // gcTextBox2
            // 
            this.gcTextBox2.Format = "ＺA";
            this.gcTextBox2.Location = new System.Drawing.Point(80, 25);
            this.gcTextBox2.Name = "gcTextBox2";
            this.gcTextBox2.PasswordRevelationMode = GrapeCity.Win.Editors.PasswordRevelationMode.ShowEyeButton;
            this.gcTextBox2.Size = new System.Drawing.Size(171, 25);
            this.gcTextBox2.TabIndex = 0;
            this.gcTextBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "テキストボックスを入力状態にして「Ctr+Shift+A」キーを押してください";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数字を入力してください";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gcCharMask1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcMask1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gcMask1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCharMask1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
        private GrapeCity.Win.Editors.GcMask gcMask1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GrapeCity.Win.Editors.GcCharMask gcCharMask1;
        private GrapeCity.Win.Editors.GcTextBox gcTextBox2;
        private GrapeCity.Win.Editors.GcShortcut gcShortcut2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

