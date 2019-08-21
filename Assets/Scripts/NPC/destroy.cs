using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localPosition.x < -5.0 || this.transform.localPosition.y < -5.0)
        {
            Destroy(this.gameObject);
        }
        //var collider = gameObject.GetComponent<Collider2D>();
        //if (collider)
        //{
        //    Destroy(collider);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "block")
        {

            if (collision.relativeVelocity.sqrMagnitude >= 10.0)
            {
                //Debug.Log("销毁");
                //Destroy(this.gameObject);
            }
        }
    }
}
