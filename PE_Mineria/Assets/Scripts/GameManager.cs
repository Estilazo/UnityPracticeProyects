using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private CycleManager cycleManager;

    [SerializeField] private UIManager uimanager;

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
}
