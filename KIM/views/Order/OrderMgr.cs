using KIM.models.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.Order
{
	public partial class OrderMgr : Form
	{
		#region class field member
		private static OrderMgr instance;
		private DataActionMode _mode = DataActionMode.None;
		private string _selectedOrderId = string.Empty;
		#endregion

		#region class properties
		public static OrderMgr GetInstance
		{
			get
			{
				if(instance == null || instance.IsDisposed)
				{
					instance = new OrderMgr();
				}
				return instance;
			}
		}

		#endregion

		#region class helper
		private void UpdateUI()
		{
			tsbtnEdit.Enabled = !String.IsNullOrEmpty(_selectedOrderId);

		}

		private void GetOrderList()
		{
			dgv.SuspendLayout();
			dgv.ClearSelection();
			dgv.DataSource = new OrderDAL().GetAllActiveOrders();
			dgv.ResumeLayout();

			UpdateUI();
		}

		private void AddOrUpdateOrder(string orderId)
		{


			GetOrderList();
		}


		#endregion
		public OrderMgr()
		{
			InitializeComponent();

			dgv.DoubleBuffered();
			dgv.SettingDataGrid();

			CenterToScreen();
		}

		private void OrderMgr_Load(object sender, EventArgs e)
		{
			GetOrderList();
		}

		private void tsbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			_selectedOrderId = dgv["OrderId", e.RowIndex].Value.ToString();

			UpdateUI();
		}

		private void dgv_DoubleClick(object sender, EventArgs e)
		{
			tsbtnEdit.PerformClick();
		}

		private void tsbtnAdd_Click(object sender, EventArgs e)
		{
			_selectedOrderId = string.Empty;
			AddOrUpdateOrder(_selectedOrderId);
		}

		private void tsbtnEdit_Click(object sender, EventArgs e)
		{
			AddOrUpdateOrder(_selectedOrderId);
		}

		private void tsbtnDelete_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Do you want to delete the selected Order?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if(new OrderDAL().DeleteOrder(_selectedOrderId) > 0)
				{
					MessageBox.Show("Delete selected order successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

					GetOrderList();
				}
			}
		}
	}
}
