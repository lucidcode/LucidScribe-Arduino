using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml;
using System.IO;

namespace lucidcode.LucidScribe.Plugout.Arduino
{
    public partial class PortForm : Form
    {
        public static string m_strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\lucidcode\\Lucid Scribe\\";
        public String SelectedPort = "";
        private Boolean loaded = false;

        public String ArduinoPort = "COM1";
        public String ArduinoDelay = "1";
        public String ArduinoOn = "1";
        public String ArduinoOff = "0";

        public PortForm()
        {
            InitializeComponent();
        }

        private void PortForm_Load(object sender, EventArgs e)
        {
          LoadPortList();
          LoadSettings();
          loaded = true;
        }

        private void LoadPortList()
        {
          lstPorts.Clear();
          foreach (string strPort in SerialPort.GetPortNames())
          {
            String strPortName = strPort;
            strPortName = strPortName.Replace("a", "");
            strPortName = strPortName.Replace("b", "");
            strPortName = strPortName.Replace("c", "");
            strPortName = strPortName.Replace("d", "");
            strPortName = strPortName.Replace("e", "");
            strPortName = strPortName.Replace("f", "");
            strPortName = strPortName.Replace("g", "");
            strPortName = strPortName.Replace("h", "");
            strPortName = strPortName.Replace("i", "");
            strPortName = strPortName.Replace("j", "");
            strPortName = strPortName.Replace("k", "");
            strPortName = strPortName.Replace("l", "");
            strPortName = strPortName.Replace("m", "");
            strPortName = strPortName.Replace("n", "");
            strPortName = strPortName.Replace("o", "");
            strPortName = strPortName.Replace("p", "");
            strPortName = strPortName.Replace("q", "");
            strPortName = strPortName.Replace("r", "");
            strPortName = strPortName.Replace("s", "");
            strPortName = strPortName.Replace("t", "");
            strPortName = strPortName.Replace("u", "");
            strPortName = strPortName.Replace("v", "");
            strPortName = strPortName.Replace("w", "");
            strPortName = strPortName.Replace("x", "");
            strPortName = strPortName.Replace("y", "");
            strPortName = strPortName.Replace("z", "");

            ListViewItem lstItem = new ListViewItem(strPortName);
            lstItem.ImageIndex = 0;
            lstPorts.Items.Add(lstItem);
          }
        }

        private void LoadSettings()
        {
          if (!File.Exists(m_strPath + "Plugouts\\Arduino.User.lsd"))
          {
            String defaultSettings = "<LucidScribeData>";
            defaultSettings += "<Plugin>";
            defaultSettings += "</Plugin>";
            defaultSettings += "</LucidScribeData>";
            File.WriteAllText(m_strPath + "Plugouts\\Arduino.User.lsd", defaultSettings);
          }

          XmlDocument xmlSettings = new XmlDocument();
          xmlSettings.Load(m_strPath + "Plugouts\\Arduino.User.lsd");

          if (xmlSettings.DocumentElement.SelectSingleNode("//ArduinoPort") != null)
          {
            ArduinoPort = xmlSettings.DocumentElement.SelectSingleNode("//ArduinoPort").InnerText;
            foreach (ListViewItem listItem in lstPorts.Items)
            {
              if (listItem.Text == ArduinoPort)
              {
                listItem.Font = new Font(listItem.Font, FontStyle.Bold);
              }
            }
          }

          if (xmlSettings.DocumentElement.SelectSingleNode("//ArduinoOn") != null)
          {
            txtArduinoOn.Text = xmlSettings.DocumentElement.SelectSingleNode("//ArduinoOn").InnerText;
            ArduinoOn = xmlSettings.DocumentElement.SelectSingleNode("//ArduinoOn").InnerText;
          }

          if (xmlSettings.DocumentElement.SelectSingleNode("//ArduinoOff") != null)
          {
            txtArduinoOff.Text = xmlSettings.DocumentElement.SelectSingleNode("//ArduinoOff").InnerText;
            ArduinoOff = xmlSettings.DocumentElement.SelectSingleNode("//ArduinoOff").InnerText;
          }

          if (xmlSettings.DocumentElement.SelectSingleNode("//ArduinoDelay") != null)
          {
            cmbArduinoDelay.Text = xmlSettings.DocumentElement.SelectSingleNode("//ArduinoDelay").InnerText;
            ArduinoDelay = xmlSettings.DocumentElement.SelectSingleNode("//ArduinoDelay").InnerText;
          }
        }

        private void SaveSettings()
        {
          String settingsXML = "<LucidScribeData>";
          settingsXML += "<Plugin>";

          settingsXML += "<ArduinoPort>" + SelectedPort + "</ArduinoPort>";
          settingsXML += "<ArduinoDelay>" + cmbArduinoDelay.Text + "</ArduinoDelay>";
          settingsXML += "<ArduinoOn>" + txtArduinoOn.Text + "</ArduinoOn>";
          settingsXML += "<ArduinoOff>" + txtArduinoOff.Text + "</ArduinoOff>";

          settingsXML += "</Plugin>";
          settingsXML += "</LucidScribeData>";
          File.WriteAllText(m_strPath + "Plugouts\\Arduino.User.lsd", settingsXML);
        }

        private void lstPlaylists_MouseMove(object sender, MouseEventArgs e)
        {
            if (lstPorts.GetItemAt(e.X, e.Y) != null)
            {
                lstPorts.Cursor = Cursors.Hand;
            }
            else
            {
                lstPorts.Cursor = Cursors.Default;
            }
        }

        private void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPorts.SelectedItems.Count > 0)
            {
                SelectedPort = lstPorts.SelectedItems[0].Text;
                SaveSettings();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
