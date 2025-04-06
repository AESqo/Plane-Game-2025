using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool goingUp;
    public float speed;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(Deletion());

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Deletion()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameManager.AddScore(1);
            Destroy(this.gameObject);
        }
    }
}