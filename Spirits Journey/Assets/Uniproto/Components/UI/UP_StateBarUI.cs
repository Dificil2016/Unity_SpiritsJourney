using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UP_StateBarUI : MonoBehaviour
{

    [SerializeField] Sprite[] sprites;

    [SerializeField] UP_Counter counter = null;

    [SerializeField] Image barImage = null;


    void Update()
    {
        if (counter.Counter <= sprites.Length)
        {
            int value = counter.Counter;
            barImage.sprite = sprites[value];
        }
    }
}
