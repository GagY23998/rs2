using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTravelAgency.Desktop.Reviews
{
    public partial class frmReviewDetails : Form
    {
        private readonly int? _id;
        private readonly APIService _service = new APIService("rating");
        public frmReviewDetails(int ?id =null)
        {
            _id = id;
            InitializeComponent();
        }


        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var res = await _service.Delete<RatingDTO>(_id);
                if (res != null)
                {
                    MessageBox.Show("Successufully deleted review");
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
