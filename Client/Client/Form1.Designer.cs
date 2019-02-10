namespace Client
{
    partial class ClientForm
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
            this.labelNickName = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelSend = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textNickName = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.textSend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.Font = new System.Drawing.Font("굴림", 12F);
            this.labelAddress.Location = new System.Drawing.Point(3, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(94, 33);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "서버 주소";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNickName
            // 
            this.labelNickName.Font = new System.Drawing.Font("굴림", 12F);
            this.labelNickName.Location = new System.Drawing.Point(3, 35);
            this.labelNickName.Name = "labelNickName";
            this.labelNickName.Size = new System.Drawing.Size(94, 33);
            this.labelNickName.TabIndex = 10;
            this.labelNickName.Text = "닉네임";
            this.labelNickName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // labelSend
            // 
            this.labelSend.Font = new System.Drawing.Font("굴림", 12F);
            this.labelSend.Location = new System.Drawing.Point(3, 382);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(94, 35);
            this.labelSend.TabIndex = 6;
            this.labelSend.Text = "입 력";
            this.labelSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("굴림", 12F);
            this.textAddress.Location = new System.Drawing.Point(103, 3);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(246, 26);
            this.textAddress.TabIndex = 3;
            // 
            // textNickName
            // 
            this.textNickName.Font = new System.Drawing.Font("굴림", 12F);
            this.textNickName.Location = new System.Drawing.Point(103, 38);
            this.textNickName.Name = "textNickName";
            this.textNickName.Size = new System.Drawing.Size(246, 26);
            this.textNickName.TabIndex = 11;
            // 
            // textPort
            // 
            this.textPort.Font = new System.Drawing.Font("굴림", 12F);
            this.textPort.Location = new System.Drawing.Point(355, 38);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(94, 26);
            this.textPort.TabIndex = 4;
            this.textPort.Text = "8080";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(3, 73);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.ReadOnly = true;
            this.textStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textStatus.Size = new System.Drawing.Size(554, 306);
            this.textStatus.TabIndex = 9;
            // 
            // textSend
            // 
            this.textSend.Font = new System.Drawing.Font("굴림", 12F);
            this.textSend.Location = new System.Drawing.Point(103, 385);
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(346, 26);
            this.textSend.TabIndex = 7;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.textSend);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textNickName);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelSend);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelNickName);
            this.Controls.Add(this.labelAddress);
            this.Name = "ClientForm";
            this.Text = "Chatting by junsik - Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelNickName;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelSend;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textNickName;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.TextBox textSend;
    }
}

