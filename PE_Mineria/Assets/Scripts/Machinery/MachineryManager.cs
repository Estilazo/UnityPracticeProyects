using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineryManager : MonoBehaviour
{
    [SerializeField]
    private List<MachineryVars>  machineryTypes;

    [SerializeField]
    private GameObject machineryPrefab;

    [SerializeField] private Dictionary<Minerals, Color> mineralColors;

    public void SetupColorDictionary(List<MineralVars> minerals)
    {
        mineralColors = new Dictionary<Minerals, Color>();

        foreach (MineralVars mineral in minerals)
        {
            mineralColors.Add(mineral.mineralType, mineral.mineralColor);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
