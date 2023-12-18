using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masterScript : MonoBehaviour
{
    public GameObject Present;
    public GameObject Coal; 
    void Start()
    {
        generateRandomSpot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateRandomSpot()
    {
        int thing = Random.Range(0, 2);
        if (thing == 0)
        {
            Present.transform.position = new Vector2(generateHouse(),2);
            Present.SetActive(true);

            Coal.SetActive(false);
            
        }
        else
        {
            Coal.transform.position = new Vector2(generateHouse(), 2);
            Coal.SetActive(true);
            Present.SetActive(false);
        }
    }

    public float generateHouse()
    {
        int house = Random.Range(0, 3);
        if (house == 0)
        {
            return -6.53f;
        }
        else if (house == 1)
        {
            return -0.19f;
        }
        else
        {
            return 6.53f;
        }
    }
}
