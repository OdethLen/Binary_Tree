using System.Windows.Forms;

namespace Binary_Tree
{
    public partial class Form1 : Form
    {
        private BinaryTree tree;
        public Form1()
        {
            InitializeComponent();
            tree = new BinaryTree();
            InitializeDataGridView();
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtNumbers.Text, out value))
            {
                tree.Insert(value);
                UpdateDataGridView(); // Actualizar el DataGridView
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
        }

        private void btnDeletion_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtNumbers.Text, out value))
            {
                tree.Delete(value);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtNumbers.Text, out value))
            {
                Node found = tree.Search(value);
                if (found != null)
                {
                    MessageBox.Show($"Element {value} found in the tree.");
                }
                else
                {
                    MessageBox.Show($"Element {value} not found in the tree.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                return ;
            }
        }

        private void InitializeDataGridView()
        {
            dgvTree.Columns.Clear();  // Limpiar cualquier columna previa

            dgvTree.Columns.Add("Column1", "Root Node");
            dgvTree.Columns.Add("Column2", "Left Subtree");
            dgvTree.Columns.Add("Column3", "Right Subtree");
            dgvTree.Columns.Add("Column4", "Nodes in Branch");
            dgvTree.Columns.Add("Column5", "Child Nodes");
        }


        private void UpdateDataGridView()
        {
            
                dgvTree.Rows.Clear();

                // Obtener las filas del árbol binario
                List<string[]> rows = tree.GetTreeRows();

                // Añadir las filas al DataGridView
                foreach (var row in rows)
                {
                    dgvTree.Rows.Add(row);
                }
            
        }


    }
}
