using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceBackGround : MonoBehaviour
{
    public float startX;
    public float endX;
    public float speed;

    private void Update()
    {
        if (transform.position.x >= endX)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(startX, transform.position.y);
        }
    }
}
