class Program
{
    static void Main(string[] args)
    {
        int lives = 3;
        int correctAnswer = 2;
        int take = 1;
        do
        {
            Console.WriteLine("Lives: " + lives + "\n");
            Console.Write("Take #"+take+" What is 1 + 1: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if(answer.Equals(correctAnswer))
            {
                Console.WriteLine("Your Answer is correct");
                break;
            }
            else
            {
                lives--;
            }
            
            take++;

            if (lives == 0)
            {
                Console.WriteLine("You failed");
            }

        }
        while (lives > 0);
    }
}