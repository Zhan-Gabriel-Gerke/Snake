public class Score
{
    private int currentScore;
    private int xOffset;
    private int yOffset;

    public Score(int score, int x, int y)
    {
        currentScore = score;
        xOffset = x;
        yOffset = y;
    }

    // Свойство для получения текущего счёта
    public int CurrentScore
    {
        get { return currentScore; }
    }

    // Метод для добавления очков
    public void AddPoints(int points)
    {
        currentScore += points;
    }

    // Метод для отображения текущего счёта на экране
    public void ShowScore()
    {
        Console.SetCursorPosition(xOffset, yOffset);
        Console.WriteLine($"Score: {currentScore}");
    }
}
