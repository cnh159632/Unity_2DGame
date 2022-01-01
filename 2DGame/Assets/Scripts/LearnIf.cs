﻿using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;

    private void Start()
    {
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }

    public int score = 100;

    private void Update()
    {
        if (score >= 60)
        {
            print("及格");
        }
        else if(score >= 40)
        {
            print("補考");
        }
        else
        {
            print("重修");
        }
    }
}
