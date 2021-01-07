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
        //Membervariable
        public Transport transport = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void Connection(ListView connectionListView)
        {
            connectionListView.Items.Clear();

            Connections connections = transport.GetConnections(fromTextBox.Text, toTextBox.Text);

            foreach (Connection connection in connections.ConnectionList)
            {
                DateTime departure = DateTime.Parse(connection.From.Departure);
                DateTime arrival = DateTime.Parse(connection.To.Arrival);
                try
                {
                    ListViewItem connection1 = new ListViewItem();
                    connection1.Text = null;
                    connection1.SubItems.Add(departure.ToShortTimeString());
                    connection1.SubItems.Add(connection.From.Station.Name);
                    connection1.SubItems.Add(connection.From.Platform);
                    connection1.SubItems.Add(arrival.ToShortTimeString());
                    connection1.SubItems.Add(connection.To.Station.Name);
                    connection1.SubItems.Add(connection.To.Platform);

                    connectionListView.Items.Add(connection1);
                }
                catch
                {

                }
            }
        }

        private void SearchConnectionButton_Click(object sender, EventArgs e)
        {
            Connection(connectionListView);
        }


        /*
        var connections = transport.GetConnections(fromTextBox.Text, toTextBox.Text);
        var from = connections.ConnectionList[0].From.Departure;
        var to = connections.ConnectionList[0].To.Arrival;
        connectionGrid.Rows.Add(new[]
            {
                fromTextBox.Text,
                toTextBox.Text
            });
            //var transport = new Transport();
            //var connections = transport.GetConnections(fromTextBox.Text, toTextBox.Text);
            //var from = connections.ConnectionList[0].From.Departure;
            //var to = connections.ConnectionList[0].To.Arrival;
        */
    }
}
