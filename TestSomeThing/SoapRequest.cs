using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace TestSomeThing
{
    public class SoapRequest
    {
        public SoapRequest()
        {
            var itemNumber = "ESC-SOP-012332";

            var send = new AgileSoap.HandServiceImplService();

            var result = send.getFileNameDefault(itemNumber, "admin", "bizlink");

            foreach (string fileName in result.Where(m => m.Contains("pdf")).ToList())
            {
                byte[] pdf = send.getFileDefault(itemNumber, fileName, "admin", "bizlink");
            }
        }
    }
}
