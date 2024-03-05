
namespace Alex_Carter_CPT_206_Homework_Lab1
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
            this.productListBox = new System.Windows.Forms.ListBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.desTextBox = new System.Windows.Forms.TextBox();
            this.numLabel = new System.Windows.Forms.Label();
            this.desLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchByButton = new System.Windows.Forms.Button();
            this.searchByDesButton = new System.Windows.Forms.Button();
            this.uOHLabel = new System.Windows.Forms.Label();
            this.uOHTextBox = new System.Windows.Forms.TextBox();
            this.allUnitsButton = new System.Windows.Forms.Button();
            this.greaterButton = new System.Windows.Forms.Button();
            this.lessButton = new System.Windows.Forms.Button();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.allPriceButton = new System.Windows.Forms.Button();
            this.minMaxButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productListBox
            // 
            this.productListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 20;
            this.productListBox.Location = new System.Drawing.Point(114, 12);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(553, 164);
            this.productListBox.TabIndex = 0;
            // 
            // numTextBox
            // 
            this.numTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox.Location = new System.Drawing.Point(326, 190);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(109, 27);
            this.numTextBox.TabIndex = 1;
            // 
            // desTextBox
            // 
            this.desTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desTextBox.Location = new System.Drawing.Point(326, 238);
            this.desTextBox.Name = "desTextBox";
            this.desTextBox.Size = new System.Drawing.Size(396, 27);
            this.desTextBox.TabIndex = 2;
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel.Location = new System.Drawing.Point(12, 193);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(197, 20);
            this.numLabel.TabIndex = 3;
            this.numLabel.Text = "Enter product number:";
            // 
            // desLabel
            // 
            this.desLabel.AutoSize = true;
            this.desLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desLabel.Location = new System.Drawing.Point(12, 241);
            this.desLabel.Name = "desLabel";
            this.desLabel.Size = new System.Drawing.Size(255, 20);
            this.desLabel.TabIndex = 4;
            this.desLabel.Text = "Enter description key words: ";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(16, 281);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(216, 35);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search &All";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchByButton
            // 
            this.searchByButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchByButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByButton.Location = new System.Drawing.Point(247, 281);
            this.searchByButton.Name = "searchByButton";
            this.searchByButton.Size = new System.Drawing.Size(274, 35);
            this.searchByButton.TabIndex = 6;
            this.searchByButton.Text = "Search By (Product #)";
            this.searchByButton.UseVisualStyleBackColor = false;
            this.searchByButton.Click += new System.EventHandler(this.searchByButton_Click);
            // 
            // searchByDesButton
            // 
            this.searchByDesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchByDesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDesButton.Location = new System.Drawing.Point(540, 281);
            this.searchByDesButton.Name = "searchByDesButton";
            this.searchByDesButton.Size = new System.Drawing.Size(248, 35);
            this.searchByDesButton.TabIndex = 7;
            this.searchByDesButton.Text = "Search By (Description)";
            this.searchByDesButton.UseVisualStyleBackColor = false;
            this.searchByDesButton.Click += new System.EventHandler(this.searchByDesButton_Click);
            // 
            // uOHLabel
            // 
            this.uOHLabel.AutoSize = true;
            this.uOHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uOHLabel.Location = new System.Drawing.Point(12, 337);
            this.uOHLabel.Name = "uOHLabel";
            this.uOHLabel.Size = new System.Drawing.Size(470, 20);
            this.uOHLabel.TabIndex = 8;
            this.uOHLabel.Text = "Enter Units On Hand Amount or click Search All Units:";
            // 
            // uOHTextBox
            // 
            this.uOHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uOHTextBox.Location = new System.Drawing.Point(593, 334);
            this.uOHTextBox.Name = "uOHTextBox";
            this.uOHTextBox.Size = new System.Drawing.Size(129, 27);
            this.uOHTextBox.TabIndex = 9;
            // 
            // allUnitsButton
            // 
            this.allUnitsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.allUnitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUnitsButton.Location = new System.Drawing.Point(16, 382);
            this.allUnitsButton.Name = "allUnitsButton";
            this.allUnitsButton.Size = new System.Drawing.Size(216, 35);
            this.allUnitsButton.TabIndex = 10;
            this.allUnitsButton.Text = "Search All &Units";
            this.allUnitsButton.UseVisualStyleBackColor = false;
            this.allUnitsButton.Click += new System.EventHandler(this.allUnitsButton_Click);
            // 
            // greaterButton
            // 
            this.greaterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.greaterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greaterButton.Location = new System.Drawing.Point(247, 382);
            this.greaterButton.Name = "greaterButton";
            this.greaterButton.Size = new System.Drawing.Size(274, 35);
            this.greaterButton.TabIndex = 11;
            this.greaterButton.Text = "Greater Than";
            this.greaterButton.UseVisualStyleBackColor = false;
            this.greaterButton.Click += new System.EventHandler(this.greaterButton_Click);
            // 
            // lessButton
            // 
            this.lessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessButton.Location = new System.Drawing.Point(540, 382);
            this.lessButton.Name = "lessButton";
            this.lessButton.Size = new System.Drawing.Size(248, 35);
            this.lessButton.TabIndex = 12;
            this.lessButton.Text = "Less Than";
            this.lessButton.UseVisualStyleBackColor = false;
            this.lessButton.Click += new System.EventHandler(this.lessButton_Click);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(64, 447);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(100, 20);
            this.minLabel.TabIndex = 13;
            this.minLabel.Text = "Min. Price:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(399, 447);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(104, 20);
            this.maxLabel.TabIndex = 14;
            this.maxLabel.Text = "Max. Price:";
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextBox.Location = new System.Drawing.Point(191, 444);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(175, 27);
            this.minTextBox.TabIndex = 15;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextBox.Location = new System.Drawing.Point(527, 444);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(156, 27);
            this.maxTextBox.TabIndex = 16;
            // 
            // allPriceButton
            // 
            this.allPriceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.allPriceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPriceButton.Location = new System.Drawing.Point(16, 483);
            this.allPriceButton.Name = "allPriceButton";
            this.allPriceButton.Size = new System.Drawing.Size(216, 35);
            this.allPriceButton.TabIndex = 17;
            this.allPriceButton.Text = "Search All &Price";
            this.allPriceButton.UseVisualStyleBackColor = false;
            this.allPriceButton.Click += new System.EventHandler(this.allPriceButton_Click);
            // 
            // minMaxButton
            // 
            this.minMaxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.minMaxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minMaxButton.Location = new System.Drawing.Point(247, 483);
            this.minMaxButton.Name = "minMaxButton";
            this.minMaxButton.Size = new System.Drawing.Size(541, 35);
            this.minMaxButton.TabIndex = 18;
            this.minMaxButton.Text = "Search Price Between Min. and Max.";
            this.minMaxButton.UseVisualStyleBackColor = false;
            this.minMaxButton.Click += new System.EventHandler(this.minMaxButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(326, 524);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(133, 43);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "&Exit";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minMaxButton);
            this.Controls.Add(this.allPriceButton);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.lessButton);
            this.Controls.Add(this.greaterButton);
            this.Controls.Add(this.allUnitsButton);
            this.Controls.Add(this.uOHTextBox);
            this.Controls.Add(this.uOHLabel);
            this.Controls.Add(this.searchByDesButton);
            this.Controls.Add(this.searchByButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.desLabel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.desTextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.productListBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox desTextBox;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label desLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button searchByButton;
        private System.Windows.Forms.Button searchByDesButton;
        private System.Windows.Forms.Label uOHLabel;
        private System.Windows.Forms.TextBox uOHTextBox;
        private System.Windows.Forms.Button allUnitsButton;
        private System.Windows.Forms.Button greaterButton;
        private System.Windows.Forms.Button lessButton;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Button allPriceButton;
        private System.Windows.Forms.Button minMaxButton;
        private System.Windows.Forms.Button closeButton;
    }
}

