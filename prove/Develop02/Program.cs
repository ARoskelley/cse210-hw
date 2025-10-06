using System;

class Program
{
    static void Main(string[] args)
    {
        Entry myEntry = new Entry();
        myEntry._givenPrompt = "What was the best part of your day?";
        myEntry._entryDateTime = "Feb 5 2004";
        myEntry._entryText = "Being born";

        Entry anotherEntry = new Entry();
        myEntry._givenPrompt = "Favorite eideo game?";
        myEntry._entryDateTime = "Feb 8 2004";
        myEntry._entryText = "Elden Ring";

        Entry lastEntry = new Entry();
        myEntry._givenPrompt = "Cool Magic Deck";
        myEntry._entryDateTime = "Sep 11 2001";
        myEntry._entryText = "Poison Storm";

        Journal myJournal = new Journal();
        myJournal.AppendEntry(myEntry);
        myJournal.AppendEntry(anotherEntry);
        myJournal.AppendEntry(lastEntry);
        myJournal.Display();
    }
}