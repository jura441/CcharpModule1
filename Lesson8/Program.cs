// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


List<AnyDocument> list = new List<AnyDocument>() 
{ new AnyDocument("First", "pdf"),
new AnyDocument("First", "txt"),
new AnyDocument("First", "doc"),
new AnyDocument("First", "xlsx"),
new AnyDocument("First", "csv"),
};
WorkWithDocuments wwd=new WorkWithDocuments();
DelegateWorkDelegate dwd = null;
//AnyDocument pdf = new AnyDocument("First", "pdf");

foreach (AnyDocument file in list)
{
    dwd = null;
    dwd += WorkWithDocuments.OutInfoDOC;
    file.ChangeType("doc");
    wwd.DocumentsToDOC(dwd);
   
}
    wwd.Start();

//string[] massiveFiles=new string[10] {"first.doc", "second.doc", "third.txt", "four.pdf", " five.xlsx", "six.txt", 
//"seven.pdf", "eight.xlsx", "nine.csv", "ten.csv"} ;
//DelegateWorkDelegate? dwd = null;
//foreach (string file in massiveFiles)
//{
//    dwd = null;
//    string[] filemassiv = file.Split('.');
//    switch(filemassiv[1])
//    {
//        case "doc":dwd += WorkWithDocuments.OutInfoDOC; dwd(file); break;
//        case "txt":dwd += WorkWithDocuments.OutInfoTXT; dwd(file); break;
//        case "pdf":dwd+= WorkWithDocuments.OutInfoPDF; dwd(file); break;
//        case "xlsx":dwd+= WorkWithDocuments.OutInfoXLSX; dwd(file); break;
//        case "csv":dwd+= WorkWithDocuments.OutInfoCSV; dwd(file); break;
//            default:Console.WriteLine("Что-то пошло не так"); break;
//    }
//}

class AnyDocument
{
    public string Name { get; set; }
    public string Type { get; set; }
    public AnyDocument(String name, string type)
    {
        Name = name;
    }
    public void ChangeType(string newType)
    {
        Type = newType;
    }
    public override string ToString()
    {
        return Name + "." + Type;
    }
}

class WorkWithDocuments
{
event DelegateWorkDelegate DelegateEvent;
    public void DocumentsToDOC(DelegateWorkDelegate dwd)
    {
        if(dwd !=null)
        {
            DelegateEvent += dwd;
        }
    }
    public void Start()
    {
        if (DelegateEvent != null)
        {
            DelegateEvent.Invoke();
        }
    }
    public static void OutInfoDOC()
    {
        Console.WriteLine("Это документ ворд");
    }
    public static void OutInfoTXT(string a)
    {
        Console.WriteLine("Это документ текстовый ({0})", a);
    }
    public static void OutInfoPDF(string a)
    {
        Console.WriteLine("Это документ PDF ({0})", a);
    }
    public static void OutInfoXLSX(string a)
    {
        Console.WriteLine("Это документ  MS Excel ({0})", a);
    }
    public static void OutInfoCSV(string a)
    {
        Console.WriteLine("Это документ текстовый с разделителем ({0})", a);
    }
}
delegate void DelegateWorkDelegate();