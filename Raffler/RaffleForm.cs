using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raffler.Models;
using Raffler.Services;

namespace Raffler
{
    public partial class RaffleForm : Form
    {
        private readonly ICsvReader<List<CsvItemModel>> _csvReader;
        private string _csvLocation;

        public RaffleForm(ICsvReader<List<CsvItemModel>> csvReader)
        {
            _csvReader = csvReader;
            InitializeComponent();

            Init();
        }

        #region Events

        private void BtnOpenCsv_Click(object sender, EventArgs e)
        {
            OpenCsv();
        }

        private void btnStartRaffle_Click(object sender, EventArgs e)
        {
            InitRaffle();
        }

        #endregion

        #region Methods

        private void Init()
        {
            btnStartRaffle.Enabled = false;

            // Visibility
            listViewWinners.Visible = false;
            lblStartRaffle.Visible = true;

            listViewWinners.View = View.Details;
            listViewWinners.GridLines = true;

            listViewWinners.Columns.Add("Winner");
            listViewWinners.Columns.Add("Basket");
            listViewWinners.Columns.Add("Basket Entries");

            listViewWinners.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void OpenCsv()
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    textBoxOpenedFile.Text = file;
                    btnStartRaffle.Enabled = true;
                    _csvLocation = file;
                }
                catch (IOException)
                {
                    btnStartRaffle.Enabled = false;
                }
            }
        }

        private void InitRaffle()
        {
            btnStartRaffle.Enabled = false;

            if (string.IsNullOrEmpty(_csvLocation))
            {
                MessageBox.Show("You must choose CSV location");
                return;
            }

            var csvList = _csvReader.ReadCsv(_csvLocation);

            StartRaffle(csvList);
        }

        private void StartRaffle(List<CsvItemModel> csvList)
        {
            lblStartRaffle.Visible = false;

            listViewWinners.Items.Clear();

            var basketNames = csvList.Select(x => new NameBasketModel
            {
                Name = x.Title,
                Baskets = GetBasketList(x)
            });

            var random = new Random();

            for (int i = 0; i < 15; i++)
            {
                var raffleNames = new List<String>();
                foreach (var nameBasket in basketNames)
                {
                    for (int j = 0; j < nameBasket.Baskets[i]; j++)
                    {
                        raffleNames.Add(nameBasket.Name);
                    }
                }

                var randomNext = random.Next(1, raffleNames.Count);

                var winner = raffleNames[randomNext];
                var winnerEntries = raffleNames.Count(x => x == winner);

                listViewWinners.Items.Add(new ListViewItem(new string[]
                    {winner, $"Basket {i + 1}", winnerEntries.ToString()}));
            }

            listViewWinners.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewWinners.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewWinners.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);

            listViewWinners.Visible = true;
            btnStartRaffle.Enabled = true;
        }

        private List<int> GetBasketList(CsvItemModel x)
        {
            var list = new List<int>();
            try
            {
                for (int i = 1; i <= 15; i++)
                {
                    var value = (int?) x[$"Basket{i}"];
                    list.Add(value ?? 0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Fatal Error: Check in CSV file are there baskets from 1 to the 18");
                Application.Exit();
            }

            return list;
        }

        #endregion

    }
}
