using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MineralVars", menuName = "Game/Mineral Variables")]
public class MineralVars : ScriptableObject
{
    public Minerals mineralType;

    public float mineralValue;

    public Color mineralColor;

}
