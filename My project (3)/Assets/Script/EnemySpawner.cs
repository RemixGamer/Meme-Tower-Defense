using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public float spawnRate;
    private float timeCounter = 0;
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeCounter > spawnRate)
        {
           GameObject newEnemy = Instantiate(enemy);
           newEnemy.transform.position = this.transform.position;
            newEnemy.GetComponent<EnemyMovement>().target = target;
            timeCounter = 0;
        }
        else
        {
            timeCounter += Time.deltaTime;
        }
    
    
    }   

    




}
