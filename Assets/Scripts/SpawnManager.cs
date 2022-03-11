using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn",1.0f,5.0f);
    }

    // Update is called once per frame
    void spawn()
    {
        Instantiate(enemy, new Vector3(14, -3, 0), Quaternion.identity);
    }
}
