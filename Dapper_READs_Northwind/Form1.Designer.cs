
namespace Dapper_READs_Northwind
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExampleQueries = new System.Windows.Forms.Button();
            this.txtParameter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExampleQueries
            // 
            this.btnExampleQueries.Location = new System.Drawing.Point(12, 118);
            this.btnExampleQueries.Name = "btnExampleQueries";
            this.btnExampleQueries.Size = new System.Drawing.Size(292, 93);
            this.btnExampleQueries.TabIndex = 1;
            this.btnExampleQueries.Text = "Example Queries";
            this.btnExampleQueries.UseVisualStyleBackColor = true;
            this.btnExampleQueries.Click += new System.EventHandler(this.btnExampleQueries_Click);
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(120, 56);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(100, 22);
            this.txtParameter.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 615);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.btnExampleQueries);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExampleQueries;
        private System.Windows.Forms.TextBox txtParameter;
    }
}

