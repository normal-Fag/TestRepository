using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float health = 50f;

    public void takeDamage(float dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
