using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform ShootPos;

    public float Timer;

    private bool Shoot1;
    
    public GameObject Bullet;

    public float speed;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Shoot1 = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) &&  !Shoot1)
        {
            //Attacking
            StartCoroutine(Fire());

        }
    }

    IEnumerator Fire()
    {
        Shoot1=true;
        GameObject newArc =Instantiate(Bullet, ShootPos.position ,Quaternion.identity);
        newArc.GetComponent<Rigidbody2D>().velocity = new Vector2 (speed * Time.fixedDeltaTime , 0f);
        yield return new WaitForSeconds(Timer);
        Shoot1=false;
    }
}
