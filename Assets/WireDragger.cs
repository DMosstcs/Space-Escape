using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WireDragger: EventTrigger
{
    private bool dragging = false;
    private float MinX = 250f;
    private float MaxX = 2253f;
    
    void Start()
    {
        
    }

    
    // Update is called once per fr;ame
    void Update()
    {
        if (dragging)
        {

            float Xpos = Input.mousePosition.x;
            if(Xpos < MinX)
            {
                Xpos = MinX;
            }
            else if (Xpos > MaxX)
            {
                Xpos = MaxX;

            }

            //transform.position = new Vector2(Xpos, transform.position.y);
            if (transform.position.x < Screen.width / 2)
            {
                float Xscale = Mathf.Max(Xpos / MinX, 1f);
                    
                transform.localScale = new Vector3(Xscale, 1f, 1f);
            }
            
            else {
                float Xscale = Mathf.Max(2*(MaxX - Xpos) / MinX, 1f); 
                transform.localScale = new Vector3(Xscale, 1f, 1f);
                
            }
           //Debug.Log("mouseX : " + Input.mousePosition.x);
            //Debug.Log("Xpos : " + Xpos);
        }
        
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        dragging = true;

    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        dragging = false;

    }
}

