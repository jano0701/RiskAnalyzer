namespace RiskAnalyzer
{
  public class Risk
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public string Kategorie { get; set; }
    public string Status { get; set; }

    public Risk(string name, int level, string kategorie, string status)
    {
      Name = name;
      Level = level;
      Kategorie = kategorie;
      Status = status;
    }

    public bool IstKritisch()
    {
      return Level >= 8;
    }
  }
}
