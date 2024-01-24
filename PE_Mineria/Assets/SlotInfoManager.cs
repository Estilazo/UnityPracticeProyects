using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotInfoManager : MonoBehaviour
{

    [SerializeField] private MineralSlot mineralSlot;

    [SerializeField] private Text mineralName;

    [SerializeField] private Text mineralValue;

    private MineralVars mineralVars;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMineralInfo(MineralVars vars)
    {
        mineralVars = vars;
        mineralName.text = vars.name;
        mineralValue.text = "Value: $" + vars.mineralValue.ToString();
    }
}
