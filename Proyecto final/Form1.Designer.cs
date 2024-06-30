namespace Proyecto_final
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
            TextoInicial = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            menuStrip1 = new MenuStrip();
            seriesToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            bToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            dToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TextoInicial
            // 
            TextoInicial.AutoSize = true;
            TextoInicial.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TextoInicial.Location = new Point(340, 50);
            TextoInicial.Name = "TextoInicial";
            TextoInicial.Size = new Size(207, 25);
            TextoInicial.TabIndex = 0;
            TextoInicial.Text = "Su respuesta sale aquí";
            TextoInicial.Click += TextoInicial_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(146, 105);
            button1.Name = "button1";
            button1.Size = new Size(116, 33);
            button1.TabIndex = 1;
            button1.Text = "Mayor Digitos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(146, 154);
            button2.Name = "button2";
            button2.Size = new Size(116, 34);
            button2.TabIndex = 3;
            button2.Text = "sumar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(146, 194);
            button3.Name = "button3";
            button3.Size = new Size(116, 30);
            button3.TabIndex = 4;
            button3.Text = "Mayor Digitos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(146, 241);
            button4.Name = "button4";
            button4.Size = new Size(143, 27);
            button4.TabIndex = 5;
            button4.Text = "Numero Ordenado";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11F);
            button5.Location = new Point(146, 287);
            button5.Name = "button5";
            button5.Size = new Size(143, 33);
            button5.TabIndex = 6;
            button5.Text = "Cantidad Digitos Impar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { seriesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // seriesToolStripMenuItem
            // 
            seriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem, bToolStripMenuItem, cToolStripMenuItem, dToolStripMenuItem, eToolStripMenuItem });
            seriesToolStripMenuItem.Name = "seriesToolStripMenuItem";
            seriesToolStripMenuItem.Size = new Size(49, 20);
            seriesToolStripMenuItem.Text = "Series";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(180, 22);
            aToolStripMenuItem.Text = "Ejercicio 1";
            aToolStripMenuItem.Click += aToolStripMenuItem_Click;
            // 
            // bToolStripMenuItem
            // 
            bToolStripMenuItem.Name = "bToolStripMenuItem";
            bToolStripMenuItem.Size = new Size(180, 22);
            bToolStripMenuItem.Text = "Ejercicio 2";
            bToolStripMenuItem.Click += bToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(180, 22);
            cToolStripMenuItem.Text = "Ejercicio 3";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // dToolStripMenuItem
            // 
            dToolStripMenuItem.Name = "dToolStripMenuItem";
            dToolStripMenuItem.Size = new Size(180, 22);
            dToolStripMenuItem.Text = "Ejercicio 4";
            dToolStripMenuItem.Click += dToolStripMenuItem_Click;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(180, 22);
            eToolStripMenuItem.Text = "Ejercicio 5";
            eToolStripMenuItem.Click += eToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(TextoInicial);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextoInicial;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem seriesToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
    }
}
