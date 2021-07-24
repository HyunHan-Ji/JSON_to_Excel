namespace DongGyu
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
            this.txtBox_open = new System.Windows.Forms.TextBox();
            this.txtBox_save = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.txtBox_filename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "변환파일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "저장위치";
            // 
            // txtBox_open
            // 
            this.txtBox_open.Location = new System.Drawing.Point(93, 32);
            this.txtBox_open.Name = "txtBox_open";
            this.txtBox_open.Size = new System.Drawing.Size(365, 21);
            this.txtBox_open.TabIndex = 2;
            // 
            // txtBox_save
            // 
            this.txtBox_save.Location = new System.Drawing.Point(93, 77);
            this.txtBox_save.Name = "txtBox_save";
            this.txtBox_save.Size = new System.Drawing.Size(365, 21);
            this.txtBox_save.TabIndex = 3;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(464, 30);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "찾아보기";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(464, 75);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "찾아보기";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(165, 161);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(211, 69);
            this.btn_run.TabIndex = 6;
            this.btn_run.Text = "실행";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // txtBox_filename
            // 
            this.txtBox_filename.Location = new System.Drawing.Point(93, 117);
            this.txtBox_filename.Name = "txtBox_filename";
            this.txtBox_filename.Size = new System.Drawing.Size(365, 21);
            this.txtBox_filename.TabIndex = 9;
            this.txtBox_filename.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "파일명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20F);
            this.label4.Location = new System.Drawing.Point(31, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 27);
            this.label4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_filename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.txtBox_save);
            this.Controls.Add(this.txtBox_open);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "JSON_To_Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_open;
        private System.Windows.Forms.TextBox txtBox_save;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox txtBox_filename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

