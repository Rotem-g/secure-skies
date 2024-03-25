using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum Stat
{
    DigitalAcquisition,
    HostAnalysis,
    NetworkAnalysis,
    MalawareAnalysis,
    IOTAnalysis,
    MobileDeviceAnalysis,
    DatabaseAnalysis
}

[System.Serializable]
public class StatInfo
{
    public Stat statType;
    public float value;
}