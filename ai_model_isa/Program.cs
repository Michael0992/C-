namespace ai_model_isa
{
    internal class Program
    {

        private static int DialogTimer;
        public static bool StartDialog = true;
        public static List<string[]> dialog = new List<string[]>();
        static void Main(string[] args)
        {
            
            loader.kognitive_empty = true;
            loader.sentence_empty = true;
            
            loader.check_sentence();
            loader.check_kognitive();
            

            while (true)
            {
                DialogTimer = input.secondsYear(0);
                if (instinct.simplerandom(0, 2) == 1)
                {
                    dialog = input.myinput(dialog);
                }
                else
                {
                    dialog = input.isainput(dialog);

                }
                if(ControllTimer() == true)
                {
                    //analyzer.analyzing(dialog);
                }
                else
                {
                    dialog.Clear();
                }
               
               StartDialog = false;
            }

           
        }
        public static bool ControllTimer()
        {
            
            if(input.secondsYear(DialogTimer) < 300) return false;
            return true;
            

        }
        
    }
}