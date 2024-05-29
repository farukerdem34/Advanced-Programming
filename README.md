# Advanced Programming
## TO-DO
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
string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_name_here;Integrated Security=True;";
```

```C#
// Fixed Function For DB Connection
void view_data()
        {
            conn = new SqlConnection(conn_string);
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM [db_name_here]", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
```
