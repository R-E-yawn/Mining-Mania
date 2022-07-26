using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 screenPos = transform.position;
        screenPos.x = Mathf.Clamp(screenPos.x, screenBounds.x *-1  + objectWidth, screenBounds.x  - objectWidth);
        screenPos.y = Mathf.Clamp(screenPos.y, screenBounds.y *-1 + objectHeight, screenBounds.y  - objectHeight);
        transform.position = screenPos;

    }

   
}
