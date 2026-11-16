using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public TMP_Text Foodcounter;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Updatescore(int playerscore)
    {
        Foodcounter.text = "score = " + playerscore;
    }
}


