using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI time;
    // Update is called once per frame
    void Update()
    {
        time.text = DateTime.Now.ToString("HH : mm");
    }
}
