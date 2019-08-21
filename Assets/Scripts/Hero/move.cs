using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private readonly float m_speed = 5f;
    private bool isJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (this.transform.position.x - m_speed * Time.deltaTime > 0)
            {
                this.transform.Translate(Vector3.left * m_speed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (this.transform.position.x + m_speed * Time.deltaTime < 7.5)
            {
                this.transform.Translate(Vector3.right * m_speed * Time.deltaTime);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200));
            isJump = true;
        }
    }

    // OnCollisionEnter2D detects if there is a collision with an obstacle.
    // If the impulse is too large, hero is destroyed.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "block")
        {
            
            if (collision.relativeVelocity.sqrMagnitude >= 10.0)
            {
                //Debug.Log("销毁");
                Destroy(this.gameObject);
            }
        }
        if(collision.gameObject.tag == "ground")
        {
            isJump = false;
        }
    }


    // OnGUI is used to pop up prompt information.
    void OnGUI()
    {
        //if (isDestory)
        //{
            //Debug.Log("Dialog");
            GUI.Box(new Rect(0, 0, 5, 5), "failure");
        //}
    }
}
