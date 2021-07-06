using System;
using System.IO;

namespace Wieszak {
public class Gra : Form
{
   private ReadFromFile readFromFile[];
   private Random random;
      private string Capitals[];
      private int Pomylonych;
      private int Zgadnietych;
      private bool wordRevealed;
      private const int Lives = 5;

    public Gra()
    {
        InitializeComponent();
    }

    private void Game_Load(object sender, EventArgs e)
    {
        loadWords("words");
        selectRandomWord();
    }

    private void loadWords(string countries_and_capitals)
    {
        readFromFile = new ReadFromFile(countries_and_capitals.txt);
        readFromFile.read();
    }
    
    private void loadCapitals
    {
        List<string> lines = System.IO.File.ReadLines(completePath).ToList();

    private void selectRandomWord()
    {
        random = new Random();

        string[] words = readFromFile.lines;
        word = words[random.Next(words.Length)];
    }

    private void letter_Click(object sender, EventArgs e)
    {
        if (wordRevealed)
            return;

        Button button = (Button)sender;

        char letter = char.Parse(button.Name.Substring(6).ToLower());

        guessLetter(letter);
        buttonClicked(button);
    }

    private void guessLetter(char letter)
    {
        if (!word.Contains(letter))
        {
            // wrong guess
            Pomylonych++;
        }
        else
        {
            // right guess
            for (int index = 0; index < word.Length; index++)
            {
                if (letter == word[index])
                {
                    revealLetter(index, letter);
                    Zgadnietych++;
                    Console.WriteLine(Zgadnietych);
                }
            }
        }
        if (Zgadnietych == word.Length)
        {
            wordRevealed = true;
            Console.WriteLine("WON");
        }
        if (Pomylonych == Lifes)
        {
            Console.WriteLine("Game Over");
        }
    }
}
