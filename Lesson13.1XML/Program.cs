﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Xml;
using System.Text;


List<Product> listProduct = new List<Product>() {
    new Product ("Acer", "Суперигровой", 300000),
    new Product ("Asus", "Офис унылый", 30000),
    new Product ("Apple", "Престижный донельзя", 200000),

};
List<Product> listProduct2;
Order ord=new Order(listProduct);
MyXML.SaveXML("test.xml", ord);
MyXML.XMLLoad("test.xml");
listProduct2 = MyXML.XMLLoad("test.xml")
class Order
{
    static Random random = new Random();
    public int _id;
    public DateTime OrderDate { get; set; }
    public List<Product> _products = new List<Product>();
    public Order(List<Product> Products)
    {
        _products = Products;
        _id = DateTime.Now.Millisecond * random.Next(100);
    }
}
class Product
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public Product(string name, string desc, int price)
    {
        Name = name;
        Description = desc;
        Price = price;
    }
    public override string ToString()
    {
        return $"{Name} + {Description} + {Price}";
    }
}
class MyXML
{
    public static void SaveXML (string path, Order ord)
        {
            XmlTextWriter? xmltw = null;
            try
            {
                xmltw = new XmlTextWriter("test.xml", Encoding.Unicode);
                xmltw.Formatting = Formatting.Indented;
                xmltw.Indentation = 4;
                xmltw.WriteStartDocument();
                xmltw.WriteStartElement("orders");
                foreach (Product product in ord._products)
                {
                    xmltw.WriteStartElement("Product");
                    xmltw.WriteAttributeString("name", product.Name);
                    xmltw.WriteElementString("description", product.Description);
                    xmltw.WriteElementString("price", product.Price.ToString());
                    xmltw.WriteEndElement();

                }
                xmltw.WriteEndElement();
                xmltw.WriteEndDocument();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (xmltw != null)
                    xmltw.Close();
            }
        }
    public static void XMLLoad(string path)
    {
        XmlTextReader? xmltr = null;
        List<Product> products = new List<Product>();
        Product prod = new Product("", "", 0);
        try
        {
            xmltr = new XmlTextReader(path);
            int price = 0;
            //bool productExist=false;
            while (xmltr.Read())
            {
                if (xmltr.NodeType == XmlNodeType.Element && xmltr.Name == "Product")
                {
                    prod = new Product("", "", 0);
                    xmltr.MoveToAttribute(0);
                    prod = xmltr.Value;
                }
                if (xmltr.NodeType == XmlNodeType.Element && xmltr.Name == "description")
                {
                    xmltr.MoveToContent();
                    prod = xmltr.ReadString();
                }
                if (xmltr.NodeType == XmlNodeType.Element && xmltr.Name == "price")
                {
                    xmltr.MoveToContent();
                    price = Int32.Parse(xmltr.ReadString());
                }
                if (xmltr.NodeType == XmlNodeType.EndElement && xmltr.Name == "Product")
                {
                    prod.Name = name;
                    prod.Description = description;
                    prod.Price = price;
                    if (prod.Name.Length > 1 && prod.Description.Length > 1 && prod.Price > 0)
                    {
                        products.Add(prod);
                    }
                    else
                    {
                        Console.WriteLine("Error read xml-file");
                        Console.WriteLine(prod.ToString());
                    }
                }
            }
            foreach (Product product in products)
                {
                Console.WriteLine(product.ToString());
                }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (xmltr != null)
                xmltr.Close();
        }
    }
    public static Order XMLLoad(string path, Order ord)
    {
        XmlDocument xdoc = new XmlDocument();
        if (path != null)  xdoc.Load(path);
        
        foreach(XmlDocument xel in xdoc.GetElementsByTagName("Product"))
        {
            ord._products.Add(new Product (
            xel.GetAttribute("name"),
            xel.GetElementsByTagName("description")[0].InnerText,
            Int32.Parse(xel.GetElementsByTagName("price")[0].InnerText)
                )
                );
        }

        return ord;
    }
}
