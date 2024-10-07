using Naninovel;
using Naninovel.Commands;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

[CommandAlias("startMiniGame")]
public class StartMiniGameCommand : Command
{
    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        Task task = StartMiniGame();
        return UniTask.CompletedTask;
    }

    /*public override async UniTask ExecuteAsync(CancellationToken cancellationToken = default)
{
   // Здесь вызываем метод для запуска мини-игры
   await StartMiniGame();
}*/

    private async Task StartMiniGame()
    {
        // Логика вашей мини-игры
        // Например, показываем UI мини-игры
        // Можно использовать Coroutine для асинхронного выполнения

        // Пример задержки для имитации времени игры
        await Task.Delay(1000);

        UnityEngine.Debug.Log("mini game");

        // Логика завершения игры
        // Здесь можно обработать результат игры
        // Например, сообщить о победе или поражении
        Engine.Log("Мини-игра завершена!");
    }
}
