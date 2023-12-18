using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateList : MonoBehaviour
{
    private string[] List = { "Cameron", "Marius", "Sally", "Bob", "Lilly", "Evan", "Ethan", "Nicole", "Jessica", "Henry", "Noah", "Harper", "Mia", "Samantha", "Omar", "Theodore", "Ronald", "Megan", "Charlotte" };
    public string[] santasList;
    // Start is called before the first frame update
    void Start()
    {
        santasList = new string[5];

        for (int i = 0; i < 5; i++)
        {
            santasList[i] = List[Random.Range(0, 10)];
            Debug.Log(santasList[i]);
        }
    }
}
