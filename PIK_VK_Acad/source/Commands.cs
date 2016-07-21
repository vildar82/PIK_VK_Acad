using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;

namespace PIK_VK_Acad
{
    public class Commands
    {
        const string group = AcadLib.Commands.Group;

        /// <summary>
        /// Установка подзаголовочного стиля выбранной ячейке таблицы
        /// </summary>
        [CommandMethod(group, nameof(VK_SetSpecCellSubheadStyle), CommandFlags.Modal)]
        public void VK_SetSpecCellSubheadStyle()
        {
            AcadLib.CommandStart.Start(doc =>
            {
                Spec.TableService ts = new Spec.TableService(doc);
                ts.SetCellSubheadStyle();
            });
        }
    }
}
