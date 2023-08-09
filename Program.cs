using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"is lebron the best nba player?","is casablanca the best romance movie?","is citizen kane overrated?","is kanye west the best rapper?","have you fully integrated your dark-side as recommended by dr.jung?"};
    
    
  	bool[] answers = {false,true, true,true,false};
    bool[] responses = new bool [questions.Length];
    if (questions.Length != answers.Length){
      Console.WriteLine("Answer all questions you bastard.... please");
    }

  int askingIndex = 0;

  foreach (string question in questions){
    string input;
    bool isBool;
    bool inputBool;
    Console.WriteLine(question);
    Console.WriteLine("True or false?");
    input = Console.ReadLine();
    
    isBool = Boolean.TryParse(input, out inputBool);

    while (isBool == false){
      Console.WriteLine("please respond with 'true' or 'false' you musty bitch");
      Console.WriteLine(question);
      Console.WriteLine("True or false?");
      input = Console.ReadLine();

      isBool = Boolean.TryParse(input, out inputBool);
    }
    responses[askingIndex] = inputBool;
    askingIndex += 1;

  }

  int scoringIndex = 0;
  int score = 0;

  foreach (bool answer in answers){
    bool ressy = responses[scoringIndex];
    Console.WriteLine($"Input: {ressy} | Answer: {answer}");

    if(answer == ressy){
      score += 1;
    }
    scoringIndex += 1;

    Console.WriteLine($"You got {score} out of 5 correct!");
  }
}
      
      }
}
