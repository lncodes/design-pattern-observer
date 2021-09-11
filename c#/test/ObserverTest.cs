using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace Lncodes.DesignPattern.Observer.Test
{
    public sealed class ObserverTest
    {
        [Theory]
        [ClassData(typeof(ObserverTheoryData))]
        public void Enemies_Health_ShouldEqual(IEnumerable<EnemyObserver> enemyObservers, IEnumerable<uint> expected)
        {
            var areaSubject = new AreaSubject();

            foreach (var item in enemyObservers)
                areaSubject.Attach(item);
            areaSubject.TakeAreaDamage();

            var actual = enemyObservers.Select(item => item.Health);
            Assert.Equal(expected, actual);
        }
    }
}