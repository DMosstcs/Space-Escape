using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraselect : MonoBehaviour
{
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {


            Ray ray = Camera.main.ScreenPointToRay(new Vector3(0.5f, 0.5f, 0f));
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                //Debug.Log(hit.transform.name);
                //Debug.DrawLine(transform.position, hit.point, Color.red);
                if (hit.transform.gameObject.GetComponent<Clickable>())
                {
                    hit.transform.gameObject.GetComponent<Clickable>().click();

                }
            }
        } 
        
    }
}
