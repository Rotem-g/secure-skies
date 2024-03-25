using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum Stat
{
    Debugging,
    BugTesting,
    Communication
}

[System.Serializable]
public class StatInfo
{
    public Stat statType;
    public float value;
}