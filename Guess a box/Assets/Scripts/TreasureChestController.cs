using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureChestController : MonoBehaviour
{
    TIGameManager ts;
    Text goldScore;
    int goldValue;

    //OPTIONAL - IF WE HAVE ENOUGH TIME ON WEEK 3
    public Animator anim;
    public Light goldLight;

    private void Start()
    {
        goldScore = GameObject.Find("GoldScore").GetComponent<Text>();
        ts = GameObject.Find("GameManager").GetComponent<TIGameManager>();

        ts.UpdateGoldValues();
        goldValue = ts.GetGoldValue();
    }

    private void OnMouseDown()
    {
        Debug.Log(goldValue.ToString());
        Debug.Log("CLicked " + this.name);

        anim.SetTrigger("OpenChest");
        
        if(goldValue > 0)
        {
            goldLight.color = new Color32(253, 255, 0, 255);
        }
        else
        {
            goldLight.color = new Color32(255, 30, 0, 255);
        }

        if(goldValue > 0)
        {
            TIGameManager.totalGold += goldValue;
            goldScore.text = "GOLD: " + TIGameManager.totalGold.ToString();
        }
        else
        {
            goldScore.text = " YOU LOSE! ";
            TIGameManager.totalGold = 0;
        }

        ts.UpdateGoldValues();
        goldValue = ts.GetGoldValue();
    }
}
