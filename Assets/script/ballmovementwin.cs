using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballmovement : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private int _score;
    [SerializeField] private int _speed;
    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);
        _rb.AddForce(movement * _speed * Time.deltaTime, ForceMode.Impulse);
    }
    /* private void OnCollisionEnter(Collision collision)
     {
         Debug.Log("collided");
     }
     private void OnTriggerEnter(Collider other)
     {
         Debug.Log("On trigger enter");
         //if tag is Pickable, then make the pickable disappear
         if (other.gameObject.tag == "Pickable")
         {
             other.gameObject.SetActive(false);
         }
     }*/
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collosion");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (other.gameObject.tag == "Pickable")
        {
            other.gameObject.SetActive(false);
            _score += 10;
        }
        if (other.gameObject.tag == "skipscene")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

    }


}
