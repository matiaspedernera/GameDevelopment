using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private KeyCode shootKeyCode;
    [SerializeField] private KeyCode shootTwice;
    [SerializeField] private KeyCode shootThreeTimes;
    [SerializeField] private KeyCode shootFourTimes;
    [SerializeField] private GameObject Bullet;

    private void Update()
    {
        if (Input.GetKeyDown(shootKeyCode))
        {
            Debug.Log("Shoot Once");
            Shoot();
        }
        if (Input.GetKeyDown(shootTwice))
        {
            Debug.Log("Shoot Twice");
            Shoot();
            Shoot();
        }
        if (Input.GetKeyDown(shootThreeTimes))
        {
            Debug.Log("Shoot Three times");
            Shoot();
            Shoot();
            Shoot();
        }
        if (Input.GetKeyDown(shootFourTimes))
        {
            Debug.Log("Shoot Four times");
            Shoot();
            Shoot();
            Shoot();
            Shoot();
        }

    }

    private void Shoot()
    {
        Instantiate(Bullet, transform.position, Quaternion.identity);
    }
}