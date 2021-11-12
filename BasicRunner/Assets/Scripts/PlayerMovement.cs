using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int health = 1000;
    [SerializeField] float rotateSpeed = 5f;
    [SerializeField] float movementSpeed = 5f;
    float rotateScale = 1;
    float movementSide = 0;
    int collectedGold = 0;
    float objectHeight = .01f;
    float maxObjectHeight = .03f;
    public bool gameOver = false;

    public TMP_Text _score;
    public TMP_Text _highScore;
    private int score;
    private int highScore;


    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        _highScore.text = "0" + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        rotateScale = Input.GetAxis("Horizontal");
        movementSide = Input.GetAxis("Vertical");
        transform.Rotate(0, rotateSpeed * rotateScale * Time.deltaTime, 0);
        transform.Translate(0, 0, movementSpeed * movementSide * Time.deltaTime);

        if (highScore < score)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    public void TakeDamage(float damage)
    {
        health--;
        objectHeight -=damage;
        if (objectHeight >= 0)
        {
            transform.localScale = new Vector3(1, objectHeight, 1);
        }
        else
        {
            Debug.LogError("Dead");
        }
        
        //health UI
    }
    public void CollectGold()
    {
        collectedGold++;
        score++;
        _score.text = "0" + score.ToString();
        //score board
    }
    public void CollectableAdd()
    {
        objectHeight++;
        if (objectHeight<=maxObjectHeight)
        {
            transform.localScale = new Vector3(1, objectHeight, 1);
        }
        
    }

    
}
