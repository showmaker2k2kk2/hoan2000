using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Inventory_Manager
{
    public class Program
    {

        public static void Main(string[] args)
        {
            GameUIManager uiManager = new GameUIManager();
            uiManager.ShowMainMenu();
        }
    }
}
