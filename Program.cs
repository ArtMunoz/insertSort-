using System;
using System.Collections.Generic;

namespace insertionSort
{
    class Program{
        static void Main(string[] args) {
            Random rdm = new Random();
            int[] number = new int[20];
            for(int i=0; i < number.Length; i++) {
                number[i] = rdm.Next(0, 500);
            }

            int j;
            Console.WriteLine("The Array is: ");
            for (j = 0; j < 20; j ++) {
                Console.WriteLine(number[j]);
            }

            insertSort(number);
            Console.WriteLine("The Array sorted is: ");
            for (j = 0; j < 20; j++)
                Console.WriteLine(number[j]);
            Console.ReadLine();
        }

        public static T[] insertSort <T> (T[] inputarray, Comparer<T> comparer = null) {
            var equalityComparer = comparer ?? Comparer<T>.Default;
            for (var counter = 0; counter < inputarray.Length - 1; counter++) {
                var index = counter + 1;
                while (index > 0) {
                    if (equalityComparer.Compare(inputarray[index - 1], inputarray[index]) > 0) {
                        var temp = inputarray[index - 1];
                        inputarray[index - 1] = inputarray[index];
                        inputarray[index] = temp;
                    }
                    index--;
                }
            }
            return inputarray;
        }
    }
}
