public int MaxArea(int[] height) {
    int maxArea = 0;
    int left = 0;
    int right = height.Length - 1;

    while (left < right) {
        // İki çizgi arasındaki genişlik
        int width = right - left;
        
        // Kısa olan çizginin yüksekliği alanı belirler
        int currentHeight = Math.Min(height[left], height[right]);
        
        // Maksimum alanı güncelle
        int currentArea = currentHeight * width;
        if (currentArea > maxArea) {
            maxArea = currentArea;
        }

        // Yüksekliği küçük olan göstergeci hareket ettir
        if (height[left] < height[right]) {
            left++;
        } else {
            right--;
        }
    }

    return maxArea;
}
