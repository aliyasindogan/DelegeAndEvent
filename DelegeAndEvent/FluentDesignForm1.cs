using System;
using System.Windows.Forms;

namespace DelegeAndEvent
{
    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        //1/5 ) Delege tanımlanıyor
        public delegate void SelectedPageNameHandler(string PageName);

        //2/5 ) Event tanımlanıyor
        public static event SelectedPageNameHandler SelectedPageName;

        public FluentDesignForm1()
        {
            InitializeComponent();
        }

        private void FluentDesignForm1_Load(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new xucNavigation() { Dock = DockStyle.Top });
            fluentDesignFormContainer1.Controls.Add(new xucMain() { Dock = DockStyle.Bottom });
        }

        private void aceUserList_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new xucNavigation() { Dock = DockStyle.Top });
            fluentDesignFormContainer1.Controls.Add(new xucUserList() { Dock = DockStyle.Bottom });

            //3/5 ) Event nerede kullanılacaksa oraya ekleniyor.
            SelectedPageName("Kullanıcı Listesi");
        }

        private void aceCategoryList_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new xucNavigation() { Dock = DockStyle.Top });
            fluentDesignFormContainer1.Controls.Add(new xucCategoryList() { Dock = DockStyle.Bottom });
            SelectedPageName("Kategori Listesi");
        }

        private void aceMain_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new xucNavigation() { Dock = DockStyle.Top });
            fluentDesignFormContainer1.Controls.Add(new xucMain() { Dock = DockStyle.Bottom });
            SelectedPageName("Ana Sayfa");
        }
    }
}