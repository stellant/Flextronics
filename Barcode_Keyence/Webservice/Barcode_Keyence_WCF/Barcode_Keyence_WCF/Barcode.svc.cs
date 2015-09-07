using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Xml;

namespace Barcode_Keyence_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataService" in code, svc and config file together.
    public class Barcode : IBarcode
    {
        private IPEndPoint _endPoint = null;
        private Socket _clientSocket = null;
        private XmlElement _result = null; 
        public XmlElement GetData(string ipAddress,string port)
        {
            try
            {
                _endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), Convert.ToInt16(port));
                _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _clientSocket.Connect(_endPoint);
                Byte[] byteData = new Byte[1024];
                int count = _clientSocket.Receive(byteData);
                StringBuilder s = new StringBuilder();
                for (int i = 0; i < count; i++)
                    s.Append(Convert.ToChar(byteData[i]));
                _result = GetXML(s.ToString());
                _clientSocket.Close();
            }
            catch(Exception ex)
            {
                _result = GetExceptionXML(ex.ToString()); 
            }
            return _result;
        }

        private XmlElement GetXML(string s)
        {
            XmlDocument document = new XmlDocument();
            XmlNode root = document.CreateElement("Barcode");
            document.AppendChild(root);
            XmlNode dataNode = document.CreateElement("BarcodeData");
            dataNode.InnerText = s;
            root.AppendChild(dataNode);
            XmlNode dateNode = document.CreateElement("BarcodeDataDateTime");
            dateNode.InnerText = DateTime.Now.ToString();
            root.AppendChild(dateNode);
            return document.DocumentElement;
        }
        private XmlElement GetExceptionXML(string ex)
        {
            XmlDocument document = new XmlDocument();
            XmlNode root = document.CreateElement("Barcode");
            document.AppendChild(root);
            XmlNode dataNode = document.CreateElement("ExceptionData");
            dataNode.InnerText = ex;
            root.AppendChild(dataNode);
            XmlNode dateNode = document.CreateElement("ExceptionDateTime");
            dateNode.InnerText = DateTime.Now.ToString();
            root.AppendChild(dateNode);
            return document.DocumentElement;
        }
    }
}
