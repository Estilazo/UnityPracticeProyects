using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MachineryVars", menuName = "Game/Machinery Variables")]
public class MachineryVars : ScriptableObject
{
    [SerializeField]
    private Minerals mineralType;

    [SerializeField]
    private int machineryID;

    [SerializeField]
    private float buyCost;

    [SerializeField]
    private string name;

    [SerializeField]
    private int workers;

    [SerializeField]
    private float multiplier;


}
