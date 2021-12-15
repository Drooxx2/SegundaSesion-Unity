using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public GameObject prefabCard;
    public List<GameObject> cardList = new List<GameObject>();
    public List<Sprite> spriteList = new List<Sprite>();
    public List<int> numCardList = new List<int> {7, 1, 0, 9, 6, 7, 1, 0, 9, 6 };
    private CardScript _cardScript;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        float posX = -6;
        float posY = 3;

        GameObject card;

        for(int i = 0; i < 10; i++)
        {
            //Instancia
            card = Instantiate(prefabCard, new Vector3(posX, posY, 0), Quaternion.identity);

            addCardInfo(card);

            card.name = "Card" + i;
            cardList.Add(card);

            posX += 3;
            
            if(i == 4)
            {
                posX = -6;
                posY = -2;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void addCardInfo(GameObject card)
    {
        _cardScript = card.GetComponent<CardScript>();
        randomIndex = Random.Range(0, spriteList.Count);

        _cardScript.front = spriteList[randomIndex];
        _cardScript.numCard = numCardList[randomIndex];

        numCardList.RemoveAt(randomIndex);
        spriteList.RemoveAt(randomIndex);
    }

    public void clickOnCard(int num)
    {
        Debug.Log("Has clicado la carta: " + num);
    }
}
