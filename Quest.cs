using ProjetNarratif.Quête;

namespace ProjetNarratif
{
    internal abstract class Quest
    {
        internal abstract string CreateDescription();
        internal abstract void ReceiveChoice(string choice,Edvars e, Leshen l,Nécrophages n);

        
    }

}
