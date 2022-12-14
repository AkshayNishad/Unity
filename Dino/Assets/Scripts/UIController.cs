using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public Image h1, h2, h3;
    public Sprite hFull, hEmpty, hHalf;
    public Text gemText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateGemCount();
    }

    public void UpdateHealthDisplay()
    {
        switch(PlayerHealthController.instance.curHealth)
        {
            case 6:
                h1.sprite = hFull;
                h2.sprite = hFull;
                h3.sprite = hFull;

                break;

            case 5:
                h1.sprite = hFull;
                h2.sprite = hFull;
                h3.sprite = hHalf;

                break;

            case 4:
                h1.sprite = hFull;
                h2.sprite = hFull;
                h3.sprite = hEmpty;

                break;

            case 3:
                h1.sprite = hFull;
                h2.sprite = hHalf;
                h3.sprite = hEmpty;

                break;

            case 2:
                h1.sprite = hFull;
                h2.sprite = hEmpty;
                h3.sprite = hEmpty;

                break;

            case 1:
                h1.sprite = hHalf;
                h2.sprite = hEmpty;
                h3.sprite = hEmpty;

                break;

            case 0:
                h1.sprite = hEmpty;
                h2.sprite = hEmpty;
                h3.sprite = hEmpty;

                break;

            default:
                h1.sprite = hEmpty;
                h2.sprite = hEmpty;
                h3.sprite = hEmpty;

                break;

        }
    }

    public void UpdateGemCount()
    {
        gemText.text = LevelManager.instance.gemsCollected.ToString();
    }
}