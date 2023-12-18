using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    
    public void gameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
