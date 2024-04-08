using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MachineryInventoryItem : MonoBehaviour
{
    [SerializeField] private Text nameText;

    [SerializeField] private Button pickButton;

    private MachineryVars machineryToSpawn;

    private int machineryID;

    private void Start()
    {
        pickButton.onClick.AddListener(OnPickButtonClicked);
    }

    public void SetVars(MachineryVars machinery)
    {
        machineryToSpawn = machinery;
        nameText.text = machinery.name;
        machineryID = machinery.machineryID;
    }

    public void OnPickButtonClicked()
    {
        bool canSpawn = GameManager.Instance.machineryInventory.InstanceMachineOnSlot(machineryToSpawn);
        if (canSpawn)
        {
            Destroy(this.gameObject);
            GameManager.Instance.machineryInventory.gameObject.SetActive(false);
        }
    }

    public int GetMachineryID() { return machineryID; }

}
