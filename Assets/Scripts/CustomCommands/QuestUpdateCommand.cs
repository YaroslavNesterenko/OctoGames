using Naninovel;
using Naninovel.Commands;
using System.Threading;
using System.Threading.Tasks;

[CommandAlias("questUpdate")]
public class QuestUpdateCommand : Command
{
    public StringParameter QuestName; // Имя квеста, который мы обновляем

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        if (string.IsNullOrEmpty(QuestName))
        {
            Engine.Err("Не указано имя квеста для обновления.");
        }
        else
        {
            // Логика обновления квеста
            UpdateQuest(QuestName);
        }

        return UniTask.CompletedTask; // Возвращаем завершение задачи
    }

    private void UpdateQuest(string questName)
    {
        // Здесь должна быть логика обновления состояния квеста
        // Например, можно взаимодействовать с вашей системой квестов
        // Для примера просто выведем сообщение в консоль

        Engine.Log($"Квест '{questName}' был обновлён.");

        // Вы можете добавить свою логику для обновления квеста, например:
        // QuestManager.UpdateQuestStatus(questName, newStatus);
    }
}
