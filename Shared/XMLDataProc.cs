﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace DND
{
    public static class XMLDataProc
    {
        public static void WriteList(string path, object data)
        {
            var writer = new XmlSerializer(data.GetType());
            var wfile = new StreamWriter(path + ".xml");
            writer.Serialize(wfile, data);
            writer = null;
            wfile.Close();
            wfile = null;
        }
        public static object ReadList(string path, object data)
        {
            XmlSerializer reader = new XmlSerializer(data.GetType());
            StreamReader file = new StreamReader(path + ".xml");
            object output = reader.Deserialize(file);
            file.Close();
            return output;
        }
    }
}