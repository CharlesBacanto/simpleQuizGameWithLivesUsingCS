class Program
{
    static void Main(string[] args)
    {
        int lives = 3;
        int take = 1;
        int points = 0;
        bool correct = false;
        do
        {
            

            //Array of Questions
            string[] questions = { "2*1", "2+2", "9-3" };
            //Array of Correct Answers
            int[] correctAnswers = { 2, 4, 6 };


            //For loop to iterate Questions
            for (int i = 0; i < questions.Length;)
            {
                for (int j = 0; j < correctAnswers.Length;)
                {
                    if (lives > 0)
                    {
                        do
                        {
                            Console.Write("Lives: " + lives);
                            Console.WriteLine("          Points: " + points + "\n");
                            Console.Write(questions[i]);
                            int answer = Convert.ToInt32(Console.ReadLine());

                            if (answer.Equals(correctAnswers[j]))
                            {
                                correct = true;
                                points++;
                                break;
                            }
                            else
                            {
                                lives--;
                                if (lives == 0)
                                {
                                    correct = true;
                                    Console.WriteLine("You failed");
                                }
                            }

                        }
                        while (correct == false);
                        i++;
                        j++;
                    }
                }
            }
        }
        while (lives > 0);


        
    }


}