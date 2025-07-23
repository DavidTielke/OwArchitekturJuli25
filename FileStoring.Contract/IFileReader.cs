namespace DavidTielke.PMA.Data.FileStoring.Contract;

public interface IFileReader
{
    IEnumerable<string> ReadLines(string path);
}