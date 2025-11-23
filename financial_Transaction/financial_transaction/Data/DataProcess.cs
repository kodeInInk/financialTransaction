namespace financial_transaction.Data;
using System.IO;

public class DataProcess
{
    public static List<Dictionary<string, string>> ReadCsv(string path)
    {
        var lines = File.ReadAllLines(path);

        if (lines.Length == 0)
            return [];

        var header = lines[0].Split(',');
        var rows = new List<Dictionary<string, string>>();

        for (int i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(',');
            var dict = new Dictionary<string, string>();

            for (int j = 0; j < header.Length && j < values.Length; j++)
            {
                dict[header[j]] = values[j];
            }

            rows.Add(dict);
        }

        return rows;
    }

}