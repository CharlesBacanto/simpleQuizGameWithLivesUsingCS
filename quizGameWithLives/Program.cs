class Program
{
    static void Main(string[] args)
    {
        int lives = 3;      // Declaration of initial lives
        int take = 1;       // Declaration of initial number of takes
        int points = 0;     // Declaration of initial points
        bool stop = false;  // Identifyer for the loop to stop depending on the case


        do
        {
            
            //Array of Questions
            string[] questions = { " 2*1 = ", " 2+2 = ", " 9-3 = ", " 5+4 = ", " 7-4 = ", " 12+5 = ", " 6*5 = ", " 8/2= ", " 9+7 = " };
            //Array of Correct Answers
            int[] correctAnswers = { 2, 4, 6, 9, 3, 17, 30, 4, 16 };


            //For loop to iterate Questions
            for (int i = 0; i < questions.Length;) // For loop for iterating each index in questions array
            {
                for (int j = 0; j < correctAnswers.Length;) // For loop for iterating each index in correctAnswers array
                {
                    if (lives > 0) //Condition for do while loop to run if lives is greater than 0
                    {
                        do
                        {   
                            //Print out lives and points
                            Console.Write("Lives: " + lives);
                            Console.WriteLine("          Points: " + points + "\n");

                            //Print out questions to prompt the user to answer
                            Console.Write("Q#"+take+": "+questions[i]);
                            int answer = Convert.ToInt32(Console.ReadLine()); // Fetchs user inputs
                            Console.WriteLine("\n****************************\n"); // Provide spacing for clarity

                            //If statement to validate  if the user input is equal with the correct answer
                            if (answer.Equals(correctAnswers[j])) // If correct applies the following:
                            {
                                stop = true; // Stop the do while loop to change to the next question
                                points++; // Increase points if answered correct
                                take++; // Increase the take count
                                break;
                            }
                            else // If wrong applies the following:
                            {
                                lives--; // Decrease lives when the answer is wrong
                                take++; // Increase the take count
                                stop = false; // Continue the do while loop so the question will not change when the answer is wrong
                                if (lives == 0) // If Statement to do something when the lives drops to zero
                                {
                                    stop = true; // Stop the do while loop
                                    Console.WriteLine("You failed"); // Print out message indicating that there are no more lives
                                }
                            }

                        }
                        while (stop == false); // While Condition to stop only when stop is equals to true
                        i++; // Increment the index for question array
                        j++; // Increment the index for answers array

                    }
                }
            }
        }
        while (lives > 0); //Condition for do while loop to run if lives is greater than 0



    }


}