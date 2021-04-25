using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderStablizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("hit");
        if (collision.gameObject.tag == "Hull 1" || collision.gameObject.tag == "O2" || collision.gameObject.tag == "Batt1" || collision.gameObject.tag == "Prop")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            print("hitmin");
        }
    }
}
