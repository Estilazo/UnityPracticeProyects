using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleButton : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject console;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void Start()
    {
        if (button != null && console != null)
        {
            button.onClick.AddListener(ToggleConsole);
        }
    }

    private bool isActive;

    public void ToggleConsole()
    {
        isActive = !isActive;
        console.SetActive(isActive);

        if (isActive)
        {
            GetComponentInChildren<Text>().text = "Close Console";
        }
        else
        {
            GetComponentInChildren<Text>().text = "Open Console";
        }
    }
}
