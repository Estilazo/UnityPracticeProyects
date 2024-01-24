using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private CycleManager cycleManager;

    [SerializeField] private UIManager uimanager;

    [SerializeField] private Dictionary<Minerals, Color> mineralColors;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        cycleManager.OnCycleStageChanged += uimanager.UpdateDayCycleText;
        cycleManager.OnDayPassed += uimanager.UpdateTotalDaysText;
    }

    private void Start()
    {
        Debug.Log("starts");
    }

    public void SetupColorDictionary(List<MineralVars> minerals)
    {
        foreach (MineralVars mineral in minerals)
        {
            mineralColors.Add(mineral.mineralType, mineral.mineralColor);
        }
    }
}
