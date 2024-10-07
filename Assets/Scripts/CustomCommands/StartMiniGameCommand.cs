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
   // ����� �������� ����� ��� ������� ����-����
   await StartMiniGame();
}*/

    private async Task StartMiniGame()
    {
        // ������ ����� ����-����
        // ��������, ���������� UI ����-����
        // ����� ������������ Coroutine ��� ������������ ����������

        // ������ �������� ��� �������� ������� ����
        await Task.Delay(1000);

        UnityEngine.Debug.Log("mini game");

        // ������ ���������� ����
        // ����� ����� ���������� ��������� ����
        // ��������, �������� � ������ ��� ���������
        Engine.Log("����-���� ���������!");
    }
}
