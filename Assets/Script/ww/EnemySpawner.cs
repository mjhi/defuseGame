using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float spawnTime;

    [SerializeField]
    private Transform[] wayPoints;


    void Awake()
    {
        
    }

    private IEnumerator SpawnEnemy()
    {
        while(true)
        {
            GameObject clone = Instantiate(enemyPrefab);
            Enemy enemy = clone.GetComponent<Enemy>();

            enemy.Setup(wayPoints); //wayPoint 정보를 매개변수로 SetUp() 호출

            yield return new WaitForSeconds(spawnTime); //spawnTime 시간동안 대기
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RoundStart()
    {
         StartCoroutine("SpawnEnemy");
    }
}
