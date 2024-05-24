using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject _gameOverCanvas;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        Time.timeScale = 1f;
    }
}
