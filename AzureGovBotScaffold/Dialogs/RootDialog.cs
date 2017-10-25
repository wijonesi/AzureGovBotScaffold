using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace AzureGovBotScaffold.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var activity = await result;

            //await context.Forward(new GeneralQnAMakerDialog(), ResumeAfterGeneralQnADialog, activity, CancellationToken.None);

            
        }

        private async Task ResumeAfterGeneralQnADialog(IDialogContext context, IAwaitable<object> result)
        {
            var resultFromQnA = await result;

            context.Wait(this.MessageReceivedAsync);
        }
    }
}