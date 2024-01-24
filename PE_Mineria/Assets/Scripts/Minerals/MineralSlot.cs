using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralSlot : MonoBehaviour
{

    public int unlockDay;

    [SerializeField] private bool unlocked;

    [SerializeField] private Minerals slotType;

    [SerializeField] private GameObject mineralPlaneEdge;

    [SerializeField] private GameObject mineralPlane;

    [SerializeField] private GameObject infoCanvas;

    public event Action onMineralSlotUnlocked;

    private void Awake()
    {
        unlocked = false;
        infoCanvas.SetActive(false);
        gameObject.SetActive(false);
    }

    private void Start()
    {
    }

    public void UnlockMineralSlot(int day)
    {
        if (day == unlockDay)
        {
            Debug.Log("activates");
            gameObject.SetActive(true);
            unlocked = true;
            onMineralSlotUnlocked?.Invoke();
        }
    }

    public void ConfigureMineralSlot(MineralVars vars)
    {
        slotType = vars.mineralType;
        SetMineralColor(vars.mineralColor);
        infoCanvas.GetComponent<SlotInfoManager>().SetMineralInfo(vars);


    }

    public void SetMineralColor(Color color)
    {
        mineralPlane.GetComponent<Renderer>().material.color = color;
        mineralPlaneEdge.GetComponent<Renderer>().material.color = color;
    }

    public void OnMouseOver()
    {
        infoCanvas.SetActive(true);
    }
    public void OnMouseExit()
    {
        infoCanvas.SetActive(false);
    }

}
