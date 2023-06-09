using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayAtItem : MonoBehaviour
{
    public Transform playerPos;

    public int getKeyNum;

    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        Debug.DrawRay(transform.position, transform.forward, Color.red, 5f);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 5f, LayerMask.GetMask("Key")))
        {
            if (OVRInput.Get(OVRInput.Button.One))
            {
                hit.collider.gameObject.SetActive(false);
                getKeyNum++;
            }
        }
    }
}
