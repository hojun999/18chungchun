using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public Transform startPos;

    private bool canGetKey;
    public int getKeyNum;
    private bool canClear;


    void Start()
    {
        gameObject.transform.position = startPos.position;

    }

    private void Update()
    {
        if (getKeyNum == 5)
            canClear = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Key"))
            canGetKey = true;
        else
            canGetKey = false;

        if (OVRInput.GetDown(OVRInput.Button.One) && canGetKey)
        {
            other.gameObject.SetActive(false);
            getKeyNum++;
        }

        if (OVRInput.GetDown(OVRInput.Button.One) && other.CompareTag("Door") && canClear)
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
