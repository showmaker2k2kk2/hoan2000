using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Inventory_Manager
{
    public class FeatureBase
    {
        public string featureName = "";
        public string methodName = "";

        public FeatureBase(string featureName, string methodName)
        {
            this.featureName = featureName;
            this.methodName = methodName;
        }
    }

    public class GameUIManager
    {
        

        public void ShowMainMenu()
        {
            FeatureBase[] features = new FeatureBase[3];
            features[0] = new FeatureBase("Quan ly Weapon", "WeaponPanel");
            features[1] = new FeatureBase("Quan ly Cloth", "ClothPanel");
            features[2] = new FeatureBase("Quan ly tat ca item", "AllItemPanel");

            string key = ShowMenuBase("Chuong trinh quan ly kho do", features);
        }

        public void ShowLine(int element)
        {
            for (int i = 0; i < element; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        public string ShowMenuBase(string title, FeatureBase[] feature)
        {
            Console.WriteLine(title);
            ShowLine(30);
            for (int i = 0; i < feature.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {feature[i].featureName}");
            }
            ShowLine(30);

            Console.Write("Nhap lua chon: ");
            return Console.ReadLine();
        }
    }
}
