# Advanced Programming
## TO-DO
* [ ] Brick Game
* [ ] Multi Form App
* [ ] Recursive Functions (Fibbonaci etc.) 
## Database Integration Vitals 

```C#
// Import SqlClient library
using System.Data.SqlClient;
```

```C#
// Assign SQL Client objects
SqlConnection conn;
SqlDataAdapter adapter;
SqlCommand cmd;
string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=picture_db;Integrated Security=True;";
```

```C#
// Fixed Function For DB Connection
void view_data()
        {
            conn = new SqlConnection(conn_string);
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM p_table", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            conn.Close();
        }
```
