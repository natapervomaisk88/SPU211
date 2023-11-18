﻿// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Xml;

string pathToXml = @"./Library.xml";

XmlDocument doc = new XmlDocument();
XmlElement root = doc.CreateElement("Library");
doc.AppendChild(root);

XmlElement book1 = doc.CreateElement("Book");
book1.SetAttribute("genre", "horror");
root.AppendChild(book1);
XmlElement title1 = doc.CreateElement("Title");
title1.InnerText = "Осінь";

XmlElement author1 = doc.CreateElement("Author");
author1.InnerText = "Олег Степаненко";

XmlElement year1 = doc.CreateElement("Year");
year1.InnerText = 2010.ToString();

book1.AppendChild(title1);
book1.AppendChild(author1);
book1.AppendChild(year1);

doc.Save(pathToXml);