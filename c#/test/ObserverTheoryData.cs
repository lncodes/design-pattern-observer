using Xunit;
using System.Collections.Generic;

namespace Lncodes.DesignPattern.Observer.Test
{
    public sealed class ObserverTheoryData : TheoryData<IEnumerable<EnemyObserver>, IEnumerable<uint>>
    {
        public ObserverTheoryData()
        {
            Add(new EnemyObserver[] { new OrcEnemyObserver() }, new uint[] { 90 });
            Add(new EnemyObserver[] { new OrcEnemyObserver(), new SlimeEnemyObserver() }, new uint[] { 90, 20 });
            Add(new EnemyObserver[] { new OrcEnemyObserver(), new SlimeEnemyObserver(), new GoblinEnemyObserver() }, new uint[] { 90, 20, 40 });
        }
    }
}