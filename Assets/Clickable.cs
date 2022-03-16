using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Clickable : MonoBehaviour
{
    public UnityEvent onclick;
    // Start is called before the first frame update
   public void click()
    {
        onclick.Invoke();

    }

}
