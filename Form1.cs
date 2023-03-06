namespace MyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyTree<string> tree = new MyTree<string>();
        bool balancedTree = false;

        private void buttonAddNode_Click(object sender, EventArgs e)
        {
            //tree.Add(Convert.ToInt32(textBoxNodeValue.Text), balancedTree);
            labelDeep.Text = Convert.ToString("Deep - " + tree.GetDeep());
            labelLeafCount.Text = "Leaf count - " + tree.GetLeafs();
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*TopMost = true;
            WindowState = FormWindowState.Maximized;*/
            checkBoxBalanced.Left = Width - 183;
            label1.Left = Width - 183;
            textBoxNodeValue.Left = Width - 183;
            buttonAddNode.Left = Width - 183;
            buttonRemoveNode.Left = Width - 183;
            labelDeep.Left = Width - 183;
            labelLeafCount.Left = Width - 183;
            label4.Left = Width - 183;
            buttonInOrder.Left = Width - 183;
            buttonPostOrder.Left = Width - 183;
            buttonPreOrder.Left = Width - 183;
            textBoxForOrder.Left = Width - 183;
            pictureBoxDraw.Width = Width - 195;
            /*tree.Add(50, true);
            tree.Add(70, true);
            tree.Add(60, true);
            
            tree.Add(53, false);
            tree.Add(54, false);
            tree.Add(55, false);
            tree.Add(57, false);
            tree.Add(63, false);
            tree.Add(65, false);
            tree.Add(67, false);*/
        }

        private void pictureBoxDraw_Paint(object sender, PaintEventArgs e)
        {
            tree.Draw(e.Graphics, pictureBoxDraw.Width);
        }

        private void buttonRemoveNode_Click(object sender, EventArgs e)
        {
            //tree.Remove(Convert.ToInt32(textBoxNodeValue.Text), balancedTree);
            Refresh();
            labelDeep.Text = Convert.ToString("Deep - " + tree.GetDeep());
            labelLeafCount.Text = "Leaf count - " + tree.GetLeafs();
        }

        private void buttonInOrder_Click(object sender, EventArgs e)
        {
            textBoxForOrder.Text = "LNR: " + tree.LNR();
        }

        private void buttonPostOrder_Click(object sender, EventArgs e)
        {
            textBoxForOrder.Text = "NLR: " + tree.NLR();
        }

        private void buttonPreOrder_Click(object sender, EventArgs e)
        {
            textBoxForOrder.Text = "LRN: " + tree.LRN();
        }

        private void checkBoxBalanced_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBalanced.Checked)
            {
                tree.BalanceNOW();
            }
            balancedTree = checkBoxBalanced.Checked;
            Refresh();
            labelDeep.Text = Convert.ToString("Deep - " + tree.GetDeep());
            labelLeafCount.Text = "Leaf count - " + tree.GetLeafs();
        }

        private void buttonTextAdd_Click(object sender, EventArgs e)
        {
            string[] words = textBoxText.Text.Split(' ', ',');
            foreach (string word in words)
            {
                word.ToLower();
            }
            foreach (string word in words)
            {
                if (word != " " && word != "")
                {
                    tree.Add(word, true);
                }
            }
            textBoxForOrder.Text = tree.NLR_Words();
        }
    }
}