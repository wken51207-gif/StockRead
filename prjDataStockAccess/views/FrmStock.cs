using prjDataStockAccess.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prjDataStockAccess.views
{
  
    public partial class FrmStock : Form
    {
        // 宣告的同時透過 new 建立 List 物件實體
        List<CStock> _list = new List<CStock>();
        public FrmStock()
        {
            InitializeComponent();
        }

        private void sId_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source =.; Initial Catalog = dbDemo; Integrated Security = True; Encrypt = False";

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = getInsertSql();

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("股票資料新增成功");
        }
        private string getInsertSql()
        {
            string sql = $@"
    INSERT INTO tStock
    (
        sStockCode,
        sName,
        sMarket,
        sCategory,
        sBuyPrice,
        sCurrentPrice,
        sShare,
        sBuyDate,
        sAccount
    )
   VALUES
    (
    '{sStockCode.fieldValue}',
    '{sName.fieldValue}',
    '{sMarket.fieldValue}',
    '{sCategory.fieldValue}',
    {Convert.ToDecimal(sBuyPrice.fieldValue).ToString(System.Globalization.CultureInfo.InvariantCulture)},
    {Convert.ToDecimal(sCurrentPrice.fieldValue).ToString(System.Globalization.CultureInfo.InvariantCulture)},
    {Convert.ToInt32(sShare.fieldValue)},
    '{Convert.ToDateTime(sBuyDate.fieldValue).ToString("yyyy-MM-dd")}',
    '{sAccount.fieldValue}'
    )";

            return sql;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source =.; Initial Catalog = dbDemo; Integrated Security = True; Encrypt = False";

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tStock";

            SqlDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();  // 清空 ListBox
            _list.Clear();           // 清空原本的股票資料

            while (reader.Read())
            {
                listBox1.Items.Add(reader["sName"].ToString());

                CStock X = new CStock();

                X.sId = Convert.ToInt32(reader["sId"]);
                X.sStockCode = reader["sStockCode"].ToString();
                X.sName = reader["sName"].ToString();
                X.sMarket = reader["sMarket"].ToString();
                X.sCategory = reader["sCategory"].ToString();
                X.sBuyPrice = Convert.ToDecimal(reader["sBuyPrice"]);
                X.sCurrentPrice = Convert.ToDecimal(reader["sCurrentPrice"]);
                X.sShare = Convert.ToInt32(reader["sShare"]);
                X.sBuyDate = Convert.ToDateTime(reader["sBuyDate"]);
                X.sAccount = reader["sAccount"].ToString();

                _list.Add(X);
            }

            reader.Close();
            conn.Close();

            MessageBox.Show("股票資料重整成功");
        }

    }
}
