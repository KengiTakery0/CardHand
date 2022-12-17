using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.Networking;
using UnityEngine.UI;
public class GenerateCard : MonoBehaviour
{
    CardSpawner spawner;
    CardInfo cardInfo;
    int maxValue = 9;
    int minValue = -2;

    private string imageUrl = "http://picsum.photos/200/300";


    private List<string> cardNames = new List<string>()
    {
        "dfghj","cdtfvgybh","cvbn fvbn","cdfvg bhnvfef","fhv y uuffff","cg vhefef"
    };
    private List<string> cardDiscriptions = new List<string>()
    {
        "ijnbfdcvbhnmklkjhgf dderthjkmnbvfdcv sdxcfvgbhnj xdcfvgbhn",
        "lkjh lokiujhygt ,mnb poiuyt oikmjnhbgv ujkmnhbgtyuijhnbgfrt kjuygbnjuy",
        "fghjkl tvgubhinjmk vgubhinjmk fvygubhinjomk fvgyubhnjmk fgyvubhinj gvubhin"

    };

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI hPText;
    [SerializeField] private TextMeshProUGUI dPText;
    [SerializeField] private TextMeshProUGUI mPText;
    [SerializeField] private TextMeshProUGUI discriptionText;
    [SerializeField] private RawImage cardImage;

    private void Awake()
    {
        cardInfo = GetComponent<CardInfo>();
        spawner = FindObjectOfType<CardSpawner>();  
        CreateCard();
        while(cardInfo.GetHelth() <= 0 || cardInfo.GetManna() <= 0 || cardInfo.GetDamage() <= 0)
        {
            CreateCard();
            
        }
    }
    
    private void CreateCard()
    {
        GenerateImage();
        GenerateMP();
        GenerateDP();
        GenerateHP();
        GenerateName();
        GenerateDiscription();
    }

    private void GenerateDP()
    {
        cardInfo.SetDamage(Random.Range(minValue, maxValue));
        dPText.text = cardInfo.GetDamage().ToString();
    }

    private void GenerateHP()
    {
        cardInfo.SetHelth(Random.Range(minValue, maxValue));
        hPText.text = cardInfo.GetHelth().ToString();
    }
    private void GenerateMP()
    {
        cardInfo.SetManna(Random.Range(minValue, maxValue));
        mPText.text = cardInfo.GetManna().ToString();
    }

    private void GenerateName()
    {
        cardInfo.SetName(cardNames[Random.Range(0, cardNames.Count)]).ToString();
        nameText.text = cardInfo.GetName();
    }
    private void GenerateImage()
    {
        StartCoroutine(DownloadImage(imageUrl));
    }
    private void GenerateDiscription()
    {
        cardInfo.SetDiscription(cardDiscriptions[Random.Range(0, cardDiscriptions.Count)]).ToString();
        discriptionText.text = cardInfo.GetDiscription();
    } 

    IEnumerator DownloadImage(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(request.error);
        }
        else
        {
            cardImage.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
        }
    }


}
