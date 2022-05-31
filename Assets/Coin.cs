using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gamemanager;
    // Start is called before the first frame update
    private void Start()
    {
        GameObject managerObject = GameObject.Find("GameManager");
        gamemanager = managerObject.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gamemanager.AddCoinCount();
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
