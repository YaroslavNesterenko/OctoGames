using DTT.MinigameMemory;
using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameManager : MonoBehaviour
{
    [SerializeField] private MemoryGameManager memoryGameManager;

    [SerializeField] private MemoryGameSettings memoryGameSettings;

    [SerializeField] private GameObject backgroundImage;

    public async Task PlayGame()
    {
        backgroundImage.SetActive(true);
        memoryGameManager.StartGame(memoryGameSettings);

        while (memoryGameManager.IsGameActive)
        {
            await Task.Delay(100);
        }

        backgroundImage.SetActive(false);
        memoryGameManager.DisableBoard();
    }
}
