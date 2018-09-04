using Gameplay.GameElements;

namespace Gameplay.Contracts
{
    public interface ICondition
    {
        bool Check(GameEnvironment environnement);
    }
}
