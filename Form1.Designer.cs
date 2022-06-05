namespace ClassesImportantes
{
  partial class Form1
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
      this.btnAleatorio = new System.Windows.Forms.Button();
      this.lblResultado = new System.Windows.Forms.Label();
      this.aleatorio = new System.Windows.Forms.Button();
      this.btnTimeSpan = new System.Windows.Forms.Button();
      this.btnDateTime = new System.Windows.Forms.Button();
      this.btnColor = new System.Windows.Forms.Button();
      this.btnFont = new System.Windows.Forms.Button();
      this.btnEnvironment = new System.Windows.Forms.Button();
      this.btnApplication = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnAleatorio
      // 
      this.btnAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAleatorio.Location = new System.Drawing.Point(24, 292);
      this.btnAleatorio.Name = "btnAleatorio";
      this.btnAleatorio.Size = new System.Drawing.Size(168, 71);
      this.btnAleatorio.TabIndex = 0;
      this.btnAleatorio.Text = "MessageBox";
      this.btnAleatorio.UseVisualStyleBackColor = true;
      this.btnAleatorio.Click += new System.EventHandler(this.btnMessageBox_Click);
      // 
      // lblResultado
      // 
      this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResultado.Location = new System.Drawing.Point(13, 13);
      this.lblResultado.Name = "lblResultado";
      this.lblResultado.Size = new System.Drawing.Size(764, 105);
      this.lblResultado.TabIndex = 1;
      this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // aleatorio
      // 
      this.aleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.aleatorio.Location = new System.Drawing.Point(210, 292);
      this.aleatorio.Name = "aleatorio";
      this.aleatorio.Size = new System.Drawing.Size(168, 71);
      this.aleatorio.TabIndex = 2;
      this.aleatorio.Text = "Aleatório";
      this.aleatorio.UseVisualStyleBackColor = true;
      this.aleatorio.Click += new System.EventHandler(this.aleatorio_Click);
      // 
      // btnTimeSpan
      // 
      this.btnTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTimeSpan.Location = new System.Drawing.Point(397, 292);
      this.btnTimeSpan.Name = "btnTimeSpan";
      this.btnTimeSpan.Size = new System.Drawing.Size(168, 71);
      this.btnTimeSpan.TabIndex = 3;
      this.btnTimeSpan.Text = "TimeSpam";
      this.btnTimeSpan.UseVisualStyleBackColor = true;
      this.btnTimeSpan.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnDateTime
      // 
      this.btnDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDateTime.Location = new System.Drawing.Point(586, 292);
      this.btnDateTime.Name = "btnDateTime";
      this.btnDateTime.Size = new System.Drawing.Size(168, 71);
      this.btnDateTime.TabIndex = 4;
      this.btnDateTime.Text = "DateTime";
      this.btnDateTime.UseVisualStyleBackColor = true;
      this.btnDateTime.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // btnColor
      // 
      this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnColor.Location = new System.Drawing.Point(24, 380);
      this.btnColor.Name = "btnColor";
      this.btnColor.Size = new System.Drawing.Size(168, 71);
      this.btnColor.TabIndex = 5;
      this.btnColor.Text = "Color";
      this.btnColor.UseVisualStyleBackColor = true;
      this.btnColor.Click += new System.EventHandler(this.btnName_Click);
      // 
      // btnFont
      // 
      this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFont.Location = new System.Drawing.Point(210, 380);
      this.btnFont.Name = "btnFont";
      this.btnFont.Size = new System.Drawing.Size(168, 71);
      this.btnFont.TabIndex = 6;
      this.btnFont.Text = "Font";
      this.btnFont.UseVisualStyleBackColor = true;
      this.btnFont.Click += new System.EventHandler(this.btnFont_Click);

      // 
      // btnEnvironment
      // 
      this.btnEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEnvironment.Location = new System.Drawing.Point(396, 380);
      this.btnEnvironment.Name = "btnEnvironment";
      this.btnEnvironment.Size = new System.Drawing.Size(168, 71);
      this.btnEnvironment.TabIndex = 7;
      this.btnEnvironment.Text = "Ambiente";
      this.btnEnvironment.UseVisualStyleBackColor = true;
      this.btnEnvironment.Click += new System.EventHandler(this.btnEnvironment_Click);

      
      // btnApplication
      
      this.btnApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnApplication.Location = new System.Drawing.Point(585, 380);
      this.btnApplication.Name = "btnApplication";
      this.btnApplication.Size = new System.Drawing.Size(168, 71);
      this.btnApplication.TabIndex = 8;
      this.btnApplication.Text = "Aplicação";
      this.btnApplication.UseVisualStyleBackColor = true;
      this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);

      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 463);
      this.Controls.Add(this.btnFont);
      this.Controls.Add(this.btnColor);
      this.Controls.Add(this.btnDateTime);
      this.Controls.Add(this.btnTimeSpan);
      this.Controls.Add(this.aleatorio);
      this.Controls.Add(this.lblResultado);
      this.Controls.Add(this.btnAleatorio);
      this.Controls.Add(this.btnEnvironment);
      this.Controls.Add(this.btnApplication);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAleatorio;
    private System.Windows.Forms.Label lblResultado;
    private System.Windows.Forms.Button aleatorio;
    private System.Windows.Forms.Button btnTimeSpan;
    private System.Windows.Forms.Button btnDateTime;
    private System.Windows.Forms.Button btnColor;
    private System.Windows.Forms.Button btnFont;
    private System.Windows.Forms.Button btnEnvironment;
    private System.Windows.Forms.Button btnApplication;
  }
}

