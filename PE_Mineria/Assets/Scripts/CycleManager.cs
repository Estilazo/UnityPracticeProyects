using OpenCover.Framework.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CycleManager : MonoBehaviour
{
    public event Action<CycleStages> OnCycleStageChanged;

    public event Action<int> OnDayPassed;

    private CycleStages currentStage;

    private int CurrentDay = 1;

    private void Awake()
    {
        currentStage = CycleStages.Morning;
    }

    private void Start()
    {
        OnDayPassed?.Invoke(CurrentDay);
        OnCycleStageChanged?.Invoke(currentStage);
    }

    public void GoToNextCycle()
    {
        CycleStages[] stages = (CycleStages[])Enum.GetValues(typeof(CycleStages));

        int currentIndex = Array.IndexOf(stages, currentStage);

        int nextIndex = (currentIndex + 1) % stages.Length;

        if (nextIndex == 0)
        {

            CurrentDay++;

            OnDayPassed?.Invoke(CurrentDay);
        }
        Debug.Log(nextIndex);
        currentStage = stages[nextIndex];

        OnCycleStageChanged?.Invoke(currentStage);

    }

}
