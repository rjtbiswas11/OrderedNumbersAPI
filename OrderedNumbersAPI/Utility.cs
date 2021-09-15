using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedNumbersAPI
{
    public class Utility
    {
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public void SaveToText(int[] arr, string fileName)
        {
            string filePath = @"C:\" + fileName + ".txt";

            if (File.Exists(filePath)) File.Delete(filePath);

            var stringBuilder = new StringBuilder();
            foreach (var arrayElement in arr)
            {
                stringBuilder.Append(string.Format("{0} ", arrayElement.ToString()));
            }
            File.WriteAllText(filePath, stringBuilder.ToString());
        }

        public string ReadFromFile(string fileName)
        {
            string filePath = @"C:\" + fileName + ".txt";
            string contents = File.ReadAllText(filePath);
            return contents;
        }
    }
}
