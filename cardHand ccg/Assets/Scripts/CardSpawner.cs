using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    [SerializeField] GameObject card;
    [SerializeField] List<GameObject> targets = new List<GameObject>();
    public List<GameObject> cards = new List<GameObject>();
    int cardRandimNum = 0;
    void Start()
    {
        cardRandimNum = Random.Range(4, 6);
        InstantiateCards();
    }


    void InstantiateCards()
    {
        for (int i = 0; i < cardRandimNum; i++)
        {
            GameObject g = Instantiate(card, targets[i].transform);
            g.transform.position = targets[i].transform.position;
            g.transform.rotation = targets[i].transform.rotation;
            cards.Add(g);
        }
    }

    
}
