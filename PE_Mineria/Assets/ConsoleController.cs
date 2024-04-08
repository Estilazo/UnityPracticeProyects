using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleController : MonoBehaviour
{
    [Header("Managers")]
    [SerializeField] private MachineryManager machineryManager;
    [SerializeField] private MachineryInventoryManager inventoryManager;
    
    [Space]
    [SerializeField] private InputField consoleInput;
    [SerializeField] private Transform consoleLog;
    [SerializeField] private GameObject textBox;

    private void OnEnable()
    {
        consoleInput.onEndEdit.AddListener(ConsoleFunctionCaller);  
    }

    private void OnDisable()
    {
        consoleInput.onEndEdit.RemoveListener(ConsoleFunctionCaller);
    }

    public void ConsoleFunctionCaller(string str)
    {

        string[] strWords = str.Split(' ');
        if (strWords.Length != 2)
        {
            InputText("Command Error.");
            return;
        }
        string functionName = strWords[0];
        string functionParameter = strWords[1];
        switch (functionName)
        {
            case "buy":
                if (inventoryManager.BuyMachinery(int.Parse(functionParameter)))
                {
                    InputText("Machinery bought");
                }
                else
                {
                    InputText("Machinery not found");
                }
                break;

            case "info":
                if (functionParameter.Equals("machinery"))
                {
                    InputText(GetInfoString());
                }
                break;

            default:
                InputText("Unknown Command.");
                break;
        }
    } 

    public void InputText(string str)
    {
        Text text = Instantiate(textBox, consoleLog).GetComponent<Text>();
        text.text = str + "\n";
        consoleInput.text = string.Empty;
    }

    private string GetInfoString()
    {
        MachineryVars[] machineryVars = machineryManager.GetMachineryVarsList();
        string infoHeader = "ID | NAME | RESOURCE | COST | WORKFORCE";
        string infoMachineries = string.Empty;
        foreach (MachineryVars vars in  machineryVars)
        {
            infoMachineries += string.Concat("\n", "[", vars.machineryID, " | ", vars.name, " | ", vars.mineralType, " | ", vars.buyCost, " | ", vars.multiplier, "]");
        }
        return infoHeader + infoMachineries;
    }

}
