using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralSlot : MonoBehaviour
{

    public int unlockDay;

    [SerializeField] private bool unlocked;

    [SerializeField] private Minerals slotType;

    public event Action onMineralSlotUnlocked;

    private void Awake()
    {
        unlocked = false;
        gameObject.SetActive(false);
    }

    public void UnlockMineralSlot(int day)
    {
        Debug.Log("is called");
        if (day == unlockDay)
        {
            gameObject.SetActive(true);
            unlocked = true;
            onMineralSlotUnlocked?.Invoke();
        }
    }



}
