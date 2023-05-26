using System;

class Program
{
    static void Main(string[] args)
    {

        Reference verseRef = new Reference("Matthew", 5, 38, 41);

        Scripture Passage = new Scripture(verseRef, "38 ¶ Ye have heard that it hath been said, An eye for an eye, and a tooth for a tooth:\n 39 But I say unto you, That ye resist not evil: but whosoever shall smite thee on thy right cheek, turn to him the other also.\n 40 And if any man will sue thee at the law, and take away thy coat, let him have thy cloak also.\n 41 And whosoever shall compel thee to go a mile, go with him twain.");
            
            while(! Passage._allWordsHidden){
                
                Passage.RenderScripture();
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                String userInput = Console.ReadLine();

                if (userInput == "quit" ^ Passage._allWordsHidden == true){
                    break;
                }
                else{
                    
                    Passage.HideWords();
                    Passage.CheckIfAllWordsHidden();
                    Passage.UpdateFulltext();
                    Console.Clear();
                    continue;
                }
                
            }

    }
}