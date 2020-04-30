using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCounter : MonoBehaviour
{
    public int click = 0;
    public Text score;
    int index = 0;
    //int newIndex = 0;
    public List<Sprite> images;
    public Image backgroundContainer;
    
    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = "Clicks:" + click;

        if (Input.GetMouseButtonDown(0))
        {
            click += 1;
            if (click % 10 == 0)
            {
                CycleImages();
            }
        }
    }

    void CycleImages()
    {
        int newIndex = index + 1;
        if(newIndex >= images.Count)
        {
            newIndex = 0;
        }
        
        index = newIndex;
        
        backgroundContainer.sprite = images[index];

    }
}  