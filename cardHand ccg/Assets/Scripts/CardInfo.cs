using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardInfo : MonoBehaviour
{
    private int helthPoints;
    private int damagePoints;
    private int mannaPoints;
    private RawImage cardImage;
    private string cardName;
    private string cardDiscription;


    public int SetHelth(int hp)
    {
        helthPoints = hp;
        return helthPoints;
    }
    public int SetManna(int mp)
    {
        mannaPoints = mp;
        return mannaPoints;
    }  
    public int SetDamage(int dp)
    {
        damagePoints = dp;
        return damagePoints;
    }
    public string SetName(string name)
    {
        cardName = name;
        return cardName;
    }
    public string SetDiscription(string discription)
    {
        cardDiscription = discription;
        return cardDiscription;
    }

    public int GetHelth()
    {
        return helthPoints;
    }
    public int GetManna()
    {
        return mannaPoints;
    }
    public int GetDamage()
    {
       return damagePoints;
    }
    public string GetName()
    {
        return cardName;
    }
    public string GetDiscription()
    {
        return cardDiscription;
    }
}
