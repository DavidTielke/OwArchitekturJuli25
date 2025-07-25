﻿using DavidTielke.PMA.Data.FileStoring.Contract;

namespace DavidTielke.PMA.Data.FileStoring;

public class FileReader : IFileReader
{
    public IEnumerable<string> ReadLines(string path)
    {
        return File.ReadLines(path);
    }
}