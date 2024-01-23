using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralSlotsManager : MonoBehaviour
{

    [SerializeField] private MineralSlot[] mineralSlots;

    [SerializeField] private List<ScriptableObject> mineralVars;


    private void Awake()
    {
        mineralSlots = GetComponentsInChildren<MineralSlot>();
    }

    private void Start()
    {
        SusbcribeMineralSlots();
    }

    private void SusbcribeMineralSlots()
    {
        foreach (MineralSlot slot in mineralSlots)
        { 
            GameManager.Instance.GetComponent<CycleManager>().OnDayPassed += slot.UnlockMineralSlot;
        }
    }
}
