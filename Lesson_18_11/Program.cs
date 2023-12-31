﻿// See https://aka.ms/new-console-template for more information
using Lesson_18_11.Models;
using System.Xml;

string pathToXml = @"./Library.xml";
XmlDocument doc = new XmlDocument();
doc.Load(pathToXml);

XmlElement root = doc.DocumentElement;
List<Book> listBooks = new List<Book>();    
foreach(XmlElement bookEl in root.GetElementsByTagName("Book"))
{
    Book book = new Book();
    book.Genre = bookEl.GetAttribute("genre");
    foreach(XmlElement childEl in bookEl.ChildNodes)
    {
        switch(childEl.Name)
        {
            case "Title":
                book.Title = childEl.InnerText;
                break;
            case "Author":
                book.Author = childEl.InnerText;
                break;
            case "Year":
                book.Year = Convert.ToInt32(childEl.InnerText);
                break;
        }
    }
    listBooks.Add(book);
}
if(listBooks.Count>0)
{
    foreach(var b in listBooks)
    {
        Console.WriteLine(b);
    }
}




//SeederBook sb = new SeederBook();
//FormedXml fx = new FormedXml();

//List<Book> listBook = new List<Book>();
//listBook.Add(sb.GetBook());
//listBook.Add(sb.GetBook());

//XmlDocument doc = new XmlDocument();
//XmlElement root = doc.CreateElement("Library");
//doc.AppendChild(root);
//fx.CreateBooks(doc, root, listBook);

//doc.Save(pathToXml);