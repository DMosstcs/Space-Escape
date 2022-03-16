using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WireConect : MonoBehaviour
{
    public GameObject Other1;
    public GameObject Screen;
    public Button button;
    public Sprite check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Other1) {
            Screen.SetActive(false);
            button.GetComponent<Image>().sprite=check;
        }

    }
}
