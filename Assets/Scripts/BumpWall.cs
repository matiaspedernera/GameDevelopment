using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    [SerializeField] private Transform[] m_randomPositions;
    private float coundownToWall = 2f;


    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            
            coundownToWall -= Time.fixedDeltaTime;
            if (coundownToWall < 0)
            {
                SetRandomPosition();
                coundownToWall = 2f;
            }
        }
    }

    /// <summary>
    /// Call this function to set a random position to the object
    /// </summary>
    /// 
    private void SetRandomPosition()
    {
        transform.SetPositionAndRotation(m_randomPositions[Random.Range(0, m_randomPositions.Length)].position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
    }
}