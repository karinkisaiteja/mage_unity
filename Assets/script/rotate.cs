using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rotate : MonoBehaviour
{
    [SerializeField]private int _speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("connected");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("connected");
        transform.Rotate(new Vector3(0, 10, 0) *_speed* Time.deltaTime);
    }
   
}
