using System.Collections.Generic;

namespace Gomoku
{
    public abstract class GameBase
    {
        private readonly HashSet<ISystem> _systems = new HashSet<ISystem>();
        public bool IsRunning { get; private set; } = false;
        public bool Inited { get;private set; }

        protected virtual void Init()
        {
            if (Inited)
            {
                return;
            }
            IsRunning = true;
            //清空所有系统
            _systems.ForEach(SystemManager.Instance.ShutDown);
            _systems.Clear();
            //使用反射获取所有ISystem子类型并注册实例
            ReflectionUtils.EnumerateSubclasses<ISystem>(RegisterSystem);
            
            Inited = true;
        }


        private void RegisterSystem(ISystem system)
        {
            system.Init();
            _systems.Add(system);
        }


        private void UnregisterSystem(ISystem system)
        {
            system.End();
            _systems.Remove(system);
        }

        public virtual void Tick()
        {
            if (!IsRunning) return;
            foreach (var system in _systems)
            {
                system.Tick();
            }
        }

        public virtual void End()
        {
            IsRunning = false;
        }

    }
}