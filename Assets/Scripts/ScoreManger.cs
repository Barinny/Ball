using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;

public class ScoreManger : MonoBehaviour
{
    public static ScoreManger Instance;

    public TMP_Text coinText;
    public int currentCoins = 0;


    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        coinText.text = currentCoins.ToString();
    }

    void Update()
    {

    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = currentCoins.ToString();
    }
}
