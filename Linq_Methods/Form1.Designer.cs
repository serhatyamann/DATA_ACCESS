
namespace Linq_Methods
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
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnDistinct = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnAny = new System.Windows.Forms.Button();
            this.btnStartsEndsWith = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnToList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(810, 97);
            this.btnGroupBy.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(100, 28);
            this.btnGroupBy.TabIndex = 35;
            this.btnGroupBy.Text = "Group By";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(701, 97);
            this.btnDistinct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(100, 28);
            this.btnDistinct.TabIndex = 34;
            this.btnDistinct.Text = "Distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(593, 97);
            this.btnMinMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(100, 28);
            this.btnMinMax.TabIndex = 33;
            this.btnMinMax.Text = "Min - Max";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(485, 97);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(100, 28);
            this.btnSum.TabIndex = 32;
            this.btnSum.Text = "SUM";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(377, 97);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(100, 28);
            this.btnCount.TabIndex = 31;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(267, 98);
            this.btnAny.Margin = new System.Windows.Forms.Padding(4);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(100, 28);
            this.btnAny.TabIndex = 30;
            this.btnAny.Text = "Any";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // btnStartsEndsWith
            // 
            this.btnStartsEndsWith.Location = new System.Drawing.Point(134, 98);
            this.btnStartsEndsWith.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartsEndsWith.Name = "btnStartsEndsWith";
            this.btnStartsEndsWith.Size = new System.Drawing.Size(125, 28);
            this.btnStartsEndsWith.TabIndex = 29;
            this.btnStartsEndsWith.Text = "Start & End With";
            this.btnStartsEndsWith.UseVisualStyleBackColor = true;
            this.btnStartsEndsWith.Click += new System.EventHandler(this.btnStartsEndsWith_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(26, 98);
            this.btnContains.Margin = new System.Windows.Forms.Padding(4);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(100, 28);
            this.btnContains.TabIndex = 28;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(906, 62);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(100, 28);
            this.btnSkip.TabIndex = 27;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(798, 62);
            this.btnTake.Margin = new System.Windows.Forms.Padding(4);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(100, 28);
            this.btnTake.TabIndex = 26;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(690, 62);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 28);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(566, 62);
            this.btnFirstOrDefault.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(116, 28);
            this.btnFirstOrDefault.TabIndex = 24;
            this.btnFirstOrDefault.Text = "First Or Default";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            this.btnFirstOrDefault.Click += new System.EventHandler(this.btnFirstOrDefault_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(458, 62);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(100, 28);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(350, 62);
            this.btnOrderBy.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(100, 28);
            this.btnOrderBy.TabIndex = 22;
            this.btnOrderBy.Text = "Order By";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(242, 62);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 28);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "Select()";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(134, 62);
            this.btnWhere.Margin = new System.Windows.Forms.Padding(4);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(100, 28);
            this.btnWhere.TabIndex = 20;
            this.btnWhere.Text = "Where()";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnToList
            // 
            this.btnToList.Location = new System.Drawing.Point(26, 62);
            this.btnToList.Margin = new System.Windows.Forms.Padding(4);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(100, 28);
            this.btnToList.TabIndex = 19;
            this.btnToList.Text = "ToList()";
            this.btnToList.UseVisualStyleBackColor = true;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(848, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 228);
            this.listBox1.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 492);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnStartsEndsWith);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnFirstOrDefault);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnToList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnAny;
        private System.Windows.Forms.Button btnStartsEndsWith;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFirstOrDefault;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.ListBox listBox1;
    }
}

