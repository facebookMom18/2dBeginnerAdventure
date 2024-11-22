using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public object Rigidbody2d { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = Rigidbody2d.position;
        position.x = position.x + 5.0f * horizontal * Time.deltaTime;
        position.y = position.y + 5.0f * vertical * Time.deltaTime;

        rigidbody2d value = Rigidbody2d.MovePosition(position);

    }
}
