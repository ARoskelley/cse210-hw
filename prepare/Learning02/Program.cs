using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Developer";
        job1._company = "Dell";
        job1._timeOfEmplyment = "2011 - 2022";

        job2._jobTitle = "Overseer";
        job2._company = "Vault-tec";
        job2._timeOfEmplyment = "2082 - 2103";

        Resume myResume = new Resume();
        myResume._name = "Aiden Roskelley";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}