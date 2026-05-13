public class LocalInterface
{

    private LocalInterface() {}

#region Singleton
    //La clase necesitara ser un singleton ya que solo queremos que exista una
    public LocalInterface() {}

    private static LocalInterface _instance;

    public static LocalInterface GetInstance()
    {
       return  Instance();
    }

    private static LocalInterface Instance()
    {
         if (_instance == null)
        {
            _instance = new LocalInterface();
        }
        return _instance;
    }
#endregion

#region References
    private LocalCore _core;
    private ExtractClass _extract;
    private FileClass _files;
    #private loqueseaClass _loquesea
#endregion

    private Initiate(int lang)
    {
        _core = LocalCore.GetInstance();
        _core.Initiate(lang);
        _extract = new ExtractClass();
        _files = new FileClass();
        #_loquesea = new loqueseaClass()
    }

    private void ChangeLang(int newLang)
    {
        _core.ChangeLang(newLang);
    }

    private void Extract()
    {
        _extract.ExtractStrings();
    }
    
    public void WriteToXML(string path) 
    {
        _files.WriteXML(path);
    }

    public void ReadFromXML(string path)
    {
        _files.ReadXML(path)
    }

    public void GetLine(int ID)
    {
        #loqueseaClass
    }
}