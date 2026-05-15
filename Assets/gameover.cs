using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public GameObject Personagem;
    private bool isGameOver = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Personagem)
        {
            isGameOver = true;
        }
        if(isGameOver)
        {
            Debug.Log("Game Over!");
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
}
