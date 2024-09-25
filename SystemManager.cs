namespace Gomoku
{
    public class SystemManager
    {
        public void ShutDown(ISystem system)
        {
            system.End();
        }

        private static SystemManager _instance = null;
        public static SystemManager Instance => _instance ?? (_instance = new SystemManager());
    }
}