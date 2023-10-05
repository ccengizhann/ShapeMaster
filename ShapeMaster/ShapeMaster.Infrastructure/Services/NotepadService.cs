using ShapeMaster.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Infrastructure.Services
{
    public class NotepadService
    {
        public void SaveToNotpad(ISaveableShape saveableShape)
        {
            string path = DirectoryService.GetNotepadDirectory();

            DirectoryService.DirectoryCreateIfNotExist(path);

            string filePath = $"{path}\\{saveableShape.GetType()}s.txt)";

            File.AppendAllText(filePath, $"{saveableShape.GetInfo()}\n");
        }
    }
}
