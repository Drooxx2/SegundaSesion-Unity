using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite back;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = back;
        transform.position = new Vector3(-1, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
