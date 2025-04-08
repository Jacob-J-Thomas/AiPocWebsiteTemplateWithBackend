using System.Collections.Generic;
using System.Threading.Tasks;
using ConversationalAIWebsite.Business;
using ConversationalAIWebsite.Client.IntelligenceHub;
using ConversationalAIWebsite.DAL;
using ConversationalAIWebsite.Host.Config;
using Moq;
using Xunit;

namespace ConversationalAIWebsite.Tests.Unit.Business
{
    public class PromptFlowLogicTests
    {
        private readonly Mock<IAIClientWrapper> _mockAiClient;
        private readonly Mock<AppDbContext> _appDbContext;
        private readonly Mock<StripeSettings> _stripeSettings;
        private readonly PromptFlowLogic _promptFlowLogic;

        public PromptFlowLogicTests()
        {
            _mockAiClient = new Mock<IAIClientWrapper>();
            _promptFlowLogic = new PromptFlowLogic(_mockAiClient.Object, _appDbContext.Object, _stripeSettings.Object);
        }
    }
}