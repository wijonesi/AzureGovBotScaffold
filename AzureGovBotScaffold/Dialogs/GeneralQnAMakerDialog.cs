using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using QnAMakerDialog;

namespace AzureGovBotScaffold.Dialogs
{
    [Serializable]
    [QnAMakerService("", "")]
    public class GeneralQnAMakerDialog : QnAMakerDialog<object>
    {
        public override async Task NoMatchHandler(IDialogContext context, string originalQueryText)
        {
            await context.PostAsync($"Sorry, I couldn't find an answer for '{originalQueryText}'.");
            context.Done(false);
        }

        public override async Task DefaultMatchHandler(IDialogContext context, string originalQueryText, QnAMakerResult result)
        {
            await context.PostAsync(result.Answer);
            context.Done(true);
        }
    }
}