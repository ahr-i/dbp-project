﻿using deepcheesebacon.Customizing;

namespace deepcheesebacon
{
    partial class WorkMasterForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            BottomCategoryBox = new TextBox();
            MiddleCategoryBox = new TextBox();
            TopCategoryBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            BottomCategoryEdit = new TextBox();
            MiddleCategoryEdit = new TextBox();
            TopCategoryEdit = new TextBox();
            CategoryRegister = new CustomButtonStyle();
            customGroupBox1 = new CustomGroupBox();
            CategoryDelete = new CustomButtonStyle();
            CategoryEdit = new CustomButtonStyle();
            CategoryList = new DataGridView();
            customGroupBox2 = new CustomGroupBox();
            CategoryID = new ComboBox();
            customGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryList).BeginInit();
            customGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(680, 109);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 32);
            label6.TabIndex = 15;
            label6.Text = "소분류";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 109);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 32);
            label5.TabIndex = 14;
            label5.Text = "중분류";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 109);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 13;
            label4.Text = "대분류";
            // 
            // BottomCategoryBox
            // 
            BottomCategoryBox.Location = new Point(680, 147);
            BottomCategoryBox.Margin = new Padding(6);
            BottomCategoryBox.Name = "BottomCategoryBox";
            BottomCategoryBox.Size = new Size(310, 39);
            BottomCategoryBox.TabIndex = 3;
            // 
            // MiddleCategoryBox
            // 
            MiddleCategoryBox.Location = new Point(358, 147);
            MiddleCategoryBox.Margin = new Padding(6);
            MiddleCategoryBox.Name = "MiddleCategoryBox";
            MiddleCategoryBox.Size = new Size(310, 39);
            MiddleCategoryBox.TabIndex = 2;
            // 
            // TopCategoryBox
            // 
            TopCategoryBox.Location = new Point(36, 147);
            TopCategoryBox.Margin = new Padding(6);
            TopCategoryBox.Name = "TopCategoryBox";
            TopCategoryBox.Size = new Size(310, 39);
            TopCategoryBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 93);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 32);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(680, 209);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 21;
            label1.Text = "소분류";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(358, 209);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 20;
            label7.Text = "중분류";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 209);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 32);
            label8.TabIndex = 19;
            label8.Text = "대분류";
            // 
            // BottomCategoryEdit
            // 
            BottomCategoryEdit.Location = new Point(680, 247);
            BottomCategoryEdit.Margin = new Padding(6);
            BottomCategoryEdit.Name = "BottomCategoryEdit";
            BottomCategoryEdit.Size = new Size(310, 39);
            BottomCategoryEdit.TabIndex = 18;
            // 
            // MiddleCategoryEdit
            // 
            MiddleCategoryEdit.Location = new Point(358, 247);
            MiddleCategoryEdit.Margin = new Padding(6);
            MiddleCategoryEdit.Name = "MiddleCategoryEdit";
            MiddleCategoryEdit.Size = new Size(310, 39);
            MiddleCategoryEdit.TabIndex = 17;
            // 
            // TopCategoryEdit
            // 
            TopCategoryEdit.Location = new Point(36, 247);
            TopCategoryEdit.Margin = new Padding(6);
            TopCategoryEdit.Name = "TopCategoryEdit";
            TopCategoryEdit.Size = new Size(310, 39);
            TopCategoryEdit.TabIndex = 16;
            // 
            // CategoryRegister
            // 
            CategoryRegister.BackColor = Color.FromArgb(94, 159, 242);
            CategoryRegister.BackgroundColor = Color.FromArgb(94, 159, 242);
            CategoryRegister.BorderColor = Color.PaleVioletRed;
            CategoryRegister.BorderRadius = 20;
            CategoryRegister.BorderSize = 0;
            CategoryRegister.FlatAppearance.BorderSize = 0;
            CategoryRegister.FlatStyle = FlatStyle.Flat;
            CategoryRegister.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryRegister.ForeColor = Color.White;
            CategoryRegister.Location = new Point(1002, 101);
            CategoryRegister.Margin = new Padding(6);
            CategoryRegister.Name = "CategoryRegister";
            CategoryRegister.Size = new Size(300, 85);
            CategoryRegister.TabIndex = 26;
            CategoryRegister.Text = "등록";
            CategoryRegister.TextColor = Color.White;
            CategoryRegister.UseVisualStyleBackColor = false;
            CategoryRegister.Click += CategoryRegister_Click_1;
            // 
            // customGroupBox1
            // 
            customGroupBox1.BackColor = Color.Transparent;
            customGroupBox1.Controls.Add(CategoryRegister);
            customGroupBox1.Controls.Add(label6);
            customGroupBox1.Controls.Add(TopCategoryBox);
            customGroupBox1.Controls.Add(label5);
            customGroupBox1.Controls.Add(MiddleCategoryBox);
            customGroupBox1.Controls.Add(label4);
            customGroupBox1.Controls.Add(BottomCategoryBox);
            customGroupBox1.Location = new Point(15, 16);
            customGroupBox1.Margin = new Padding(6);
            customGroupBox1.Name = "customGroupBox1";
            customGroupBox1.Padding = new Padding(6);
            customGroupBox1.Radious = 25;
            customGroupBox1.Size = new Size(1338, 218);
            customGroupBox1.TabIndex = 27;
            customGroupBox1.TabStop = false;
            customGroupBox1.Text = "카테고리 등록";
            customGroupBox1.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox1.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox1.TitleForeColor = Color.White;
            customGroupBox1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // CategoryDelete
            // 
            CategoryDelete.BackColor = Color.FromArgb(94, 159, 242);
            CategoryDelete.BackgroundColor = Color.FromArgb(94, 159, 242);
            CategoryDelete.BorderColor = Color.PaleVioletRed;
            CategoryDelete.BorderRadius = 20;
            CategoryDelete.BorderSize = 0;
            CategoryDelete.FlatAppearance.BorderSize = 0;
            CategoryDelete.FlatStyle = FlatStyle.Flat;
            CategoryDelete.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryDelete.ForeColor = Color.White;
            CategoryDelete.Location = new Point(1002, 93);
            CategoryDelete.Margin = new Padding(6);
            CategoryDelete.Name = "CategoryDelete";
            CategoryDelete.Size = new Size(300, 85);
            CategoryDelete.TabIndex = 27;
            CategoryDelete.Text = "삭제";
            CategoryDelete.TextColor = Color.White;
            CategoryDelete.UseVisualStyleBackColor = false;
            CategoryDelete.Click += CategoryDelete_Click_1;
            // 
            // CategoryEdit
            // 
            CategoryEdit.BackColor = Color.FromArgb(94, 159, 242);
            CategoryEdit.BackgroundColor = Color.FromArgb(94, 159, 242);
            CategoryEdit.BorderColor = Color.PaleVioletRed;
            CategoryEdit.BorderRadius = 20;
            CategoryEdit.BorderSize = 0;
            CategoryEdit.FlatAppearance.BorderSize = 0;
            CategoryEdit.FlatStyle = FlatStyle.Flat;
            CategoryEdit.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryEdit.ForeColor = Color.White;
            CategoryEdit.Location = new Point(1002, 201);
            CategoryEdit.Margin = new Padding(6);
            CategoryEdit.Name = "CategoryEdit";
            CategoryEdit.Size = new Size(300, 85);
            CategoryEdit.TabIndex = 28;
            CategoryEdit.Text = "수정";
            CategoryEdit.TextColor = Color.White;
            CategoryEdit.UseVisualStyleBackColor = false;
            CategoryEdit.Click += CategoryEdit_Click;
            // 
            // CategoryList
            // 
            CategoryList.BackgroundColor = Color.White;
            CategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryList.Location = new Point(15, 576);
            CategoryList.Margin = new Padding(6);
            CategoryList.Name = "CategoryList";
            CategoryList.ReadOnly = true;
            CategoryList.RowHeadersWidth = 82;
            CategoryList.RowTemplate.Height = 25;
            CategoryList.Size = new Size(1338, 699);
            CategoryList.TabIndex = 29;
            // 
            // customGroupBox2
            // 
            customGroupBox2.BackColor = Color.Transparent;
            customGroupBox2.Controls.Add(CategoryID);
            customGroupBox2.Controls.Add(label2);
            customGroupBox2.Controls.Add(CategoryEdit);
            customGroupBox2.Controls.Add(BottomCategoryEdit);
            customGroupBox2.Controls.Add(CategoryDelete);
            customGroupBox2.Controls.Add(TopCategoryEdit);
            customGroupBox2.Controls.Add(MiddleCategoryEdit);
            customGroupBox2.Controls.Add(label1);
            customGroupBox2.Controls.Add(label8);
            customGroupBox2.Controls.Add(label7);
            customGroupBox2.Location = new Point(15, 246);
            customGroupBox2.Margin = new Padding(6);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Padding = new Padding(6);
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(1338, 318);
            customGroupBox2.TabIndex = 28;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "카테고리 수정";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // CategoryID
            // 
            CategoryID.FormattingEnabled = true;
            CategoryID.Location = new Point(36, 128);
            CategoryID.Name = "CategoryID";
            CategoryID.Size = new Size(310, 40);
            CategoryID.TabIndex = 29;
            CategoryID.SelectedIndexChanged += CategoryID_SelectedIndexChanged;
            CategoryID.Click += CategoryID_Click;
            // 
            // WorkMasterForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 1296);
            Controls.Add(customGroupBox2);
            Controls.Add(CategoryList);
            Controls.Add(customGroupBox1);
            Margin = new Padding(6);
            Name = "WorkMasterForm";
            Text = "Form2";
            customGroupBox1.ResumeLayout(false);
            customGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryList).EndInit();
            customGroupBox2.ResumeLayout(false);
            customGroupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TopCategoryBox;
        private GroupBox MiddleCategorygGroup;
        private ComboBox TopCategoryCombo;
        private Button MiddleCategoryRegi;
        private GroupBox BottomCategorygGroup;
        private Button BottomCategoryRegi;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private TextBox textBox7;
        private TextBox textBox9;
        private ComboBox MiddleCategoryCombo;
        private ComboBox TopCategoryCombo2;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox BottomCategoryBox;
        private TextBox MiddleCategoryBox;
        private Label label1;
        private Label label7;
        private Label label8;
        private TextBox BottomCategoryEdit;
        private TextBox MiddleCategoryEdit;
        private TextBox TopCategoryEdit;
        private Label label3;
        private CustomButtonStyle CategoryRegister;
        private CustomGroupBox customGroupBox1;
        private CustomButtonStyle CategoryDelete;
        private CustomButtonStyle CategoryEdit;
        private DataGridView CategoryList;
        private CustomGroupBox customGroupBox2;
        private ComboBox CategoryID;
    }
}