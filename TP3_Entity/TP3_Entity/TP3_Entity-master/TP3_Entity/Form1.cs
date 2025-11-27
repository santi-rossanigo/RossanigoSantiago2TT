namespace TP3_Entity
{
    public partial class Form1 : Form
    {
        private readonly RepositorioProductos repo = new RepositorioProductos();

        public Form1()
        {
            InitializeComponent();
        }

        // Opcional: cargar lista al abrir
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dgv.DataSource = repo.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var p = new Producto
            {
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text)
            };
            repo.Agregar(p);
            dgv.DataSource = repo.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = repo.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;

            int id = (int)dgv.CurrentRow.Cells[nameof(Producto.Id)].Value;
            var p = new Producto
            {
                Id = id,
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text)
            };
            repo.Actualizar(p);
            dgv.DataSource = repo.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;

            int id = (int)dgv.CurrentRow.Cells[nameof(Producto.Id)].Value;
            repo.Eliminar(id);
            dgv.DataSource = repo.Listar();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow == null) return;

            txtNombre.Text = dgv.CurrentRow.Cells[nameof(Producto.Nombre)].Value?.ToString();
            txtPrecio.Text = dgv.CurrentRow.Cells[nameof(Producto.Precio)].Value?.ToString();
            txtStock.Text = dgv.CurrentRow.Cells[nameof(Producto.Stock)].Value?.ToString();
        }
    }
}
