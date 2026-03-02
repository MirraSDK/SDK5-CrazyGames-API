using CrazyGames;
using MirraGames.SDK.Common;

namespace MirraGames.SDK.CrazyGames
{
    [Provider(typeof(IBootstrap))]
    public class CrazyGamesBootstrap : CommonBootstrap
    {
        public CrazyGamesBootstrap(IEventDispatcher eventDispatcher)
        {
            eventDispatcher.Start += EventDispatcher_Start;
        }

        private void EventDispatcher_Start()
        {
            CrazySDK.Init(() =>
            {
                SetInitialized();
            });
        }
    }
}