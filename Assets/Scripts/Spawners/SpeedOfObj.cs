using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpeedOfObj : MonoBehaviour
{
    private float speed;    
    private void Start()
    {
        speed = RandomTime();
    }
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (gameObject.transform.position.x < -11f)
        {
            Destroy(gameObject);
        }
    }
    private float RandomTime()
    {
        return Random.Range(2, 6);
    }

}
