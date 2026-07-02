using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider Other)
    {
        Enemy enemy = Other.GetComponent<Enemy>();

        Destroy(enemy.gameObject);

        Destroy(gameObject);
    }
}
