using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject Camera1;
    [SerializeField] private GameObject Camera2;
    // Start is called before the first frame update
    void Start()
    {
        Camera1.SetActive(true); 
        Camera2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TurnCamerasOnAndOff();
        }
    }

    private void TurnCamerasOnAndOff()
    {
        Camera1.SetActive(!Camera1.activeSelf);
        Camera2.SetActive(!Camera2.activeSelf);
    }
}
