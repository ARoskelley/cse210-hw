using System;
using System.Collections.Generic;
using System.Security;
public abstract class Goal
{
    private string _title;
    private string _description;
    private int _score;
    protected int _cumulativeScore;

    public Goal(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public int GetCumulativeScore()
    {
        return _cumulativeScore;
    }

    public abstract void Award();
}