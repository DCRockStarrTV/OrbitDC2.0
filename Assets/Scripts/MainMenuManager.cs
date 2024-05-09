using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
   
    public void ClickedPlay()
    {
        SceneManager.LoadScene(Constants.DATA.GAMEPLAY_SCENE);
    }

    public void ClickedQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    
}
