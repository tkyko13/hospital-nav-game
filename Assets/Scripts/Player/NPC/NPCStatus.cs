using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCStatus : MonoBehaviour
{
    public enum ROLL {
        ordinary,
        merchant,
        inn
    }

    public enum MOOD_TYPE {
        good,
        bad
    }

    public string name;
    public ROLL roll;
    public MOOD_TYPE moodType;
}
