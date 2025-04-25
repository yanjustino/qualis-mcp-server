namespace QualisMcpSseServer;

public class Dataset
{
    private static readonly Lazy<Dataset> Instance = new(() =>
    {
        var data = new Dataset();
        data.Load();
        return data;
    });

    public static Dataset Current => Instance.Value;
    public string Content { get; private set; } = string.Empty;

    private Dataset()
    {
    }

    private void Load() => Content = File.ReadAllText("Qualis.data");

    public string GetQualis(string sigla) => Content.Split('\n').FirstOrDefault(line => line.Contains(sigla)) ?? "Qualis not found";

    public static string About
        => """
           CLASSIFICATION OF EVENTS FOR 2017-2020 – COMPUTER SCIENCE
           The Qualis, Qualis-Journals or Qualis/CAPES is a Brazilian system for evaluating journals, maintained by the
           Coordination for the Improvement of Higher Education Personnel (CAPES), which relates and classifies the
           vehicles used for the dissemination of the intellectual production of postgraduate programs of the type "stricto
           sensu" (master's and doctoral), regarding the scope of circulation (local, national or international) and quality
           (A, B, C), by area of evaluation.
           """;
}