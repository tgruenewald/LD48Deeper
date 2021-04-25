using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : MonoBehaviour
{
    int health = 0;
    int oxygen = 0;
    public float energy = 0f;

    // Start is called before the first frame update
    void Start()
    {
        countChildren();
    }

    // Update is called once per frame
    void Update()
    {
        oxygen -= 1;
    }
    public void countChildren()
    {
        foreach(Transform child in transform)
        {
            print(child.name);
            child.GetComponent<FixedJoint2D>().connectedBody = GetComponent<Rigidbody2D>();
           if(child.CompareTag("Hull 1"))
            {
                print("add health");
                health += 25;
            }
            if (child.CompareTag("Batt1"))
            {
                print("add Energy");
                energy += 25;
            }
            if(child.CompareTag("O2"))
            {
                print("air present");
                oxygen += 25;
            }
        }
    }
    public float getEnergy()
    {
        return energy;
    }
    public void setEnergy(float nrg)
    {
        energy = nrg;
    }
}
