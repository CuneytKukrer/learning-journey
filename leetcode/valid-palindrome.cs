https://leetcode.com/problems/valid-palindrome/  
Easy
Two Pointers, String 
O(1)
    
public bool IsPalindrome(string s)
{
    // İki adet işaretçi (pointer) tanımlıyoruz.
    int left = 0;
    int right = s.Length - 1;

    while (left < right)
    {
        // Soldaki karakter alfa-nümerik (harf veya sayı) değilse ilerle
        if (!char.IsLetterOrDigit(s[left]))
        {
            left++;
        }
        // Sağdaki karakter alfa-nümerik değilse gerile
        else if (!char.IsLetterOrDigit(s[right]))
        {
            right--;
        }
        // Her iki işaretçi de geçerli bir karaktere bakıyorsa karşılaştır
        else
        {
            // Büyük/küçük harf duyarlılığını kaldırmak için karakterleri küçülterek kıyasla
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false; // Eşleşme yoksa palindrome değildir
            }
            left++;
            right--;
        }
    }

    return true; // Tüm kontroller başarıyla tamamlandıysa palindrome'dur
}
