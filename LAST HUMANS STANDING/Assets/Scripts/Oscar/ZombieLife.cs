using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieLife : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] AudioClip ZombieDamageClip;
    [SerializeField] int MaxHealth;
    // Start is called before the first frame update
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    void Start()
    {
        MaxHealth = 5;
        health = MaxHealth;
    }

    public void Damage(int Amount)
{
    health -= Amount;
    AudioManager.Instance.PlaySFX(ZombieDamageClip);
    Death();
}

public void Death()
{
      if(health <= 0)
    {
        Destroy(gameObject);
        // Debug.Log("Death");
    }
}
}
