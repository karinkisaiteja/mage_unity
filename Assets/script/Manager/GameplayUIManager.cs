using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameplayUIManager : MonoBehaviour
{
    public static GameplayUIManager Instance;
    public Text _scoretext;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    private void Start()
    {
        _scoretext.text = "score : " + 0;
    }
}
