using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public int collisionPoint = 10;
//    public PlayerHealth playerHealth ;
//    public EnemyHealth enemyHealth;
    GameObject player;
//    private bool point;
//    private GameObject enemy;
    private PlayerHealth playerHealth;
    float timer;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
       // enemy = GameObject.FindGameObjectWithTag("Enemy");


    }

    public void OnCollisionEnter(Collision col)
    {
        timer += Time.deltaTime;
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject, 0f);
            
           playerHealth.PointFood(collisionPoint);
           ScoreManager.score += 10;
        }
        
            if (timer == 3f)
            {
                Destroy(gameObject, 0f);
                timer = 0f;
            }
        }
       
        
    }
        
        
    

