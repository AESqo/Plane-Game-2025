using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(1f, -1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(direction, -1, 0) * Time.deltaTime * 3f);
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
