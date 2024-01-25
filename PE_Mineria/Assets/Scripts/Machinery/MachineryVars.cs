using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MachineryVars", menuName = "Game/Machinery Variables")]
public class MachineryVars : ScriptableObject
{
    public Minerals mineralType;

    public int machineryID;

    public float buyCost;

    public string name;

    public float multiplier;



}
