using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public bool isActiv;
    public float speed = 0.1f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > -4)
            {
                transform.position = new Vector3(this.gameObject.transform.position.x - speed, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < 4)
            {
                transform.position = new Vector3(this.gameObject.transform.position.x + speed, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            }
        }
    }
}
