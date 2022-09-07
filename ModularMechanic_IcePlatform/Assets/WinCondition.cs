using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public float timer;
    public GameObject Player;
    
    public GameObject Finish;

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Finish"))
        {
            Finish.SetActive(true);
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
    }
}

