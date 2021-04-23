using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float speed = 5.0f;
    public float panSpeed = 20f;
    public  int coin;
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }

    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "altin")
        {
            coin++;
            coinText.text = coin.ToString();
            Destroy(collider.gameObject);
        }

    }

    void FixedUpdate()
    {

    }
}
