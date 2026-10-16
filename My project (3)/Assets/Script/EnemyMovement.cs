using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    public int damage = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;

        transform.position += direction.normalized * speed * Time.deltaTime;

        transform.rotation = Quaternion.LookRotation(direction);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MainTower"))
        {
            collision.gameeObject.GetComponent<MainTower>().GetDamage(damage);
            Destroy(gameObject);
        }
    }




}
