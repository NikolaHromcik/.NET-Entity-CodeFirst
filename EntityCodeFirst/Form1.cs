using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Data.Entity;

namespace EntityCodeFirst
{
    public partial class Form1 : Form
    {
        EntityBaza baza = new EntityBaza();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            GridKlijent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridServis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            GridKlijent.DataSource = baza.Klijents.ToList<Klijent>();
            GridServis.DataSource = baza.Services.ToList<Service>();
            Cursor = Cursors.Default;

        }

        private void btnInsertKlijent_Click(object sender, EventArgs e)
        {
            Klijent novKlijent = new Klijent { ImeKlijenta = txtKlijentID.Text, RegistarskiBroj = txtRegBroj.Text, Kontakt = txtKontakt.Text, DodatniKomentar = txtKomentar.Text };

            baza.Klijents.Add(novKlijent);

            
            try
            {
                int ret = baza.SaveChanges();
                MessageBox.Show("Snimljeno " + ret.ToString() + " slogova");
            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }
                
                baza.Dispose();
                baza = new EntityBaza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnInsertServis_Click(object sender, EventArgs e)
        {
            Service novServis = new Service { KlijentID = Convert.ToInt32(txtKlijentID2.Text), DatumServisa = dateServis.Value, OpisUsluge = txtOpisUsluge.Text   };

            baza.Services.Add(novServis);


            try
            {
                int ret = baza.SaveChanges();
                MessageBox.Show("Snimljeno " + ret.ToString() + " slogova");
            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }

                baza.Dispose();
                baza = new EntityBaza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;


            GridKlijent.DataSource = baza.Klijents.ToList<Klijent>();
            GridServis.DataSource = baza.Services.ToList<Service>();
            Cursor = Cursors.Default;
        }

        private void btnUpdateKlijent_Click(object sender, EventArgs e)
        {
            try 
            { 
            
            int idKlijenta = (int)GridKlijent.SelectedRows[0].Cells[0].Value;
            var mojKlijent = baza.Klijents.Where(a=> a.KlijentID.Equals(idKlijenta)).FirstOrDefault();

                mojKlijent.ImeKlijenta = txtKlijentID.Text;
                mojKlijent.RegistarskiBroj = txtRegBroj.Text;
                mojKlijent.Kontakt = txtKontakt.Text;
                mojKlijent.DodatniKomentar = txtKomentar.Text;
                baza.SaveChanges();
                MessageBox.Show("uspesan update");

            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }

                baza.Dispose();
                baza = new EntityBaza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnDeleteKlijent_Click(object sender, EventArgs e)
        {
            int idKlijenta = (int)GridKlijent.SelectedRows[0].Cells[0].Value;
            //var x = baza.Klijents.Where(a => a.KlijentID == idKlijenta);

            var i = baza.Klijents.Find(idKlijenta);
            try
            {
                baza.Entry(i).State = EntityState.Deleted;
                baza.SaveChanges();
                MessageBox.Show("Uspesno obrisan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdateServis_Click(object sender, EventArgs e)
        {
            try
            {   
                int idServisa = (int)GridServis.SelectedRows[0].Cells[0].Value;
                var mojServis = baza.Services.Where(a => a.ServisID.Equals(idServisa)).FirstOrDefault();

                mojServis.KlijentID = Convert.ToInt32(txtKlijentID2.Text);
                mojServis.DatumServisa = dateServis.Value;
                mojServis.OpisUsluge = txtOpisUsluge.Text;
                baza.SaveChanges();
                MessageBox.Show("uspesan update");
            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }

                baza.Dispose();
                baza = new EntityBaza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDeleteServis_Click(object sender, EventArgs e)
        {
            int idServisa = (int)GridServis.SelectedRows[0].Cells[0].Value;
            //var x = baza.Klijents.Where(a => a.KlijentID == idKlijenta);

            var i = baza.Services.Find(idServisa);
            try
            {
                baza.Entry(i).State = EntityState.Deleted;
                baza.SaveChanges();
                MessageBox.Show("Uspesno obrisan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnKlijentiServisa_Click(object sender, EventArgs e)
        {
            try
            {
                int idFiltera = Convert.ToInt32(txtFilter.Text);

                // GridFilter.DataSource = baza.Services.ToList<Service>().Where(a => a.KlijentID == idFiltera);
                Klijent SelKlijent = baza.Klijents.FirstOrDefault<Klijent>(a => a.KlijentID == idFiltera);
                GridFilter.DataSource = SelKlijent.Servisi;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
    }
}
