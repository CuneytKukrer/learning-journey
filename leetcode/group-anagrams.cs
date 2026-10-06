using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs == null || strs.Length == 0) 
            return new List<IList<string>>();

        // Sıralanmış kelimeyi KEY, orijinal kelimelerin listesini VALUE olarak tutuyoruz
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            // Kelimeyi karakter dizisine çevirip sıralıyoruz
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedKey = new string(charArray);

            // Eğer bu anahtar sözlükte yoksa yeni bir liste ekliyoruz
            if (!groups.ContainsKey(sortedKey)) {
                groups[sortedKey] = new List<string>();
            }
            
            // Orijinal kelimeyi ilgili gruba ekliyoruz
            groups[sortedKey].Add(s);
        }

        // Sözlükteki tüm listeleri IList<IList<string>> formatında döndürüyoruz
        return groups.Values.Cast<IList<string>>().ToList();
    }
}
