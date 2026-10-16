using UnityEngine;

public class MainTower : MonoBehaviour
{
    public int health = 100;
    
    public void getDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
