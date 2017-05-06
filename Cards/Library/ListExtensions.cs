using System;
using System.Collections.Generic;

namespace CardOrganizer.Library {
    public static class ListExtensions {
        private static readonly Random _random = new Random();

        //Fisher-Yates shuffle extension
        //Source: http://stackoverflow.com/questions/273313/randomize-a-listt
        //shuffle a list
        public static void Shuffle<T>(this IList<T> list) {
            for (int i = 0; i < list.Count; i++) {
                list.Swap(i, _random.Next(i, list.Count));
            }
        }

        //swap two items in a list
        public static void Swap<T>(this IList<T> list, int i, int j) {
            T tempItem = list[i];
            list[i] = list[j];
            list[j] = tempItem;
        }
    }
}