using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{
    public void GoToSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
