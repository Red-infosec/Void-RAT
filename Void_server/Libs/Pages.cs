using System.Windows.Forms;

namespace Void_server.Libs
{
    class Pages
    {
        public static void Deselect(Panel exception)
        {
            //make every panel in the 'menuPanels' invisible
            foreach (Panel page in MainForm.menuPanels)
            {
                if (page != exception)
                    page.Visible = false;
            }
        }
    }
}