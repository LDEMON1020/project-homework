using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UImanager : MonoBehaviour
{
    // Start is called before the first frame update
public void GameStartButtonAction()
    {
       SceneManager.LoadScene("Level_1");
    }
}
