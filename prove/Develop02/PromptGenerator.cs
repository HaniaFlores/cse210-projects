//Prompt Generator Class

public class PromptGenerator
{
    List<string> _prompts = new List<string>(){
        "I am grateful for...",
        "What would make today great?",
        "Affirmation. I am...",
        "3 Amazing things that happened today...",
        "How could I have made today even better?"
    };


    public string GeneratePrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_prompts.Count);
        string prompt = _prompts[r];
        return prompt;
    }
}