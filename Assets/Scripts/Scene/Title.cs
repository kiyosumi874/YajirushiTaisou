using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    [SerializeField] DificultSelector dificultSelector;

    void Start()
    {
        dificultSelector.InitializeOnce();
    }
}
