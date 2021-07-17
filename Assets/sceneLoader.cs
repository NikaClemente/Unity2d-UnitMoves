using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{

    public void LoadScene(int sceneID)
    {
      SceneManager.LoadScene(sceneID);
    }
    
}
