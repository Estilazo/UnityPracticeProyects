using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralSlotsManager : MonoBehaviour
{

    [SerializeField] private MineralSlot[] mineralSlots;

    [SerializeField] private List<MineralVars> mineralVars;


    private void Awake()
    {
        mineralSlots = GetComponentsInChildren<MineralSlot>(true);
    }

    private void Start()
    {
        SusbcribeMineralSlots();
        SetupMineralSlots();
        GameManager.Instance.SetupColorDictionary(mineralVars);
    }

    private void SusbcribeMineralSlots()
    {
        foreach (MineralSlot slot in mineralSlots)
        { 
            GameManager.Instance.GetComponent<CycleManager>().OnDayPassed += slot.UnlockMineralSlot;
        }
    }

    private void SetupMineralSlots()
    {
        foreach (MineralSlot slot in mineralSlots)
        {
            if(slot.unlockDay == 1)
            {
                slot.ConfigureMineralSlot(mineralVars[0]);
            }
            else
            {
                int i = Random.Range(1, mineralSlots.Length);
                slot.ConfigureMineralSlot(mineralVars[i]);
            }
        }
    }
}