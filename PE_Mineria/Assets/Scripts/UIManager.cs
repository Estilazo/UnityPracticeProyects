using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text dayCycleText;

    [SerializeField]
    private Text totalDaysText;

    public void UpdateTotalDaysText(int day)
    {
       if (totalDaysText != null)
        {
            totalDaysText.text = day.ToString();
        }
    }

    public void UpdateDayCycleText(CycleStages stage)
    {
        if (dayCycleText != null)
        {
            dayCycleText.text = stage.ToString();
        }
    }
}
