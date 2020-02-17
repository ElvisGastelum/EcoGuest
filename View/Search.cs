using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public partial class Search : Form
    {
        SearchController searchController = new SearchController();
        private PrincipalMenu principalMenu;
        public Search(PrincipalMenu principalMenu)
        {
            InitializeComponent();
            this.principalMenu = principalMenu;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.DataSource = searchController.GetList();
        }

        private void ExitForm(object sender, FormClosedEventArgs e)
        {
            ExitForm();
        }

        private void ExitForm()
        {
            Hide();
            principalMenu.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var List = (BindingList<Client>)dataGridView.DataSource;
                var SelectedRow = dataGridView.SelectedRows[0].Index;

                if (SelectedRow < List.Count)
                {
                    List.RemoveAt(SelectedRow);
                    searchController.SetList(List);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_modificarC_Click(object sender, EventArgs e)
        {
            try
            {
                var List = (BindingList<Client>)dataGridView.DataSource;
                var SelectedRow = dataGridView.SelectedRows[0].Index;

                if (SelectedRow < List.Count)
                {
                    ClientModification clientModification = new ClientModification(
                            this,
                            List.ElementAt(SelectedRow),
                            List,
                            SelectedRow
                        );
                    Hide();
                    clientModification.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SearchClient();
        }

        public void SearchClient()
        {
            try
            {
                var List = (BindingList<Client>)dataGridView.DataSource;
                var SourceList = searchController.GetList();

                searchController.SearchClientsByName(List, txt_nombreC.Text, SourceList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void EnterPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                SearchClient();
            }
        }

        private void btn_saldarDeuda_Click(object sender, EventArgs e)
        {
            try
            {
                var List = (BindingList<Client>)dataGridView.DataSource;
                var SelectedRow = dataGridView.SelectedRows[0].Index;

                if (SelectedRow < List.Count)
                {
                    var client = List.ElementAt(SelectedRow);
                    client.Deuda = 0;
                    searchController.SetList(List);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
