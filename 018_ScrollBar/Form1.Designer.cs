namespace _018_ScrollBar
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scrR = new System.Windows.Forms.HScrollBar();
            this.scrG = new System.Windows.Forms.HScrollBar();
            this.scrB = new System.Windows.Forms.HScrollBar();
            this.tbR = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(93, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 204);
            this.panel1.TabIndex = 3;
            // 
            // scrR
            // 
            this.scrR.Location = new System.Drawing.Point(168, 295);
            this.scrR.Name = "scrR";
            this.scrR.Size = new System.Drawing.Size(335, 26);
            this.scrR.TabIndex = 4;
            this.scrR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // scrG
            // 
            this.scrG.Location = new System.Drawing.Point(168, 331);
            this.scrG.Name = "scrG";
            this.scrG.Size = new System.Drawing.Size(335, 26);
            this.scrG.TabIndex = 5;
            this.scrG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // scrB
            // 
            this.scrB.Location = new System.Drawing.Point(168, 369);
            this.scrB.Name = "scrB";
            this.scrB.Size = new System.Drawing.Size(335, 26);
            this.scrB.TabIndex = 6;
            this.scrB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(527, 300);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(110, 28);
            this.tbR.TabIndex = 7;
            this.tbR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbR.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(527, 336);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(110, 28);
            this.tbG.TabIndex = 8;
            this.tbG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbG.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(527, 374);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(110, 28);
            this.tbB.TabIndex = 9;
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbB.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.scrB);
            this.Controls.Add(this.scrG);
            this.Controls.Add(this.scrR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RGB ScrollBar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar scrR;
        private System.Windows.Forms.HScrollBar scrG;
        private System.Windows.Forms.HScrollBar scrB;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbB;
    }
}

