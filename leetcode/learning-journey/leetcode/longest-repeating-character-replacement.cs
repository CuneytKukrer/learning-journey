public int CharacterReplacement(string s, int k)
{
    // Karakter frekanslarını tutmak için dizi (İngilizce büyük harfler için 26 eleman)
    int[] counts = new int[26];

    int left = 0;
    int maxFrequency = 0;
    int maxLength = 0;

    // Sağ göstericiyi (right) hareket ettirerek pencereyi genişletiyoruz
    for (int right = 0; right < s.Length; right++)
    {
        // Mevcut karakterin frekansını artır ve en sık geçen karakter sayısını güncelle
        counts[s[right] - 'A']++;
        maxFrequency = Math.Max(maxFrequency, counts[s[right] - 'A']);

        // Pencere uzunluğu: (right - left + 1)
        // Değiştirilmesi gereken karakter sayısı k'dan büyükse pencereyi soldan daralt
        while ((right - left + 1) - maxFrequency > k)
        {
            counts[s[left] - 'A']--;
            left++;
        }

        // Geçerli olan en uzun pencereyi kaydet
        maxLength = Math.Max(maxLength, right - left + 1);
    }

    return maxLength;
}
