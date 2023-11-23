using ProjetNarratif.Quests;
using ProjetNarratif.Quête;
using System.Diagnostics;
using System.Threading;

namespace ProjetNarratif
{
    internal class Game
    {
        List<Quest> quests = new();
        Quest currentQuest;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextQuest = "";

        internal void Add(Quest quest)
        {
            quests.Add(quest);
            if (currentQuest == null)
            {
                currentQuest = quest;
            }
        }

        public Edvars player = new Edvars();
        public Leshen monstre = new Leshen();

        internal string CurrentQuestDescription => currentQuest.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            currentQuest.ReceiveChoice(choice,player,monstre);
            CheckTransition();
        }

        internal static void Transition<T>() where T : Quest
        {
            nextQuest = typeof(T).Name;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal void CheckTransition()
        {
            foreach (var quest in quests)
            {
                if (quest.GetType().Name == nextQuest)
                {
                    nextQuest = "";
                    currentQuest = quest;
                    break;
                }
            }
     
        }
    }

}
