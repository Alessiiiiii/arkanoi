using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.WSA;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class pelota : MonoBehaviour
{
    [SerializeField] private Vector2 initialVelocity;
    [SerializeField] private float velocityMultiplayer;

    private Rigidbody2D pelotaRb;
    private bool ispelotaMoving;

    // Start is called before the first frame update
    void Start()
    {
        pelotaRb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !ispelotaMoving)
        {
            Launch();
        }
    }
         

    
    private void Launch()
    {
        transform.parent = null;
        pelotaRb.velocity = initialVelocity;
        ispelotaMoving = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ladrillo"))
        {
            Destroy(collision.gameObject);
            pelotaRb.velocity *= velocityMultiplayer;

            GameManager.Instance.ladrilloDestroyed();
        }

    }



}