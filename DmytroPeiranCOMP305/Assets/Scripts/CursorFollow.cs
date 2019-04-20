using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollow : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    private void Update()
    {
        transform.position = Input.mousePosition;
    }
}
