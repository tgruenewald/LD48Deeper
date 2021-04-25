using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignGrid : MonoBehaviour
{
    public string current_block = null;
    public GameObject current_cell = null;

    public GameObject submarine = null;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Turning off physics");
        Physics2D.autoSimulation = false;
        // Physics2D.simulationMode = SimulationMode2D.Script;
        // Physics2D.autoSimulate = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
