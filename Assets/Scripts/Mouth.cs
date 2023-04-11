using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float timeToCreate;
    private float countdownToCreate = 0;
    void Start()
    {
        //ShootBullet();
    }

    // Update is called once per frame
    void Update()
    {
        countdownToCreate += Time.deltaTime;
        if ( countdownToCreate >= timeToCreate)
        {
            countdownToCreate = 0;
            ShootBullet();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoubleSize();
        }
    }

    public void DoubleSize()
    {
        Bullet.transform.localScale = Bullet.transform.localScale * 2;
    }

    public void ShootBullet()
    {
        Instantiate(Bullet, transform.position, Quaternion.identity);
    }
}
