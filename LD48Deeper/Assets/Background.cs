using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
