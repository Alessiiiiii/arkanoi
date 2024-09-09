using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class player : MonoBehaviour 

{

  [SerializeField]  private float moveSpeed;

    private float bounds = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
       // transform.position += new Vector3(moveInput * moveSpeed * Time.deltaTime, 0f, 0f);

        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x+moveInput* moveSpeed*Time.deltaTime,-bounds,bounds);
        transform.position = playerPosition;
    }
}
