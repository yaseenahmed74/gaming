using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float movespeed;
    public float jumppeed;
    public KeyCode spacebar;
    public KeyCode R;
    public KeyCode L;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Spacebar)){
            Jump();
        }

        if (Input.GetKey(L)){
            GetComponenet<Rigidbody2D>().velocity=new Vector2(-moveSpeed,GetComponenet<Rigidbody2D>().Velocity.y);

        }
 

        if (Input.GetKey(R)){
            GetComponenet<Rigidbody2D>().velocity=new Vector2(moveSpeed,GetComponenet<Rigidbody2D>().Velocity.y);

        }

        
    }
    void jump ()
    {
        GetComponenet<Rigidbody2D>().velocity=new Vctor2(GetComponenet<Rigidbody2D>().Velocity.x,jumpHeight);
    }
}
