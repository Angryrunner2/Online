using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    private int x;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        x = (int)Random.Range(200.0f, 250.0f);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (GameObject.FindWithTag("red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (GameObject.FindWithTag("blue") && i >= 200)
        {
            rend.enabled = false; ;
        }
    }
       
    
}
