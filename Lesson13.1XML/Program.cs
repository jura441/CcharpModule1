// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Xml;
using System.Text;
List<Product> listProduct = new List<Product>() {
    new Product ("Acer", "Суперигровой", 300000),
    new Product ("Asus", "Офис унылый", 30000),
    new Product ("Apple", "Престижный донельзя", 200000),

};
Order ord=new Order(listProduct);
try
{
    XmlTextWriter xmltw = new XmlTextWriter("test.xml", Encoding.Unicode);
    xmltw.Formatting = Formatting.Indented;
    xmltw.Indentation = 4;
    xmltw.WriteStartDocument();
    xmltw.WriteStartElement("orders");
    foreach(Product product in ord._products)
    {
        xmltw.WriteStartElement("product");
        xmltw.WriteAttributeString("name", product.Name);
        xmltw.WriteElementString("description", product.Description);
        xmltw.WriteElementString("price", product.Price.ToString());
    xmltw.WriteEndElement();
              
    }
    xmltw.WriteEndElement();
    xmltw.WriteEndDocument();
}
catch(FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    if()
        
}
class Order
{
    static Random random = new Random();
    public int _id;
    public DateTime OrderDate { get; set; }
    public List<Product> _products=new List<Product>();
    public Order(List<Product> Products)
    {
        _products = Products;
        _id = DateTime.Now.Millisecond * random.Next(100);
    }
}
class Product
{
    int _id;
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public Product(string name, string desc, int price)
    {
        Name = name;
        Description = desc;
        Price = price;
    }
}