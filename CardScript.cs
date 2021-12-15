using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite back;
    public Sprite front;
    public int numCard;
    private bool esFrontal;
    private SpriteRenderer _spriteRenderer;
    private GameManager _gameManager;
    private GameObject gameManager;
    

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController");
        _gameManager = gameManager.GetComponent<GameManager>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        _gameManager.clickOnCard(numCard);
        _spriteRenderer.sprite = (esFrontal) ? back : front;
        esFrontal = !esFrontal;
    }

    
}
