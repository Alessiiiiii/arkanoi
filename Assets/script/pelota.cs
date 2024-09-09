using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class pelota : MonoBehaviour
{
    [SerializeField] private Vector2 initialVelocity;

    private Rigidbody2D pelotaRb;
    private bool ispelotaMoving;

    // Start is called before the first frame update
    void Start()
    {
        pelotaRb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& !ispelotaMoving)
        {
            transform.parent=null;
            pelotaRb.velocity = initialVelocity;
            ispelotaMoving=true;
        }
    }
}
