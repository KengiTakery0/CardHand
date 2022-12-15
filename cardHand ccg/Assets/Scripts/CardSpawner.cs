using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    [SerializeField] GameObject card;
    List<GameObject> cards = new List<GameObject>();
    [SerializeField] List<GameObject> targets = new List<GameObject>();
    int cardRandimNum = 0;
    void Start()
    {
        cardRandimNum = Random.Range(4, 6);
        InstantiateCards();
    }


    // Update is called once per frame
    void Update()
    {
    }

    void InstantiateCards()
    {
        for (int i = 0; i < cardRandimNum; i++)
        {
            cards.Add(card);
            GameObject g = Instantiate(cards[i], targets[i].transform);
            g.transform.position = targets[i].transform.position;
        }
    }
}
