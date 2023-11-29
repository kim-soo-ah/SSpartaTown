using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            playerName.text = PlayerPrefs.GetString("Name");
        }


    }
}
