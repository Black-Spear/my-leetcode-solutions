public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int currentColor = image[sr][sc];
        if (currentColor == color)
        {
            return image;
        }

        Fill(image, sr, sc, color);
        return image;
    }

    void Fill(int[][] pixels, int x, int y, int targetColor)
    {
        if (x < 0 || x >= pixels.GetLength(0) || y < 0 || y >= pixels[0].GetLength(1) || pixels[x][y] == targetColor)
        {
            return;
        }

        pixels[x][y] = targetColor;

        Fill(pixels, x + 1, y, targetColor); // Right
        Fill(pixels, x - 1, y, targetColor); // Left
        Fill(pixels, x, y + 1, targetColor); // Down
        Fill(pixels, x, y - 1, targetColor); // Up
    }
}


