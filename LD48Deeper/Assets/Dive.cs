using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("Dive dive dive");
        GameObject submarine = GameObject.Find("submarine");
        Submarine subCode = submarine.GetComponent<Submarine>();
        subCode.countChildren();

        

        Physics2D.autoSimulation = true;
        // Physics2D.Simulate();
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
