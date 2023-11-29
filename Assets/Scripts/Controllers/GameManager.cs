using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_InputField inputName;

    
    public void GoToMain()
    {
        if (inputName.text.Length < 2) return;
        
        PlayerPrefs.SetString("Name", inputName.text);
        SceneManager.LoadScene("MainScene");
    }

    
    public void Load()
    {
        if(PlayerPrefs.HasKey("Name"))
        {
            inputName.text = PlayerPrefs.GetString("Name");
        }

        
    }
}
