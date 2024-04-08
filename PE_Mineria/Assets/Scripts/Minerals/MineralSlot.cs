using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralSlot : MonoBehaviour
{

    public int unlockDay;

    [SerializeField] private bool unlocked;

    [SerializeField] private GameObject mineralPlaneEdge;

    [SerializeField] private GameObject mineralPlane;

    [SerializeField] private Transform machineryInstanceTransform;

    [SerializeField] private GameObject infoCanvas;

    private Color slotColor;

    public Minerals slotType;

    public bool hasMachine;

    public event Action<Minerals> OnMineralSlotUnlocked;

    public GameObject currentMachinery;

    private void Awake()
    {
        hasMachine = false;
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
            OnMineralSlotUnlocked?.Invoke(slotType);
        }
    }

    public void ConfigureMineralSlot(MineralVars vars)
    {
        slotType = vars.mineralType;
        SetMineralColor(vars.mineralColor);
        infoCanvas.GetComponent<SlotInfoManager>().SetMineralInfo(vars);
        slotType = vars.mineralType;

    }

    public void SetMineralColor(Color color)
    {
        mineralPlane.GetComponent<Renderer>().material.color = color;
        mineralPlaneEdge.GetComponent<Renderer>().material.color = color;
        slotColor = color;
    }

    public void InstanceMachinery(MachineryVars machinery)
    {
        GameObject machineryPrefab = GameManager.Instance.machineryPrefab;
        currentMachinery = Instantiate(machineryPrefab, machineryInstanceTransform.parent);

        //Renderer r = currentMachinery.TryGetComponent<Renderer>(out rende).material.color = slotColor;

    }

    public void OnMouseOver()
    {
        if (GameManager.Instance.machineryInventory.isActiveAndEnabled) { return; }
        infoCanvas.SetActive(true);
    }
    public void OnMouseExit()
    {
        if (GameManager.Instance.machineryInventory.isActiveAndEnabled) { return; }
        infoCanvas.SetActive(false);
    }

    public void OnMouseDown()
    {
        //If doesn't have machine, open machinery inventory
        if (hasMachine || GameManager.Instance.machineryInventory.isActiveAndEnabled) { return; }
        else
        {
            GameManager.Instance.machineryInventory.ActivateMachineryInventory(this);
            infoCanvas.SetActive(false);
        }
    }
}
