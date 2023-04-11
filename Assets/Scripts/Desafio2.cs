using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    [SerializeField] private double life;
    [SerializeField] private double lifeHealed;
    [SerializeField] private double damageTaken;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 direction;
    [SerializeField] private Vector3 scale;
    [SerializeField] GameObject Character;
    // Start is called before the first frame update
    void Start()
    {
        // Character.transform.localScale = scale;
        // HealCharacter(lifeHealed);
    }

    // Update is called once per frame
    void Update()
    {
        // Move();
        // DamageCharacter(damageTaken);
    }

    public void Move()
    {
        Character.transform.position += speed * Time.deltaTime * direction;
    }

    public void HealCharacter(double lifeHealed) 
    {
        life += lifeHealed;
    }

    public void DamageCharacter(double damageTaken)
    {
        life -= damageTaken;
    }
}
