namespace ProjetNarratif
{
    internal abstract class Quest
    {
        internal abstract string CreateDescription();
        internal abstract void ReceiveChoice(string choice);

        
    }

}
