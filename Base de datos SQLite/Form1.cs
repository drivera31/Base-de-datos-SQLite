using System.Data.SQLite;
namespace Base_de_datos_SQLite
{
    public partial class Form1 : Form
    {
        //agregamos la base de datos
        string path = "data_table.db";
        string cs = @"URI=File:" + Application.StartupPath + "\\data_table.db";
        //la base de datos se crea en la carpeta debug
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
        }
        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvbasededatos.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table test (name varchar(20), id varchar(20))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("La base de datos no se puede crear");
                return;
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "INSERT INTO test(name, id) VALUES(@name, @id)";
                string NAME = txtnombre.Text;
                string ID = txtid.Text;
                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue("@id", ID);

                dgvbasededatos.ColumnCount = 2;
                dgvbasededatos.Columns[0].Name = "Nombre";
                dgvbasededatos.Columns[1].Name = "Id";
                string[] row = new string[] { NAME, ID };
                dgvbasededatos.Rows.Add(row);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo insertar la información");
                return;
            }
        }

        private void dgvbasededatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE test SET id=@id WHERE name=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", txtnombre.Text);
                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.ExecuteNonQuery();
                dgvbasededatos.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo actualizar la información");
                return;
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
          var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "DELETE FROM test WHERE name=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", txtnombre.Text);
                cmd.ExecuteNonQuery();
                dgvbasededatos.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar la información");
                return;
            }
        }
    }
}
