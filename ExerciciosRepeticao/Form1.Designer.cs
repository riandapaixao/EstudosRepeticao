
namespace ExerciciosRepeticao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInicio = new System.Windows.Forms.TextBox();
            this.textBoxFim = new System.Windows.Forms.TextBox();
            this.buttonFor = new System.Windows.Forms.Button();
            this.buttonWhile = new System.Windows.Forms.Button();
            this.buttonDoWhile = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercicio de Repetição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fim";
            // 
            // textBoxInicio
            // 
            this.textBoxInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInicio.Location = new System.Drawing.Point(98, 71);
            this.textBoxInicio.Name = "textBoxInicio";
            this.textBoxInicio.Size = new System.Drawing.Size(126, 29);
            this.textBoxInicio.TabIndex = 3;
            // 
            // textBoxFim
            // 
            this.textBoxFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFim.Location = new System.Drawing.Point(98, 124);
            this.textBoxFim.Name = "textBoxFim";
            this.textBoxFim.Size = new System.Drawing.Size(126, 29);
            this.textBoxFim.TabIndex = 4;
            // 
            // buttonFor
            // 
            this.buttonFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFor.Location = new System.Drawing.Point(36, 176);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(188, 32);
            this.buttonFor.TabIndex = 5;
            this.buttonFor.Text = "FOR(impares)";
            this.buttonFor.UseVisualStyleBackColor = true;
            this.buttonFor.Click += new System.EventHandler(this.LacoFor);
            // 
            // buttonWhile
            // 
            this.buttonWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWhile.Location = new System.Drawing.Point(36, 214);
            this.buttonWhile.Name = "buttonWhile";
            this.buttonWhile.Size = new System.Drawing.Size(188, 32);
            this.buttonWhile.TabIndex = 6;
            this.buttonWhile.Text = "WHILE(pares)";
            this.buttonWhile.UseVisualStyleBackColor = true;
            this.buttonWhile.Click += new System.EventHandler(this.WhilePar);
            // 
            // buttonDoWhile
            // 
            this.buttonDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoWhile.Location = new System.Drawing.Point(36, 252);
            this.buttonDoWhile.Name = "buttonDoWhile";
            this.buttonDoWhile.Size = new System.Drawing.Size(188, 32);
            this.buttonDoWhile.TabIndex = 7;
            this.buttonDoWhile.Text = "DO / WHILE(todos)";
            this.buttonDoWhile.UseVisualStyleBackColor = true;
            this.buttonDoWhile.Click += new System.EventHandler(this.DoWhileTodos);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 24;
            this.listBoxResultado.Location = new System.Drawing.Point(256, 71);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(200, 220);
            this.listBoxResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 305);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonDoWhile);
            this.Controls.Add(this.buttonWhile);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.textBoxFim);
            this.Controls.Add(this.textBoxInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInicio;
        private System.Windows.Forms.TextBox textBoxFim;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.Button buttonWhile;
        private System.Windows.Forms.Button buttonDoWhile;
        private System.Windows.Forms.ListBox listBoxResultado;
    }
}

