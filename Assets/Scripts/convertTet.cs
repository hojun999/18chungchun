using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class convertTet : MonoBehaviour
{
    public TMP_Text text;
    public GameObject player;
    private string val;

    void Update()
    {
        val = player.GetComponent<Test>().getKeyNum.ToString();
        text.text = val;
    }
}
