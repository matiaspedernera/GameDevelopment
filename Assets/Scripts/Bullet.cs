using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 1.5f;
    [SerializeField] private float timeToDestroy;
    private float countdownToDestroy = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Debug.Log(countdownToDestroy += Time.deltaTime);
        countdownToDestroy += Time.deltaTime;
        if (countdownToDestroy >= timeToDestroy)
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAaaaa");
            Destroy(gameObject);
        }

    }

    public void Move()
    {
        transform.position += speed * Time.deltaTime * transform.forward * -1;
    }
}
