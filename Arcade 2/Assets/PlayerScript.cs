using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed;
    //private float count = 0;
    private float x;
    private float y;
    private bool frozen;

    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        print("PlayerStart");
        frozen = false;

	}
	
	// Update is called once per frame
	void Update () {
        if (!frozen)
        {
            x = Input.GetAxis("Horizontal") * speed;
            y = Input.GetAxis("Vertical") * speed;
            
        }
        rb.velocity = (new Vector2(x, y));
        x = y = 0;

        

        //print(count);
        //rb.AddForce(new Vector2(x , y));

    }
    public void SpriteChange(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

    public void Freeze()
    {
        
        GetComponent<PlayerScript>().enabled = false;
        frozen = true;
        x = y = 0;
    }
    

}
