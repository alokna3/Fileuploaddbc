using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fileuploaddbc.Models
{
    public class FileUploadViewModel:FileModel
    {
        public List<FileOnFileSystemModel> FilesOnFileSystem { get; set; }
        public List<FileOnDatabaseModel> FilesOnDatabase { get; set; }
    }
}
