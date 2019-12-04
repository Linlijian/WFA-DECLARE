namespace WFA_DECLARE
{
    partial class Main
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
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_toCur = new System.Windows.Forms.TextBox();
            this.txt_toVal = new System.Windows.Forms.TextBox();
            this.btnConcat = new System.Windows.Forms.Button();
            this.btncopycursor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(12, 12);
            this.txt_from.Multiline = true;
            this.txt_from.Name = "txt_from";
            this.txt_from.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_from.Size = new System.Drawing.Size(265, 210);
            this.txt_from.TabIndex = 2;
            // 
            // txt_toCur
            // 
            this.txt_toCur.Location = new System.Drawing.Point(283, 12);
            this.txt_toCur.Multiline = true;
            this.txt_toCur.Name = "txt_toCur";
            this.txt_toCur.Size = new System.Drawing.Size(265, 210);
            this.txt_toCur.TabIndex = 2;
            // 
            // txt_toVal
            // 
            this.txt_toVal.Location = new System.Drawing.Point(554, 12);
            this.txt_toVal.Multiline = true;
            this.txt_toVal.Name = "txt_toVal";
            this.txt_toVal.Size = new System.Drawing.Size(265, 210);
            this.txt_toVal.TabIndex = 2;
            // 
            // btnConcat
            // 
            this.btnConcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcat.Location = new System.Drawing.Point(12, 228);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(265, 58);
            this.btnConcat.TabIndex = 3;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // btncopycursor
            // 
            this.btncopycursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncopycursor.Location = new System.Drawing.Point(284, 228);
            this.btncopycursor.Name = "btncopycursor";
            this.btncopycursor.Size = new System.Drawing.Size(264, 58);
            this.btncopycursor.TabIndex = 4;
            this.btncopycursor.Text = "Conpy Cursor";
            this.btncopycursor.UseVisualStyleBackColor = true;
            this.btncopycursor.Click += new System.EventHandler(this.btncopycursor_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(554, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Copy Value";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Meiio";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btncopycursor);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.txt_toVal);
            this.Controls.Add(this.txt_toCur);
            this.Controls.Add(this.txt_from);
            this.Name = "Main";
            this.Text = "WFA-DECLARE";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_toCur;
        private System.Windows.Forms.TextBox txt_toVal;
        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.Button btncopycursor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

