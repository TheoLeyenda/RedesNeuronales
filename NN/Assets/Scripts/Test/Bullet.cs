using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float timeLife;
    public Rigidbody rg;

    private void Start()
    {
        rg.AddRelativeForce(speed * Vector3.forward, ForceMode.Impulse);
    }
    private void Update()
    {
        if (timeLife > 0)
        {
            timeLife = timeLife - Time.deltaTime;
        }
        else if (timeLife <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
