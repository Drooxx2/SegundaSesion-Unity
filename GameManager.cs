using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public GameObject prefabCard;
    public List<GameObject> cardList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        float posX = -6;
        float posY = 3;
        GameObject card;
        for(int i = 0; i < 10; i++)
        {
            card = Instantiate(prefabCard, new Vector3(posX, posY, 0), Quaternion.identity);
            card.name = "Card" + i;
            cardList.Add(card);

            Debug.Log(posX + " " +posY);

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
}
