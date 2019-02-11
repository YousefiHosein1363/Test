using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkDragonManager : MonoBehaviour
{
    public GameObject darkDragon;
    public GameObject player;
    

    // Start is called before the first frame update
    void awake()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
      
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.score == 100 )
        {
            
            Instantiate(darkDragon, player.transform.position, player.transform.rotation);
        }
    }
}
