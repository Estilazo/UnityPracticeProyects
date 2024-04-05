using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleController : MonoBehaviour
{

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

                Debug.Log("buy function called");
                break;

            case "info":
                Debug.Log("Info function called");
                break;

            default:
                InputText("Unknown Command.");
                break;
        }
    } 

    public void InputText(string str)
    {
        Text text = Instantiate(textBox, consoleLog).GetComponent<Text>();
        text.text = str;
        consoleInput.text = string.Empty;
    }
    public void debugIsCalling()
    {
        Debug.Log("IsCalling");
    }

}
