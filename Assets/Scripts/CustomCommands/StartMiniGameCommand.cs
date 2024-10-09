using DTT.MinigameMemory;
using Naninovel;
using Naninovel.Commands;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

[CommandAlias("startMiniGame")]
public class StartMiniGameCommand : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        await StartMiniGame();
    }

    private async Task StartMiniGame()
    {

        Engine.Log("mini game start");
        MiniGameManager miniGameManager = GameObject.FindFirstObjectByType<MiniGameManager>();
        await miniGameManager.PlayGame();

        Engine.Log("Мини-игра завершена!");
    }
  
}
