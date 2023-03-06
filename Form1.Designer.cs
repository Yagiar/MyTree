namespace MyTree
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
            this.buttonAddNode = new System.Windows.Forms.Button();
            this.textBoxNodeValue = new System.Windows.Forms.TextBox();
            this.checkBoxBalanced = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveNode = new System.Windows.Forms.Button();
            this.labelDeep = new System.Windows.Forms.Label();
            this.labelLeafCount = new System.Windows.Forms.Label();
            this.buttonInOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPostOrder = new System.Windows.Forms.Button();
            this.buttonPreOrder = new System.Windows.Forms.Button();
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.textBoxForOrder = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.buttonTextAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNode
            // 
            this.buttonAddNode.Location = new System.Drawing.Point(1052, 109);
            this.buttonAddNode.Name = "buttonAddNode";
            this.buttonAddNode.Size = new System.Drawing.Size(149, 34);
            this.buttonAddNode.TabIndex = 0;
            this.buttonAddNode.Text = "Add";
            this.buttonAddNode.UseVisualStyleBackColor = true;
            this.buttonAddNode.Click += new System.EventHandler(this.buttonAddNode_Click);
            // 
            // textBoxNodeValue
            // 
            this.textBoxNodeValue.Location = new System.Drawing.Point(1052, 72);
            this.textBoxNodeValue.Name = "textBoxNodeValue";
            this.textBoxNodeValue.Size = new System.Drawing.Size(149, 31);
            this.textBoxNodeValue.TabIndex = 1;
            // 
            // checkBoxBalanced
            // 
            this.checkBoxBalanced.AutoSize = true;
            this.checkBoxBalanced.Location = new System.Drawing.Point(1052, 12);
            this.checkBoxBalanced.Name = "checkBoxBalanced";
            this.checkBoxBalanced.Size = new System.Drawing.Size(108, 29);
            this.checkBoxBalanced.TabIndex = 2;
            this.checkBoxBalanced.Text = "Balanced";
            this.checkBoxBalanced.UseVisualStyleBackColor = true;
            this.checkBoxBalanced.CheckedChanged += new System.EventHandler(this.checkBoxBalanced_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1052, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Node value:";
            // 
            // buttonRemoveNode
            // 
            this.buttonRemoveNode.Location = new System.Drawing.Point(1052, 149);
            this.buttonRemoveNode.Name = "buttonRemoveNode";
            this.buttonRemoveNode.Size = new System.Drawing.Size(149, 34);
            this.buttonRemoveNode.TabIndex = 4;
            this.buttonRemoveNode.Text = "Remove";
            this.buttonRemoveNode.UseVisualStyleBackColor = true;
            this.buttonRemoveNode.Click += new System.EventHandler(this.buttonRemoveNode_Click);
            // 
            // labelDeep
            // 
            this.labelDeep.AutoSize = true;
            this.labelDeep.Location = new System.Drawing.Point(1052, 186);
            this.labelDeep.Name = "labelDeep";
            this.labelDeep.Size = new System.Drawing.Size(81, 25);
            this.labelDeep.TabIndex = 5;
            this.labelDeep.Text = "Deep - 0";
            // 
            // labelLeafCount
            // 
            this.labelLeafCount.AutoSize = true;
            this.labelLeafCount.Location = new System.Drawing.Point(1052, 211);
            this.labelLeafCount.Name = "labelLeafCount";
            this.labelLeafCount.Size = new System.Drawing.Size(121, 25);
            this.labelLeafCount.TabIndex = 6;
            this.labelLeafCount.Text = "Leaf count - 0";
            // 
            // buttonInOrder
            // 
            this.buttonInOrder.Location = new System.Drawing.Point(1052, 264);
            this.buttonInOrder.Name = "buttonInOrder";
            this.buttonInOrder.Size = new System.Drawing.Size(149, 34);
            this.buttonInOrder.TabIndex = 7;
            this.buttonInOrder.Text = "In-Order";
            this.buttonInOrder.UseVisualStyleBackColor = true;
            this.buttonInOrder.Click += new System.EventHandler(this.buttonInOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1052, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Traversals:";
            // 
            // buttonPostOrder
            // 
            this.buttonPostOrder.Location = new System.Drawing.Point(1052, 304);
            this.buttonPostOrder.Name = "buttonPostOrder";
            this.buttonPostOrder.Size = new System.Drawing.Size(149, 34);
            this.buttonPostOrder.TabIndex = 9;
            this.buttonPostOrder.Text = "Post-Order";
            this.buttonPostOrder.UseVisualStyleBackColor = true;
            this.buttonPostOrder.Click += new System.EventHandler(this.buttonPostOrder_Click);
            // 
            // buttonPreOrder
            // 
            this.buttonPreOrder.Location = new System.Drawing.Point(1052, 344);
            this.buttonPreOrder.Name = "buttonPreOrder";
            this.buttonPreOrder.Size = new System.Drawing.Size(149, 34);
            this.buttonPreOrder.TabIndex = 10;
            this.buttonPreOrder.Text = "Pre-Order";
            this.buttonPreOrder.UseVisualStyleBackColor = true;
            this.buttonPreOrder.Click += new System.EventHandler(this.buttonPreOrder_Click);
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(1034, 676);
            this.pictureBoxDraw.TabIndex = 12;
            this.pictureBoxDraw.TabStop = false;
            this.pictureBoxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDraw_Paint);
            // 
            // textBoxForOrder
            // 
            this.textBoxForOrder.Location = new System.Drawing.Point(1052, 384);
            this.textBoxForOrder.Multiline = true;
            this.textBoxForOrder.Name = "textBoxForOrder";
            this.textBoxForOrder.Size = new System.Drawing.Size(149, 304);
            this.textBoxForOrder.TabIndex = 13;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(12, 694);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(1189, 172);
            this.textBoxText.TabIndex = 14;
            // 
            // buttonTextAdd
            // 
            this.buttonTextAdd.Location = new System.Drawing.Point(524, 872);
            this.buttonTextAdd.Name = "buttonTextAdd";
            this.buttonTextAdd.Size = new System.Drawing.Size(149, 34);
            this.buttonTextAdd.TabIndex = 15;
            this.buttonTextAdd.Text = "Text add";
            this.buttonTextAdd.UseVisualStyleBackColor = true;
            this.buttonTextAdd.Click += new System.EventHandler(this.buttonTextAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 918);
            this.Controls.Add(this.buttonTextAdd);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxForOrder);
            this.Controls.Add(this.pictureBoxDraw);
            this.Controls.Add(this.buttonPreOrder);
            this.Controls.Add(this.buttonPostOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonInOrder);
            this.Controls.Add(this.labelLeafCount);
            this.Controls.Add(this.labelDeep);
            this.Controls.Add(this.buttonRemoveNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxBalanced);
            this.Controls.Add(this.textBoxNodeValue);
            this.Controls.Add(this.buttonAddNode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddNode;
        private TextBox textBoxNodeValue;
        private CheckBox checkBoxBalanced;
        private Label label1;
        private Button buttonRemoveNode;
        private Label labelDeep;
        private Label labelLeafCount;
        private Button buttonInOrder;
        private Label label4;
        private Button buttonPostOrder;
        private Button buttonPreOrder;
        private PictureBox pictureBoxDraw;
        private TextBox textBoxForOrder;
        private TextBox textBoxText;
        private Button buttonTextAdd;
    }
}