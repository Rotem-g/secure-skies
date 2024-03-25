using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "SecureSkies/Stats", order = 0)]
public class PlayerStats : ScriptableObject 
{
    public List<StatInfo> OriginalStats = new List<StatInfo>();

    public List<StatInfo> statInfo = new List<StatInfo>();


    private void Start() {
        statInfo = new List<StatInfo>();
    }

    public float GetStat(Stat stat)
    {
        foreach(var s in statInfo)
        {
            if(s.statType == stat)
            {
                
                return s.value;
            }
        }

        Debug.Log("Stat not found buddy");
        return 0;
    }

    public void SetStat(Stat stat, float amount)
    {
        foreach(var s in statInfo)
        {
            if(s.statType == stat)
            {
                s.value = amount;
                return;
            }
        }
        StatInfo temp = new StatInfo();
        temp.statType = stat;
        temp.value = amount;
        statInfo.Add(temp);
    }

    public void ChangeStat(Stat stat, float amount)
    {
        foreach(var s in statInfo)
        {
            if(s.statType == stat)
            {
                s.value += amount;
                return;
            }
        }
        StatInfo temp = new StatInfo();
        temp.statType = stat;
        temp.value = amount;
        statInfo.Add(temp);
    }

    

    public void InitStats()
    {
        statInfo = new List<StatInfo>();
        foreach(var s in OriginalStats)
        {
            SetStat(s.statType, s.value);
        }
    }
}
