using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.y < -4.5f)
        {
            GameObject.Find("Main Camera").GetComponent<ScoreHeal>().DecreaseHeal();
            Destroy(this.gameObject);
         
            if (GameObject.Find("Main Camera").GetComponent<ScoreHeal>().Heals()  == 0)
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            GameObject.Find("Main Camera").GetComponent<ScoreHeal>().IncreaseScore();
        }
        if(collision.gameObject.name == "Ball")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(speed * 1, speed * 1, 0f);
        }
    }
}
