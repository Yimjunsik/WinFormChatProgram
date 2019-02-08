namespace Server
{
    partial class ServerForm
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
            this.labelAddress = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAddress.Location = new System.Drawing.Point(3, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(94, 33);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "서버 주소";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("굴림", 12F);
            this.textAddress.Location = new System.Drawing.Point(103, 3);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(246, 26);
            this.textAddress.TabIndex = 2;
            // 
            // labelPort
            // 
            this.labelPort.Font = new System.Drawing.Font("굴림", 12F);
            this.labelPort.Location = new System.Drawing.Point(355, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(94, 33);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "포트 번호";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPort
            // 
            this.textPort.Font = new System.Drawing.Font("굴림", 12F);
            this.textPort.Location = new System.Drawing.Point(455, 3);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(102, 26);
            this.textPort.TabIndex = 4;
            this.textPort.Text = "8080";
            this.textPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("굴림", 12F);
            this.buttonConnect.Location = new System.Drawing.Point(563, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(94, 29);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "시작";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("굴림", 12F);
            this.buttonDisconnect.Location = new System.Drawing.Point(663, 3);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(94, 29);
            this.buttonDisconnect.TabIndex = 10;
            this.buttonDisconnect.Text = "종료";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelAddress);
            this.Name = "ServerForm";
            this.Text = "Chatting by junsik - Server";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

