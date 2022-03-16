using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class MiddleConsle : MonoBehaviour
{

    //Start is called before the first frame update
    public GameObject screen;
    public RigidbodyFirstPersonController personController;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnMouseClick()
    {
        screen.SetActive(true);
        Cursor.visible = true;
        
    }
}
