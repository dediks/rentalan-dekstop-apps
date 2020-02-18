using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RentalMobil
{
    public partial class FormDataMasterMobil : Form
    {
        public FormDataMasterMobil()
        {
            InitializeComponent();
        }

        private void FormDataMasterMobil_Load(object sender, EventArgs e)
        {
            loadDataMobil();

        }

        public void loadDataMobil()
        {
            this.carsTableAdapter.Fill(this.db_rental_mobilDataSet2.cars);
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            tambahDataMobil();
        }

        public void clearTxts()
        {
            //Clear Field Content
            tb_nama_mobil.Text = "";
            tb_vendor_mobil.Text = "";
            tb_transmisi_mobil.Text = "";
            tb_harga_mobil.Text = "";
            tb_bagasi_mobil.Text = "";
            tb_deskripsi_mobil.Text = "";
        }

        private void tb_browse_gambar_mobil_Click(object sender, EventArgs e)
        {
            OpenFileDialog gambar_mobil = new OpenFileDialog();
            gambar_mobil.Title = "Pilih gambar mobil";
            gambar_mobil.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
            gambar_mobil.Multiselect = false;

            if (gambar_mobil.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.gambar_mobil.ImageLocation = gambar_mobil.FileName;
            }
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dataMobil4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInputDataMobil.Hide();
            panelEditMobil.Hide();
            panelListMobil.Show();


            loadDataMobil();
        }

        private void dg_mobil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void updateDataMobil(int id)
        {
            String nama = tb_edit_nama_mobil.Text;
            String vendor =  tb_edit_vendor_mobil.Text;
            String transmisi = tb_edit_transmisi_mobil.Text;
            String harga_in_string = tb_edit_harga_mobil.Text;
            String bagasi = tb_edit_bagasi_mobil.Text;
            String deskripsi = tb_edit_deskripsi_mobil.Text;

            if (nama != "" && vendor != "" && bagasi != "" && harga_in_string != "" && bagasi != "" && deskripsi != "")
            {
                Decimal harga = Decimal.Parse(harga_in_string);

                try
                {
                    using (db_rental_mobilEntities context = new db_rental_mobilEntities())
                    {
                        var car = (from a in context.cars where a.id_mobil == id select a).Single();

                        car.nama = nama;
                        car.vendor = vendor;
                        car.transmisi = transmisi;
                        car.harga_sewa = harga;
                        car.bagasi = bagasi;
                        car.deskripsi = deskripsi;
                        car.image = ConvertFiletoByte(this.pb_edit_foto_mobil.ImageLocation);

                        context.SaveChanges();

                        MessageBox.Show("Mobil berhasil ditambhkan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        panelEditMobil.Hide();
                        panelListMobil.Show();

                    }
                }
                catch
                {
                    MessageBox.Show("Gagal mengedit mobil!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Boolean deleteDataMobil(int id)
        {
            try
            {
                using (db_rental_mobilEntities context = new db_rental_mobilEntities())
                {
                    var car_deleted = (from car in context.cars where car.id_mobil == id select car).Single();
                    context.cars.Remove(car_deleted);
                    context.SaveChanges();

                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Gagal menghapus mobil!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private byte[] ConvertFiletoByte(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);

            return data;
        }

        private Image ConverByteToImage(byte[] photo)
        {
            Image newImage;

            using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newImage = Image.FromStream(ms, true); 
            }

            return newImage;
        }
        public void tambahDataMobil()
        {
            String nama = tb_nama_mobil.Text;
            String vendor = tb_vendor_mobil.Text;
            String transmisi = tb_transmisi_mobil.Text;
            String harga_mobil_string = tb_harga_mobil.Text;
            String bagasi = tb_bagasi_mobil.Text;
            String deskripsi = tb_deskripsi_mobil.Text;


            if (nama != "" && vendor != "" && bagasi != "" && harga_mobil_string != "" && bagasi != "" && deskripsi != "")
            {
                Decimal harga = Decimal.Parse(harga_mobil_string);

                try
                {
                    using (db_rental_mobilEntities context = new db_rental_mobilEntities())
                    {
                        var mobil = new cars();

                        mobil.nama = nama;
                        mobil.vendor = vendor;
                        mobil.transmisi = transmisi;
                        mobil.harga_sewa = harga;
                        mobil.bagasi = bagasi;
                        mobil.deskripsi = deskripsi;
                        mobil.image = ConvertFiletoByte(this.gambar_mobil.ImageLocation);


                        context.cars.Add(mobil);
                        context.SaveChanges();

                        MessageBox.Show("Mobil berhasil ditambhkan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearTxts();

                    }
                }
                catch
                {
                    MessageBox.Show("Gagal menambahkan mobil!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ada field kosong!. Mohon isi semua borang", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_mobil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus? ", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int index = dg_mobil.SelectedRows[0].Index;
                int id = (int)dg_mobil.SelectedRows[0].Cells[5].Value;
                
                if (deleteDataMobil(id))
                {
                    dg_mobil.Rows.RemoveAt(index);
                };
            }
        }

        private void btn_update_mobil_Click(object sender, EventArgs e)
        {           
            if (dg_mobil.SelectedRows.Count > 0)
            {
                panelListMobil.Hide();
                panelInputDataMobil.Hide();
                panelEditMobil.Show();

                tb_edit_nama_mobil.Text = dg_mobil.SelectedRows[0].Cells[0].Value.ToString();
                tb_edit_vendor_mobil.Text = dg_mobil.SelectedRows[0].Cells[1].Value.ToString();
                tb_edit_transmisi_mobil.Text = dg_mobil.SelectedRows[0].Cells[3].Value.ToString();
                tb_edit_harga_mobil.Text = dg_mobil.SelectedRows[0].Cells[2].Value.ToString();
                tb_edit_bagasi_mobil.Text = dg_mobil.SelectedRows[0].Cells[7].Value.ToString();
                tb_edit_deskripsi_mobil.Text = dg_mobil.SelectedRows[0].Cells[8].Value.ToString();
                this.pb_edit_foto_mobil.Image = ConverByteToImage((byte[])dg_mobil.SelectedRows[0].Cells[4].Value);
            }
            else {
                MessageBox.Show("Anda Belum Memilih!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
}
       
        private void inputMobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelListMobil.Hide();
            panelEditMobil.Hide();
            panelInputDataMobil.Show();
        }

        private void panelEditMobil_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelListMobil_Paint(object sender, PaintEventArgs e)
        {
            dg_mobil.AllowUserToAddRows = false;
        }

        private void carsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_edit_Click(object sender, EventArgs e)
        {
            int id_mobil = (int)dg_mobil.SelectedRows[0].Cells[5].Value;
            updateDataMobil(id_mobil);
            loadDataMobil();
        }

        private void menuStripDataMasterMobil_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_edit_browse_foto_mobil_Click(object sender, EventArgs e)
        {
            OpenFileDialog gambar_mobil_edit = new OpenFileDialog();
            gambar_mobil_edit.Title = "Pilih gambar mobil";
            gambar_mobil_edit.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
            gambar_mobil_edit.Multiselect = false;

            if (gambar_mobil_edit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pb_edit_foto_mobil.ImageLocation = gambar_mobil_edit.FileName;
            }
        }
    }
}
