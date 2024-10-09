using Naninovel;
using Naninovel.Commands;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

[CommandAlias("questUpdate")]
public class QuestUpdateCommand : Command
{
    public StringParameter QuestName;
    private ShowQuestInfo showQuestInfo;

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
        if (!showQuestInfo)
        {
            showQuestInfo = GameObject.FindFirstObjectByType<ShowQuestInfo>();
        }

        showQuestInfo.AddQuestInfo(questName);
        Engine.Log($"Квест '{questName}' был обновлён.");
    }
}
