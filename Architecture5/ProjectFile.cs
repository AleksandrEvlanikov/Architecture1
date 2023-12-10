using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    internal class ProjectFile
    {
        public string FileName { get; }
        public int Setting1 { get; private set; }
        public string Setting2 { get; private set; }
        public bool Setting3 { get; private set; }

        public ProjectFile(string fileName, int setting1, string setting2, bool setting3)
        {
            this.FileName = fileName;

            // Загрузка настроек проекта, получаем объектное представление

            this.Setting1 = 2311;
            this.Setting2 = "=> Какой-то проект <=";
            this.Setting3 = false;
        }
    }
}
