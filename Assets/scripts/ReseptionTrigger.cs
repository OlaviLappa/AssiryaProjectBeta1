using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReseptionTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Application.OpenURL("http://assyrian.beget.tech/");
        }
    }
}
