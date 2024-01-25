using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineryInventoryItem : MonoBehaviour
{
    [SerializeField] private Text nameText;

    public void SetName(string name)
    {

        nameText.text = name;


    }
}
