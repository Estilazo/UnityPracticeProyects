using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MineralVars", menuName = "Game/Mineral Variables")]
public class MineralVars : ScriptableObject
{
    [SerializeField]
    private Minerals mineralType;

    [SerializeField]
    private float mineralValue;

    [SerializeField]
    private Dictionary<Minerals , Color> mineralColors;


}
