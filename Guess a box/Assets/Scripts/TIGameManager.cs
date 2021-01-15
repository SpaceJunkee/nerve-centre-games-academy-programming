using UnityEngine;

public class TIGameManager : MonoBehaviour
{
  
    int largeGold = 0;
    int mediumGold = 0;
    int smallGold = 0;
    int noGold = 0;

    //Update values in Unity
    public int largeGoldMin, largeGoldMax;
    public int mediumGoldMin, mediumGoldMax;
    public int smallGoldMin, smallGoldMax;

    public static int totalGold = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateGoldValues();
    }

    public void UpdateGoldValues()
    {
        largeGold = Random.Range(largeGoldMin, largeGoldMax);
        mediumGold = Random.Range(mediumGoldMin, mediumGoldMax);
        smallGold = Random.Range(smallGoldMin, smallGoldMax);
        noGold = 0;
    }

    public int GetGoldValue()
    {
        int[] goldvalues = { largeGold, mediumGold, smallGold, noGold };

        return goldvalues[Random.Range(0, goldvalues.Length)];
    }

    public void EndGame()
    {
        Debug.Log("YOU LOSE!");
    }
}
