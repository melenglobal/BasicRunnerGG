using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float leftBound = -250;
    [SerializeField] float Speed = 3;
    [SerializeField] float spinSpeed = 30;

    PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Awake()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

        if (playerMovement.gameOver == false)
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            transform.Rotate(Vector3.down * spinSpeed * Time.deltaTime);
        }

        if (transform.position.z < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
    }
}
