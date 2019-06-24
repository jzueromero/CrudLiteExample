using System;
using System.Collections.Generic;
using System.Text;

namespace EsqueletoSQLite.Services
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
