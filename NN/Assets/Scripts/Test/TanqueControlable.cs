using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanqueControlable : TankBase
{
    // Start is called before the first frame update
    public Bullet bullet;
    public GameObject spawnerBullet;
    private void Update()
    {
        CheckInput();
    }
    public void CheckInput()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            SetForces(Speed,-Speed,Time.deltaTime,false);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            SetForces(-Speed,Speed, Time.deltaTime,false);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            SetForces(Speed,Speed,Time.deltaTime,false);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            SetForces(Speed,Speed,Time.deltaTime,true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        Instantiate(bullet.gameObject, spawnerBullet.transform.position, spawnerBullet.transform.rotation);
    }
}
