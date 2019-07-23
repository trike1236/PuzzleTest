using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class TimerView : MonoBehaviour
{
    [SerializeField]
    private UIManager UIManager;
    [SerializeField]
    private Text counterText;

    // Start is called before the first frame update
    void Start()
    {
        UIManager.OnTimeChanged.Subscribe(puzzleWords =>
        {
            string text = "";
            puzzleWords.ForEach(s => text += (s + "\n"));
            counterText.text = text;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
