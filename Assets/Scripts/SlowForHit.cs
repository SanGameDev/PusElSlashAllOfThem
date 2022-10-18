using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowForHit : MonoBehaviour
{
    
    public bool paint = false;
    public GameObject screen;

    // Update is called once per frame
    void Update()
    {
        if(paint == true){
            screen.SetActive(true);
        }else
        {
            screen.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Time.timeScale = .2f;
            paint = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Time.timeScale = 1f;
            paint = false;
        }
    }
}
