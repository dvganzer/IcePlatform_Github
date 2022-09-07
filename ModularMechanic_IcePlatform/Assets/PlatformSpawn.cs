using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject IcePrefab;
    public float Timer;



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            StartTimer();
        }
        else if (Timer >= 1)
        {
            Instantiate(IcePrefab, transform.position - (transform.up * 2), transform.rotation);

            Timer = 0;
        }

    }
    void StartTimer()
    {
        Timer += 1 * Time.time;
    }
}

