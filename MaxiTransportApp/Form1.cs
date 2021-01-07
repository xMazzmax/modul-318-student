using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;


namespace MaxiTransportApp
{
    public partial class Form1 : Form
    {
        // Membervariablen
        //
        public Transport transport = new Transport();
        public Stations stations = new Stations();

        // Inizialisiert die Form der MaxiTransportApp
        //
        public Form1()
        {
            InitializeComponent();
        }

        // Button Verbindungssuche
        //
        private void SearchConnectionButton_Click(object sender, EventArgs e)
        {
            SearchConnection(connectionListView);
        }

        // Methode Verbindungssuche
        //
        private void SearchConnection(ListView connectionListView)
        {
            AcceptButton = searchConnectionButton;

            connectionListView.Items.Clear();

            var connections = transport.GetConnections(fromComboBox.Text, toComboBox.Text);

            foreach (var connection in connections.ConnectionList)
            {
                DateTime departure = DateTime.Parse(connection.From.Departure);
                DateTime arrival = DateTime.Parse(connection.To.Arrival);

                var listViewItem = new ListViewItem();

                listViewItem.Text = null;

                listViewItem.SubItems.Add(departure.ToShortTimeString());
                listViewItem.SubItems.Add(connection.From.Station.Name);
                listViewItem.SubItems.Add(connection.From.Platform);
                listViewItem.SubItems.Add(arrival.ToShortTimeString());
                listViewItem.SubItems.Add(connection.To.Station.Name);
                listViewItem.SubItems.Add(connection.To.Platform);

                connectionListView.Items.Add(listViewItem);
            }
        }

        private void searchStationBoardButton_Click(object sender, EventArgs e)
        {
            SearchStationBoard(stationBoardListView);
        }
        // Abfahrtstafel
        //
        private void SearchStationBoard(ListView stationBoardListView)
        {
            AcceptButton = searchStationBoardButton;

            stationBoardListView.Items.Clear();

            var station = transport.GetStations(stationComboBox.Text).StationList.First();
            StationBoardRoot stationBoardRoot = transport.GetStationBoard(stationComboBox.Text, station.Id);

            foreach (var stationBoard in stationBoardRoot.Entries)
            {
                var listViewItem = new ListViewItem();

                listViewItem.Text = null;

                listViewItem.SubItems.Add(stationBoard.Stop.Departure.ToShortTimeString());
                listViewItem.SubItems.Add(stationBoard.Name);
                listViewItem.SubItems.Add(stationBoard.To);

                stationBoardListView.Items.Add(listViewItem);
            }
        }

        // Auto-suggest
        //
        private void AutoSuggest(object sender, EventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            if (input.Text.Length >= 2)
            {
                stations = transport.GetStations(input.Text);
                foreach (var station in stations.StationList)
                {
                    input.Items.Add(station.Name);
                }
            }
        }
    }
}
