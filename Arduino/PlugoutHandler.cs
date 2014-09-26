using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Xml;
using System.Net;

namespace lucidcode.LucidScribe.Plugout.Arduino
{
  public class PlugoutHandler : lucidcode.LucidScribe.Interface.LucidPlugoutBase
  {

    private Boolean Failed = false;
    private Boolean On = false;

    public static String ArduinoPort = "COM1";
    public static String ArduinoDelay = "1";
    public static String ArduinoOn = "1";
    public static String ArduinoOff = "0";

    public override string Name
    {
      get { return "Arduino"; }
    }

    public override bool Initialize()
    {
      PortForm formPort = new PortForm();
      if (formPort.ShowDialog() == DialogResult.OK)
      {
        ArduinoPort = formPort.ArduinoPort;
        ArduinoDelay = formPort.ArduinoDelay;
        ArduinoOn = formPort.ArduinoOn;
        ArduinoOff = formPort.ArduinoOff;

        return true;
      }
      return false;
    }

    public override void Dispose()
    {
      return;
    }

    public override void Trigger()
    {
      try
      {
        if (Failed) return;

        SerialPort arduinoPort = new SerialPort();
        arduinoPort.PortName = ArduinoPort;
        arduinoPort.BaudRate = 9600;
        arduinoPort.Open();

        arduinoPort.WriteLine(ArduinoOn);

        int arduinoDelay = Convert.ToInt32(ArduinoDelay) * 60000;
        Thread.Sleep(arduinoDelay);

        arduinoPort.WriteLine(ArduinoOff);

        arduinoPort.Close();
        arduinoPort.Dispose();
        
      }
      catch (Exception ex)
      {
        Failed = true;
        MessageBox.Show(ex.Message, "Arduino Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }

}
