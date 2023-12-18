using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thign : MonoBehaviour
{
    public masterScript ms;
    // Start is called before the first frame update
    void Start()
    {
     //   ms = GetComponent<masterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {

        Debug.Log("hit");
        ms.generateRandomSpot();
        /*
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "pl")
        {
            ms.generateRandomSpot();
        }
        if (collision.gameObject.tag == "present")
        {
            ms.generateRandomSpot();
        }*/
    }
}
