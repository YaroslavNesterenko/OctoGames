using Naninovel;
using Naninovel.Commands;
using System.Threading;
using System.Threading.Tasks;

[CommandAlias("questUpdate")]
public class QuestUpdateCommand : Command
{
    public StringParameter QuestName;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        if (string.IsNullOrEmpty(QuestName))
        {
            Engine.Err("Не указано имя квеста для обновления.");
        }
        else
        {
            UpdateQuest(QuestName);
        }

        return UniTask.CompletedTask;
    }

    private void UpdateQuest(string questName)
    {
        
        Engine.Log($"Квест '{questName}' был обновлён.");

        
    }
}
