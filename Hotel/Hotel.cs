using System;
using NLog;
using System.Windows.Forms;
using Hotel.NewFolder1;

namespace Hotel
{
    public partial class Hotel : Form
    {
        GridView db;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Hotel()
        {
            db=new GridView();
            InitializeComponent();
        }

        public void btnvip_CheckedChanged(object sender, EventArgs e)
        {
            var quary = "SELECT * FROM users where status='Выписывается'";
            logger.Info("Произошел выбор данных из таблицы базы данных с статусом-'Выписывается'");
            db.MySqlReturnData(quary, dataGridView1);
            logger.Info("Данные из таблицы базы данных выведены в таблицу 'dataGridView' ");
        }

        public void btnfree_CheckedChanged(object sender, EventArgs e)
        {
            var quary = "SELECT * FROM users where status='Свободный'";
            logger.Info("Произошел выбор данных из таблицы базы данных с статусом-'Свободный'");
            db.MySqlReturnData(quary, dataGridView1);
            logger.Info("Данные из таблицы базы данных выведены в таблицу 'dataGridView' ");
        }

        public void btnkart_Click(object sender, EventArgs e)
        {
            Card1 card = new NewFolder1.Card1();
            logger.Info("Создан экземпляр класса 'Card1'");
            card.textBoxdata.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            card.textBoxjiv.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            card.textBoxdni.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            card.textBoxfio.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            card.textBoxoplata.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            logger.Info("Выведены данные из таблицы в текстбоксы");
            card.Show();
            logger.Info("Показана форма 'Card1'");
            this.Hide();
        }

        public void btnzanyat_CheckedChanged(object sender, EventArgs e)
        {
            var quary = "SELECT * FROM users where status='Занятый'";
            logger.Info("Произошел выбор данных из таблицы базы данных с статусом-'Занятый'");
            db.MySqlReturnData(quary, dataGridView1);
            logger.Info("Данные из таблицы базы данных выведены в таблицу 'dataGridView' ");
        }

        public void btnrezerv_CheckedChanged(object sender, EventArgs e)
        {
            var quary = "SELECT * FROM users where status='Зарезервирован'";
            logger.Info("Произошел выбор данных из таблицы базы данных с статусом-'Зарезервирован'");
            db.MySqlReturnData(quary, dataGridView1);
            logger.Info("Данные из таблицы базы данных выведены в таблицу 'dataGridView' ");
        }

        public void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
                logger.Info("Произошел выход из формы");
            }
            else { this.Show(); }
        }
        public void dataGridView1_DoubleClick(object sender, EventArgs e)
        {            
            textBoxstatus.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxfio.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxvezd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxviezd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            logger.Info("Выведены данные из таблицы в текстбоксы");
        }
    }
}
