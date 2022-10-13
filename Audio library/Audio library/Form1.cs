using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Audio_library
{
    public partial class Form1audiolibrary : Form
    {
        public Form1audiolibrary()
        {
            InitializeComponent();
        }

        private void Form1audiolibrary_Load(object sender, EventArgs e)
        {
            button1audiolibrary_Click(sender, e);

            ToolTip nd = new ToolTip();
            nd.SetToolTip(button9newdata, "New data");
        }

        private void button1audiolibrary_Click(object sender, EventArgs e)
        {
            NumberOfCurrentButton.numb = 1;

            AudiolibraryDataSet.Audio_libraryDataTable audlibr;
            int numbofart = 0, numbofsongs = 0;

            audlibr = audio_libraryTableAdapter1.GetData();
            dataGridView1audiolibrary.DataSource = audlibr;
            dataGridView1audiolibrary.Columns[1].HeaderText = "Number of original artists/bands";
            dataGridView1audiolibrary.Columns[2].HeaderText = "Number of songs";
            dataGridView1audiolibrary.Columns[0].Visible = true;
            dataGridView1audiolibrary.Sort(dataGridView1audiolibrary.Columns[0], ListSortDirection.Ascending);
            dataGridView1audiolibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            label1numberofartistssongs.Visible = true;
            label5thethirdcolumn.Visible = true;
            label6thefourthcolumn.Visible = false;
            textBox2numberofartists.Visible = true;
            textBox3numberofsongs.Visible = true;
            textBox6thethirdcolumn.Visible = true;
            textBox7thefourthcolumn.Visible = false;
            textBox8favnumb.Visible = false;
            label2tablename.Text = "Audio library";
            label3thefirstcolumn.Text = "Category (ID)";
            label4thesecondcolumn.Text = "Number of original artists/bands";
            label5thethirdcolumn.Text = "Number of songs";

            pictureBox1favouritesphoto.Visible = false;

            comboBox1similarartistsbands.Visible = false;
            comboBox2genre.Visible = false;
            comboBox3numberofsongs.Visible = false;
            comboBox4featuring.Visible = false;
            comboBox5numberofsongs.Visible = false;

            TextBoxReadOnlyButtonPhotoEnabled();

            for (int nofart = 0; nofart < dataGridView1audiolibrary.RowCount; nofart++)
                numbofart += Convert.ToInt32(dataGridView1audiolibrary["NumbOrigArtBands", nofart].Value);
            for (int nofs = 0; nofs < dataGridView1audiolibrary.RowCount; nofs++)
                numbofsongs += Convert.ToInt32(dataGridView1audiolibrary["NumbSongs", nofs].Value);

            textBox2numberofartists.Text = numbofart.ToString();
            textBox3numberofsongs.Text = numbofsongs.ToString();
        }

        private void button2genre_Click(object sender, EventArgs e)
        {
            NumberOfCurrentButton.numb = 2;

            AudiolibraryDataSet.GenreDataTable genr;
            int numbofart = 0, numbofsongs = 0;

            genr = genreTableAdapter1.GetData();
            dataGridView1audiolibrary.DataSource = genr;
            dataGridView1audiolibrary.Columns[0].HeaderText = "Name(-s)";
            dataGridView1audiolibrary.Columns[1].HeaderText = "Number of artists/bands";
            dataGridView1audiolibrary.Columns[2].HeaderText = "Number of songs";
            dataGridView1audiolibrary.Columns[3].Visible = false;
            dataGridView1audiolibrary.Sort(dataGridView1audiolibrary.Columns[0], ListSortDirection.Ascending);
            dataGridView1audiolibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            label1numberofartistssongs.Visible = true;
            label5thethirdcolumn.Visible = true;
            label6thefourthcolumn.Visible = false;
            textBox2numberofartists.Visible = true;
            textBox3numberofsongs.Visible = true;
            textBox6thethirdcolumn.Visible = true;
            textBox7thefourthcolumn.Visible = false;
            textBox8favnumb.Visible = false;
            label2tablename.Text = "Genre";
            label3thefirstcolumn.Text = "Name(-s) (ID)";
            label4thesecondcolumn.Text = "Number of artists/bands";
            label5thethirdcolumn.Text = "Number of songs";

            pictureBox1favouritesphoto.Visible = false;

            comboBox1similarartistsbands.Visible = false;
            comboBox2genre.Visible = false;
            comboBox3numberofsongs.Visible = false;
            comboBox4featuring.Visible = false;
            comboBox5numberofsongs.Visible = false;

            TextBoxReadOnlyButtonPhotoEnabled();

            for (int nofart = 0; nofart < dataGridView1audiolibrary.RowCount; nofart++)
                numbofart += Convert.ToInt32(dataGridView1audiolibrary["NumbArtBands", nofart].Value);
            for (int nofs = 0; nofs < dataGridView1audiolibrary.RowCount; nofs++)
                numbofsongs += Convert.ToInt32(dataGridView1audiolibrary["NumbSongs", nofs].Value);

            textBox2numberofartists.Text = numbofart.ToString();
            textBox3numberofsongs.Text = numbofsongs.ToString();
        }

        private void button3musicartistband_Click(object sender, EventArgs e)
        {
            NumberOfCurrentButton.numb = 3;

            AudiolibraryDataSet._Music_artist_bandDataTable musartband;

            musartband = music_artist_bandTableAdapter1.GetData();
            dataGridView1audiolibrary.DataSource = musartband;
            dataGridView1audiolibrary.Columns[4].DisplayIndex = 4;
            dataGridView1audiolibrary.Columns[1].HeaderText = "Artist/band";
            dataGridView1audiolibrary.Columns[2].HeaderText = "Similar artist(-s)/band(-s)";
            dataGridView1audiolibrary.Columns[3].HeaderText = "Genre(-s)";
            dataGridView1audiolibrary.Columns[4].HeaderText = "Number of songs";
            dataGridView1audiolibrary.Columns[0].Visible = false;
            dataGridView1audiolibrary.Sort(dataGridView1audiolibrary.Columns[1], ListSortDirection.Ascending);
            dataGridView1audiolibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            label1numberofartistssongs.Visible = true;
            label5thethirdcolumn.Visible = true;
            label6thefourthcolumn.Visible = true;
            textBox2numberofartists.Visible = true;
            textBox3numberofsongs.Visible = true;
            textBox6thethirdcolumn.Visible = true;
            textBox7thefourthcolumn.Visible = true;
            textBox8favnumb.Visible = false;
            label2tablename.Text = "Music artist/band";
            label3thefirstcolumn.Text = "Artist/band";
            label4thesecondcolumn.Text = "Similar artist(-s)/band(-s)";
            label5thethirdcolumn.Text = "Genre(-s) (RELATED)";
            label6thefourthcolumn.Text = "Number of songs";

            pictureBox1favouritesphoto.Visible = false;

            comboBox1similarartistsbands.Visible = true;
            comboBox2genre.Visible = true;
            comboBox3numberofsongs.Visible = true;
            comboBox4featuring.Visible = false;
            comboBox5numberofsongs.Visible = false;

            TextBoxReadOnlyButtonPhotoEnabled();

            TotalRows();
        }

        private void button4composers_Click(object sender, EventArgs e)
        {
            NumberOfCurrentButton.numb = 4;

            AudiolibraryDataSet.ComposersDataTable comp;

            comp = composersTableAdapter1.GetData();
            dataGridView1audiolibrary.DataSource = comp;
            dataGridView1audiolibrary.Columns[1].HeaderText = "Name";
            dataGridView1audiolibrary.Columns[2].HeaderText = "Number of songs";
            dataGridView1audiolibrary.Columns[0].Visible = false;
            dataGridView1audiolibrary.Columns[3].Visible = false;
            dataGridView1audiolibrary.Sort(dataGridView1audiolibrary.Columns[1], ListSortDirection.Ascending);
            dataGridView1audiolibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            label1numberofartistssongs.Visible = true;
            label5thethirdcolumn.Visible = false;
            label6thefourthcolumn.Visible = false;
            textBox2numberofartists.Visible = true;
            textBox3numberofsongs.Visible = true;
            textBox6thethirdcolumn.Visible = false;
            textBox7thefourthcolumn.Visible = false;
            textBox8favnumb.Visible = false;
            label2tablename.Text = "Composers";
            label3thefirstcolumn.Text = "Name";
            label4thesecondcolumn.Text = "Number of songs";

            pictureBox1favouritesphoto.Visible = false;

            comboBox1similarartistsbands.Visible = false;
            comboBox2genre.Visible = false;
            comboBox3numberofsongs.Visible = false;
            comboBox4featuring.Visible = false;
            comboBox5numberofsongs.Visible = false;

            TextBoxReadOnlyButtonPhotoEnabled();

            TotalRows();
        }

        private void button5bloggers_Click(object sender, EventArgs e)
        {
            NumberOfCurrentButton.numb = 5;

            AudiolibraryDataSet.BloggersDataTable blogg;

            blogg = bloggersTableAdapter1.GetData();
            dataGridView1audiolibrary.DataSource = blogg;
            dataGridView1audiolibrary.Columns[1].HeaderText = "Nickname/name";
            dataGridView1audiolibrary.Columns[2].HeaderText = "Number of songs";
            dataGridView1audiolibrary.Columns[0].Visible = false;
            dataGridView1audiolibrary.Columns[3].Visible = false;
            dataGridView1audiolibrary.Sort(dataGridView1audiolibrary.Columns[1], ListSortDirection.Ascending);
            dataGridView1audiolibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            label1numberofartistssongs.Visible = true;
            label5thethirdcolumn.Visible = false;
            label6thefourthcolumn.Visible = false;
            textBox2numberofartists.Visible = true;
            textBox3numberofsongs.Visible = true;
            textBox6thethirdcolumn.Visible = false;
            textBox7thefourthcolumn.Visible = false;
            textBox8favnumb.Visible = false;
            label2tablename.Text = "Bloggers";
            label3thefirstcolumn.Text = "Nickname/name";
            label4thesecondcolumn.Text = "Number of songs";

            pictureBox1favouritesphoto.Visible = false;

            comboBox1similarartistsbands.Visible = false;
            comboBox2genre.Visible = false;
            comboBox3numberofsongs.Visible = false;
            comboBox4featuring.Visible = false;
            comboBox5numberofsongs.Visible = false;

            TextBoxReadOnlyButtonPhotoEnabled();

            TotalRows();
        }

        private void button6covers_Click(object sender, EventArgs e)
        {
            NumberOfCurrentButton.numb = 6;

            AudiolibraryDataSet.CoversDataTable cov;

            cov = coversTableAdapter1.GetData();
            dataGridView1audiolibrary.DataSource = cov;
            dataGridView1audiolibrary.Columns[1].DisplayIndex = 1;
            dataGridView1audiolibrary.Columns[2].DisplayIndex = 2;
            dataGridView1audiolibrary.Columns[3].DisplayIndex = 3;
            dataGridView1audiolibrary.Columns[1].HeaderText = "Artist/band";
            dataGridView1audiolibrary.Columns[2].HeaderText = "Featuring";
            dataGridView1audiolibrary.Columns[3].HeaderText = "Number of songs";
            dataGridView1audiolibrary.Columns[4].HeaderText = "Original(-s) artist(-s)/band(-s)";
            dataGridView1audiolibrary.Columns[0].Visible = false;
            dataGridView1audiolibrary.Columns[5].Visible = false;
            dataGridView1audiolibrary.Sort(dataGridView1audiolibrary.Columns[1], ListSortDirection.Ascending);
            dataGridView1audiolibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            label1numberofartistssongs.Visible = true;
            label5thethirdcolumn.Visible = true;
            label6thefourthcolumn.Visible = true;
            textBox2numberofartists.Visible = true;
            textBox3numberofsongs.Visible = true;
            textBox6thethirdcolumn.Visible = true;
            textBox7thefourthcolumn.Visible = true;
            textBox8favnumb.Visible = false;
            label2tablename.Text = "Covers";
            label3thefirstcolumn.Text = "Artist/band (ID)";
            label4thesecondcolumn.Text = "Featuring";
            label5thethirdcolumn.Text = "Number of songs";
            label6thefourthcolumn.Text = "Original(-s) artist(-s)/band(-s)";

            pictureBox1favouritesphoto.Visible = false;

            comboBox1similarartistsbands.Visible = false;
            comboBox2genre.Visible = false;
            comboBox3numberofsongs.Visible = false;
            comboBox4featuring.Visible = true;
            comboBox5numberofsongs.Visible = true;

            TextBoxReadOnlyButtonPhotoEnabled();

            TotalRows();
        }

        private void button7soundtracks_Click(object sender, EventArgs e)
        {
            NumberOfCurrentButton.numb = 7;

            AudiolibraryDataSet.SoundtracksDataTable soundtr;

            soundtr = soundtracksTableAdapter1.GetData();
            dataGridView1audiolibrary.DataSource = soundtr;
            dataGridView1audiolibrary.Columns[1].DisplayIndex = 1;
            dataGridView1audiolibrary.Columns[2].DisplayIndex = 2;
            dataGridView1audiolibrary.Columns[1].HeaderText = "Movie/animation/series";
            dataGridView1audiolibrary.Columns[2].HeaderText = "Artist(-s)/band(-s)";
            dataGridView1audiolibrary.Columns[3].HeaderText = "Number of songs";
            dataGridView1audiolibrary.Columns[0].Visible = false;
            dataGridView1audiolibrary.Columns[4].Visible = false;
            dataGridView1audiolibrary.Sort(dataGridView1audiolibrary.Columns[1], ListSortDirection.Ascending);
            dataGridView1audiolibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            label1numberofartistssongs.Visible = true;
            label5thethirdcolumn.Visible = true;
            label6thefourthcolumn.Visible = false;
            textBox2numberofartists.Visible = true;
            textBox3numberofsongs.Visible = true;
            textBox6thethirdcolumn.Visible = true;
            textBox7thefourthcolumn.Visible = false;
            textBox8favnumb.Visible = false;
            label2tablename.Text = "Soundtracks";
            label3thefirstcolumn.Text = "Movie/animation/series";
            label4thesecondcolumn.Text = "Artist(-s)/band(-s)";
            label5thethirdcolumn.Text = "Number of songs";

            pictureBox1favouritesphoto.Visible = false;

            comboBox1similarartistsbands.Visible = false;
            comboBox2genre.Visible = false;
            comboBox3numberofsongs.Visible = false;
            comboBox4featuring.Visible = false;
            comboBox5numberofsongs.Visible = false;

            TextBoxReadOnlyButtonPhotoEnabled();

            TotalRows();
        }

        private void button8favourites_Click(object sender, EventArgs e)
        {
            NumberOfCurrentButton.numb = 8;

            AudiolibraryDataSet.FavouritesDataTable fav;

            fav = favouritesTableAdapter1.GetData();
            dataGridView1audiolibrary.DataSource = fav;
            dataGridView1audiolibrary.Columns[5].DisplayIndex = 5;
            dataGridView1audiolibrary.Columns[0].HeaderText = "Number";
            dataGridView1audiolibrary.Columns[1].HeaderText = "Artist/band";
            dataGridView1audiolibrary.Columns[2].HeaderText = "Similar artist(-s)/band(-s)";
            dataGridView1audiolibrary.Columns[4].HeaderText = "Genre(-s)";
            dataGridView1audiolibrary.Columns[5].HeaderText = "Number of songs";
            dataGridView1audiolibrary.Columns[3].Visible = false;
            dataGridView1audiolibrary.Sort(dataGridView1audiolibrary.Columns[0], ListSortDirection.Ascending);
            dataGridView1audiolibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            label1numberofartistssongs.Visible = false;
            label5thethirdcolumn.Visible = true;
            label6thefourthcolumn.Visible = true;
            textBox2numberofartists.Visible = false;
            textBox3numberofsongs.Visible = false;
            textBox6thethirdcolumn.Visible = true;
            textBox7thefourthcolumn.Visible = true;
            textBox8favnumb.Visible = true;
            label2tablename.Text = "Favourites";
            label3thefirstcolumn.Text = "Artist/band (ID)";
            label4thesecondcolumn.Text = "Similar artist(-s)/band(-s)";
            label5thethirdcolumn.Text = "Genre(-s) (RELATED)";
            label6thefourthcolumn.Text = "Number of songs";

            pictureBox1favouritesphoto.Visible = true;

            comboBox1similarartistsbands.Visible = false;
            comboBox2genre.Visible = false;
            comboBox3numberofsongs.Visible = false;
            comboBox4featuring.Visible = false;
            comboBox5numberofsongs.Visible = false;

            TextBoxReadOnlyButtonPhotoEnabled();
        }

        private void pictureBox1favouritesphoto_Click(object sender, EventArgs e)
        {
            Bitmap favphot;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                favphot = new Bitmap(ofd.FileName);
                pictureBox1favouritesphoto.BackgroundImage = favphot;
                pictureBox1favouritesphoto.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public void TextBoxReadOnlyButtonPhotoEnabled()
        {
            textBox4thefirstcolumn.ReadOnly = true;
            textBox5thesecondcolumn.ReadOnly = true;
            textBox6thethirdcolumn.ReadOnly = true;
            textBox7thefourthcolumn.ReadOnly = true;
            textBox8favnumb.ReadOnly = true;

            button10add.Enabled = false;
            button11edit.Enabled = false;
            button12delete.Enabled = false;
            button13save.Enabled = false;

            pictureBox1favouritesphoto.Enabled = false;
        }

        public void TotalRows()
        {
            int numbofart, numbofsongs = 0;

            numbofart = dataGridView1audiolibrary.RowCount;
            for (int nofs = 0; nofs < dataGridView1audiolibrary.RowCount; nofs++)
                numbofsongs += Convert.ToInt32(dataGridView1audiolibrary["NumbSongs", nofs].Value);

            textBox2numberofartists.Text = numbofart.ToString();
            textBox3numberofsongs.Text = numbofsongs.ToString();

        }

        private void dataGridView1audiolibrary_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            switch (NumberOfCurrentButton.numb)
            {
                case 1:
                case 2:
                    textBox4thefirstcolumn.Text = dataGridView1audiolibrary[0, e.RowIndex].Value.ToString();
                    textBox5thesecondcolumn.Text = dataGridView1audiolibrary[1, e.RowIndex].Value.ToString();
                    textBox6thethirdcolumn.Text = dataGridView1audiolibrary[2, e.RowIndex].Value.ToString();
                    break;
                case 3:
                case 6:
                    textBox4thefirstcolumn.Text = dataGridView1audiolibrary[1, e.RowIndex].Value.ToString();
                    textBox5thesecondcolumn.Text = dataGridView1audiolibrary[2, e.RowIndex].Value.ToString();
                    textBox6thethirdcolumn.Text = dataGridView1audiolibrary[3, e.RowIndex].Value.ToString();
                    textBox7thefourthcolumn.Text = dataGridView1audiolibrary[4, e.RowIndex].Value.ToString();
                    break;
                case 4:
                case 5:
                    textBox4thefirstcolumn.Text = dataGridView1audiolibrary[1, e.RowIndex].Value.ToString();
                    textBox5thesecondcolumn.Text = dataGridView1audiolibrary[2, e.RowIndex].Value.ToString();
                    break;
                case 7:
                    textBox4thefirstcolumn.Text = dataGridView1audiolibrary[1, e.RowIndex].Value.ToString();
                    textBox5thesecondcolumn.Text = dataGridView1audiolibrary[2, e.RowIndex].Value.ToString();
                    textBox6thethirdcolumn.Text = dataGridView1audiolibrary[3, e.RowIndex].Value.ToString();
                    break;
                case 8:
                    string artband;
                    byte[] favphot;

                    textBox8favnumb.Text = dataGridView1audiolibrary[0, e.RowIndex].Value.ToString();
                    textBox4thefirstcolumn.Text = dataGridView1audiolibrary[1, e.RowIndex].Value.ToString();
                    textBox5thesecondcolumn.Text = dataGridView1audiolibrary[2, e.RowIndex].Value.ToString();
                    textBox6thethirdcolumn.Text = dataGridView1audiolibrary[4, e.RowIndex].Value.ToString();
                    textBox7thefourthcolumn.Text = dataGridView1audiolibrary[5, e.RowIndex].Value.ToString();

                    artband = dataGridView1audiolibrary[1, e.RowIndex].Value.ToString();
                    var dat = favouritesTableAdapter1.GetData();
                    var udat = dat.FindByArtBand(artband);
                    favphot = udat.Photo;
                    MemoryStream favphotstr = new MemoryStream(favphot);
                    Image pict = Image.FromStream(favphotstr);
                    pictureBox1favouritesphoto.BackgroundImage = pict;
                    pictureBox1favouritesphoto.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }
        }

        private void textBox2datasearch_TextChanged(object sender, EventArgs e)
        {
            int nlim = 0;

            switch (NumberOfCurrentButton.numb)
            {
                case 1:
                    button1audiolibrary_Click(sender: sender, e: e);
                    nlim = 1;
                    break;
                case 2:
                    button2genre_Click(sender: sender, e: e);
                    nlim = 1;
                    break;
                case 3:
                    button3musicartistband_Click(sender: sender, e: e);
                    nlim = 2;
                    break;
                case 4:
                    button4composers_Click(sender: sender, e: e);
                    nlim = 2;
                    break;
                case 5:
                    button5bloggers_Click(sender: sender, e: e);
                    nlim = 2;
                    break;
                case 6:
                    button6covers_Click(sender: sender, e: e);
                    nlim = 2;
                    break;
                case 7:
                    button7soundtracks_Click(sender: sender, e: e);
                    nlim = 2;
                    break;
                case 8:
                    button8favourites_Click(sender: sender, e: e);
                    nlim = 2;
                    break;
            }

            for (int m = dataGridView1audiolibrary.RowCount - 1; m >= 0; m--)
            {
                for (int n = 0; n < nlim; n++)
                {
                    dataGridView1audiolibrary.Rows[m].Selected = false;
                    if (dataGridView1audiolibrary.Rows[m].Cells[n].Value.ToString().ToLower().Contains(textBox1datasearch.Text.ToLower()))
                        dataGridView1audiolibrary.Rows[m].Selected = true;
                }
                if (dataGridView1audiolibrary.Rows[m].Selected == false)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
            }

            textBox2numberofartists.Text = dataGridView1audiolibrary.RowCount.ToString();
        }

        private void comboBox1similarartistsbands_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2genre.SelectedIndex = -1;
            comboBox3numberofsongs.SelectedIndex = -1;

            switch (NumberOfCurrentButton.numb)
            {
                case 3:
                    button3musicartistband_Click(sender: sender, e: e);
                    break;
                case 6:
                    button6covers_Click(sender: sender, e: e);
                    break;
            }
            for (int m = dataGridView1audiolibrary.RowCount - 1; m >= 0; m--)
            {
                if ((sender as ComboBox).SelectedIndex == 0 && dataGridView1audiolibrary[2, m].Value.ToString() == "")
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
                if ((sender as ComboBox).SelectedIndex == 1 && dataGridView1audiolibrary[2, m].Value.ToString() != "")
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
            }

            textBox2numberofartists.Text = dataGridView1audiolibrary.RowCount.ToString();

            TotalRows();
        }

        private void comboBox2genre_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox1similarartistsbands.SelectedIndex = -1;
            comboBox3numberofsongs.SelectedIndex = -1;

            if (comboBox2genre.SelectedIndex == -1)
                button3musicartistband_Click(sender: sender, e: e);
            else
            {
                button3musicartistband_Click(sender: sender, e: e);
                for (int m = dataGridView1audiolibrary.RowCount - 1; m >= 0; m--)
                    if (dataGridView1audiolibrary[3, m].Value.ToString() != comboBox2genre.SelectedItem.ToString())
                        dataGridView1audiolibrary.Rows.RemoveAt(m);
            }

            textBox2numberofartists.Text = dataGridView1audiolibrary.RowCount.ToString();

            TotalRows();
        }

        private void comboBox3numberofsongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1similarartistsbands.SelectedIndex = -1;
            comboBox2genre.SelectedIndex = -1;

            button3musicartistband_Click(sender: sender, e: e);
            for (int m = dataGridView1audiolibrary.RowCount - 1; m >= 0; m--)
            {
                if (comboBox3numberofsongs.SelectedIndex == 0 && Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) >= 15)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
                else if (comboBox3numberofsongs.SelectedIndex == 1 && Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) != 15)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
                else if (comboBox3numberofsongs.SelectedIndex == 2 && Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) != 25)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
                else if (comboBox3numberofsongs.SelectedIndex == 3 && Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) != 55)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
                else if (comboBox3numberofsongs.SelectedIndex == 4 && Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) <= 55)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
                else if (comboBox3numberofsongs.SelectedIndex == 5 && (Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) <= 15 || Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) == 15 || Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) == 25 || Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) == 55 || Convert.ToInt32(dataGridView1audiolibrary[4, m].Value) >= 55))
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
            }

            textBox2numberofartists.Text = dataGridView1audiolibrary.RowCount.ToString();

            TotalRows();
        }

        private void comboBox4featuring_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox5numberofsongs.SelectedIndex = -1;

            comboBox1similarartistsbands_SelectedValueChanged(sender: sender, e: e);

            TotalRows();
        }

        private void comboBox5numberofsongs_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox4featuring.SelectedIndex = -1;

            button6covers_Click(sender: sender, e: e);
            for (int m = dataGridView1audiolibrary.RowCount - 1; m >= 0; m--)
            {
                if (comboBox5numberofsongs.SelectedIndex == 0 && Convert.ToInt32(dataGridView1audiolibrary[3, m].Value) != 1)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
                else if (comboBox5numberofsongs.SelectedIndex == 1 && Convert.ToInt32(dataGridView1audiolibrary[3, m].Value) != 2)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
                else if (comboBox5numberofsongs.SelectedIndex == 2 && Convert.ToInt32(dataGridView1audiolibrary[3, m].Value) != 3)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
                else if (comboBox5numberofsongs.SelectedIndex == 3 && Convert.ToInt32(dataGridView1audiolibrary[3, m].Value) <= 3)
                    dataGridView1audiolibrary.Rows.RemoveAt(m);
            }

            textBox2numberofartists.Text = dataGridView1audiolibrary.RowCount.ToString();

            TotalRows();
        }

        private void button9newdata_Click(object sender, EventArgs e)
        {
            textBox4thefirstcolumn.ReadOnly = false;
            textBox5thesecondcolumn.ReadOnly = false;
            textBox6thethirdcolumn.ReadOnly = false;
            textBox7thefourthcolumn.ReadOnly = false;
            textBox8favnumb.ReadOnly = false;

            button10add.Enabled = true;
            button11edit.Enabled = true;
            button12delete.Enabled = true;

            pictureBox1favouritesphoto.Enabled = true;
        }

        private void button9add_Click(object sender, EventArgs e)
        {
            switch (NumberOfCurrentButton.numb)
            {
                case 1:
                    try
                    {
                        AudiolibraryDataSet.Audio_libraryDataTable al;

                        audio_libraryTableAdapter1.Insert(textBox4thefirstcolumn.Text, (short)Convert.ToInt32(textBox5thesecondcolumn.Text), (short)Convert.ToInt32(textBox6thethirdcolumn.Text));
                        al = audio_libraryTableAdapter1.GetData();
                        dataGridView1audiolibrary.DataSource = al;
                    }
                    catch
                    {
                        MessageBox.Show("The data in \"Category\" is identifier", "Print the other data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case 2:
                    try
                    {
                        AudiolibraryDataSet.GenreDataTable g;

                        genreTableAdapter1.Insert(textBox4thefirstcolumn.Text, (short)Convert.ToInt32(textBox5thesecondcolumn.Text), (short)Convert.ToInt32(textBox6thethirdcolumn.Text), "Жанр");
                        g = genreTableAdapter1.GetData();
                        dataGridView1audiolibrary.DataSource = g;
                    }
                    catch
                    {
                        MessageBox.Show("The data in \"Genre(-s)\" is identifier", "Print the other data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case 3:
                    try
                    {
                        AudiolibraryDataSet._Music_artist_bandDataTable mab;

                        music_artist_bandTableAdapter1.Insert(textBox4thefirstcolumn.Text, textBox5thesecondcolumn.Text, textBox6thethirdcolumn.Text, (short)Convert.ToInt32(textBox7thefourthcolumn.Text));
                        mab = music_artist_bandTableAdapter1.GetData();
                        dataGridView1audiolibrary.DataSource = mab;
                    }
                    catch
                    {
                        MessageBox.Show("The data in \"Genre(-s)\" is related to other tables", "Print the same data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case 4:
                    AudiolibraryDataSet.ComposersDataTable comp;

                    composersTableAdapter1.Insert(textBox4thefirstcolumn.Text, (byte)Convert.ToInt32(textBox6thethirdcolumn.Text), "Композиторы");
                    comp = composersTableAdapter1.GetData();
                    dataGridView1audiolibrary.DataSource = comp;
                    break;
                case 5:
                    AudiolibraryDataSet.BloggersDataTable b;

                    bloggersTableAdapter1.Insert(textBox4thefirstcolumn.Text, (byte)Convert.ToInt32(textBox6thethirdcolumn.Text), "Блогеры");
                    b = bloggersTableAdapter1.GetData();
                    dataGridView1audiolibrary.DataSource = b;
                    break;
                case 6:
                    try
                    {
                        AudiolibraryDataSet.CoversDataTable cov;

                        coversTableAdapter1.Insert(textBox4thefirstcolumn.Text, textBox5thesecondcolumn.Text, (byte)Convert.ToInt32(textBox6thethirdcolumn.Text), textBox7thefourthcolumn.Text, "Каверы");
                        cov = coversTableAdapter1.GetData();
                        dataGridView1audiolibrary.DataSource = cov;
                    }
                    catch
                    {
                        MessageBox.Show("The data in \"Artist/band\" is identifier", "Print the other data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case 7:
                    AudiolibraryDataSet.SoundtracksDataTable s;

                    soundtracksTableAdapter1.Insert(textBox4thefirstcolumn.Text, textBox5thesecondcolumn.Text, (byte)Convert.ToInt32(textBox6thethirdcolumn.Text), "Саундтреки");
                    s = soundtracksTableAdapter1.GetData();
                    dataGridView1audiolibrary.DataSource = s;
                    break;
                case 8:
                    try
                    {
                        AudiolibraryDataSet.FavouritesDataTable f;

                        MemoryStream ms = new MemoryStream();
                        pictureBox1favouritesphoto.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] bpict = ms.ToArray();

                        favouritesTableAdapter1.Insert((byte)Convert.ToInt32(textBox8favnumb.Text.ToString()), textBox4thefirstcolumn.Text, textBox5thesecondcolumn.Text, bpict, textBox6thethirdcolumn.Text, (short)Convert.ToInt32(textBox7thefourthcolumn.Text));
                        f = favouritesTableAdapter1.GetData();
                        dataGridView1audiolibrary.DataSource = f;
                    }
                    catch
                    {
                        MessageBox.Show("The data in \"Artist/band\" is identifier", "Print the other data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }

            button13save.Enabled = true;

            TotalRows();
        }

        private void button10edit_Click(object sender, EventArgs e)
        {
            switch (NumberOfCurrentButton.numb)
            {
                case 1:
                    string alcat = dataGridView1audiolibrary.CurrentRow.Cells[0].Value.ToString();

                    var aldat = audio_libraryTableAdapter1.GetData();
                    var aludat = aldat.FindByCategory(alcat);
                    aludat.NumbOrigArtBands = (short)Convert.ToInt32(textBox5thesecondcolumn.Text.ToString());
                    aludat.NumbSongs = (short)Convert.ToInt32(textBox6thethirdcolumn.Text.ToString());
                    audio_libraryTableAdapter1.Update(aludat);
                    break;
                case 2:
                    string gnam = dataGridView1audiolibrary.CurrentRow.Cells[0].Value.ToString();

                    var gdat = genreTableAdapter1.GetData();
                    var gudat = gdat.FindByNam(gnam);
                    gudat.NumbArtBands = (short)Convert.ToInt32(textBox5thesecondcolumn.Text.ToString());
                    gudat.NumbSongs = (short)Convert.ToInt32(textBox6thethirdcolumn.Text.ToString());
                    genreTableAdapter1.Update(gudat);
                    break;
                case 3:
                    try
                    {
                        int marid = Convert.ToInt32(dataGridView1audiolibrary.CurrentRow.Cells[0].Value);

                        var mardat = music_artist_bandTableAdapter1.GetData();
                        var marudat = mardat.FindByID(marid);
                        marudat.ArtBand = textBox4thefirstcolumn.Text.ToString();
                        marudat.RelArtBand = textBox5thesecondcolumn.Text.ToString();
                        marudat.Genre = textBox6thethirdcolumn.Text.ToString();
                        marudat.NumbSongs = (short)Convert.ToInt32(textBox7thefourthcolumn.Text.ToString());
                        music_artist_bandTableAdapter1.Update(marudat);
                    }
                    catch
                    {
                        MessageBox.Show("The data in \"Genre(-s)\" is related to other tables", "Print the same data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case 4:
                    int compid = Convert.ToInt32(dataGridView1audiolibrary.CurrentRow.Cells[0].Value);

                    var compdat = composersTableAdapter1.GetData();
                    var compudat = compdat.FindByID(compid);
                    compudat.NumbSongs = (byte)Convert.ToInt32(textBox5thesecondcolumn.Text.ToString());
                    composersTableAdapter1.Update(compudat);
                    break;
                case 5:
                    int bid = Convert.ToInt32(dataGridView1audiolibrary.CurrentRow.Cells[0].Value);

                    var bdat = bloggersTableAdapter1.GetData();
                    var budat = bdat.FindByID(bid);
                    budat.NumbSongs = (byte)Convert.ToInt32(textBox5thesecondcolumn.Text.ToString());
                    bloggersTableAdapter1.Update(budat);
                    break;
                case 6:
                    string covartband = dataGridView1audiolibrary.CurrentRow.Cells[1].Value.ToString();

                    var covdat = coversTableAdapter1.GetData();
                    var covudat = covdat.FindByArtBand(covartband);
                    covudat.Feat = textBox5thesecondcolumn.Text.ToString();
                    covudat.NumbSongs = (byte)Convert.ToInt32(textBox6thethirdcolumn.Text.ToString());
                    covudat.OrigArtBands = textBox7thefourthcolumn.Text.ToString();
                    coversTableAdapter1.Update(covudat);
                    break;
                case 7:
                    int sid = Convert.ToInt32(dataGridView1audiolibrary.CurrentRow.Cells[0].Value);

                    var sdat = soundtracksTableAdapter1.GetData();
                    var sudat = sdat.FindByID(sid);
                    sudat.ArtBand = textBox5thesecondcolumn.Text.ToString();
                    sudat.NumbSongs = (byte)Convert.ToInt32(textBox6thethirdcolumn.Text.ToString());
                    soundtracksTableAdapter1.Update(sudat);
                    break;
                case 8:
                    try
                    {
                        string fartband = dataGridView1audiolibrary.CurrentRow.Cells[1].Value.ToString();
                        byte[] bpict;

                        var fdat = favouritesTableAdapter1.GetData();
                        var fudat = fdat.FindByArtBand(fartband);
                        fudat.RelArtBand = textBox5thesecondcolumn.Text.ToString();
                        fudat.Genre = textBox6thethirdcolumn.Text.ToString();
                        fudat.NumbSongs = (short)Convert.ToInt32(textBox7thefourthcolumn.Text.ToString());
                        favouritesTableAdapter1.Update(fudat);
                        MemoryStream ms = new MemoryStream();
                        pictureBox1favouritesphoto.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bpict = ms.ToArray();
                        fudat.Photo = bpict;
                        favouritesTableAdapter1.Update(fudat);
                    }
                    catch
                    {
                        MessageBox.Show("The data in \"Genre(-s)\" is related to other tables", "Print the same data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }

            button13save.Enabled = true;
        }

        private void button11delete_Click(object sender, EventArgs e)
        {
            string str;
            int integ;

            if (MessageBox.Show("Do you wanna delete this entry", "Entry deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataGridViewRow currrow = dataGridView1audiolibrary.CurrentRow;
                switch (NumberOfCurrentButton.numb)
                {
                    case 1:
                        str = currrow.Cells[0].Value.ToString();
                        audio_libraryTableAdapter1.DeletebyCategory(str);
                        break;
                    case 2:
                        str = currrow.Cells[0].Value.ToString();
                        genreTableAdapter1.DeletebyName(str);
                        break;
                    case 3:
                        integ = Convert.ToInt32(currrow.Cells[0].Value);
                        music_artist_bandTableAdapter1.DeletebyID(integ);
                        break;
                    case 4:
                        integ = Convert.ToInt32(currrow.Cells[0].Value);
                        composersTableAdapter1.DeletebyID(integ);
                        break;
                    case 5:
                        integ = Convert.ToInt32(currrow.Cells[0].Value);
                        bloggersTableAdapter1.DeletebyID(integ);
                        break;
                    case 6:
                        str = currrow.Cells[1].Value.ToString();
                        coversTableAdapter1.DeletebyArtBand(str);
                        break;
                    case 7:
                        integ = Convert.ToInt32(currrow.Cells[0].Value);
                        soundtracksTableAdapter1.DeletebyID(integ);
                        break;
                    case 8:
                        str = currrow.Cells[1].Value.ToString();
                        favouritesTableAdapter1.DeletebyArtBand(str);
                        break;
                }
                dataGridView1audiolibrary.Rows.RemoveAt(currrow.Index);

                button13save.Enabled = true;
            }
            TotalRows();
        }

        private void button12save_Click(object sender, EventArgs e)
        {
            string path, fpath, rpath;

            path = Application.StartupPath;
            fpath = path + @"\Audio library.mdb";
            rpath = path.Remove(path.Length - 10);
            rpath = rpath + @"\Audio library.mdb";
            File.Delete(rpath);
            File.Copy(fpath, rpath);

            MessageBox.Show("Your data has been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            button10add.Enabled = false;
            button11edit.Enabled = false;
            button12delete.Enabled = false;
            button13save.Enabled = false;
        }

        public static class NumberOfCurrentButton
        {
            public static int numb;
        }

        private void textBox8favnumb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox4thefirstcolumn.Focus();
        }

        private void textBox4thefirstcolumn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox5thesecondcolumn.Focus();
        }

        private void textBox5thesecondcolumn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox6thethirdcolumn.Focus();
        }

        private void textBox6thethirdcolumn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox7thefourthcolumn.Focus();
        }

        private void textBox5thesecondcolumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (NumberOfCurrentButton.numb)
            {
                case 1:
                case 2:
                case 4:
                case 5:
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                        e.Handled = true;
                    break;
            }
        }

        private void textBox6thethirdcolumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (NumberOfCurrentButton.numb)
            {
                case 1:
                case 2:
                case 6:
                case 7:
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                        e.Handled = true;
                    break;
            }
        }

        private void textBox7thefourthcolumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (NumberOfCurrentButton.numb)
            {
                case 3:
                case 8:
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                        e.Handled = true;
                    break;
            }
        }

        private void textBox8favnumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
