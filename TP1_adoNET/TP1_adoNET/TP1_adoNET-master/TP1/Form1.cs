namespace TP1
{
    public partial class Form1 : Form
    {
        private readonly RepositorioProductos repo = new RepositorioProductos();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Completa Nombre y un Precio válido.");
                return;
            }

            var p = new Producto { Nombre = txtNombre.Text.Trim(), Precio = precio };
            repo.Agregar(p);
            MessageBox.Show("Producto agregado.");
            btnListar_Click(sender, e);
            Limpiar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = repo.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Id inválido.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Completa Nombre y un Precio válido.");
                return;
            }

            var p = new Producto { Id = id, Nombre = txtNombre.Text.Trim(), Precio = precio };
            repo.Modificar(p);
            MessageBox.Show("Producto modificado.");
            btnListar_Click(sender, e);
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Id inválido.");
                return;
            }

            repo.Eliminar(id);
            MessageBox.Show("Producto eliminado.");
            btnListar_Click(sender, e);
            Limpiar();
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
        }

       
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Rows[e.RowIndex].DataBoundItem is Producto p)
            {
                txtId.Text = p.Id.ToString();
                txtNombre.Text = p.Nombre;
                txtPrecio.Text = p.Precio.ToString("0.00");
            }
        }
    }
}
