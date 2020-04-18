using DevExpress.XtraEditors;
using System;

namespace DelegeAndEvent
{
    public partial class xucNavigation : XtraUserControl
    {
        public xucNavigation()
        {
            InitializeComponent();
        }

        private void xucNavigation_Load(object sender, EventArgs e)
        {
            //4/5 ) xucNavigation UserControl Load olduğunda (sayfa yüklendiğinde) Event'ımızı tanımlıyoruz
            FluentDesignForm1.SelectedPageName += _fluentDesignForm1_SelectedPageName;
        }

        //5/5 ) Event tanımlandığında metodumuza ilgili metodumuzda yapmak istediğimiz işlemleri kodluyoruz.
        private void _fluentDesignForm1_SelectedPageName(string PageName)
        {
            lblPageName.Text = PageName;
        }
    }
}