using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{
    private bool isShrinked = false;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && isShrinked)
        {

            other.transform.localScale = other.transform.localScale * 2;
            isShrinked = false;

        }
        else
        {
            other.transform.localScale = other.transform.localScale / 2;
            isShrinked = true;
        }
    }


}
