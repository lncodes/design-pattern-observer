using System.Collections.Generic;

namespace Lncodes.DesignPattern.Observer
{
    public sealed class AreaSubject
    {
        private readonly HashSet<EnemyObserver> _enemyObservers = new HashSet<EnemyObserver>();

        /// <summary>
        /// Method to attach enemy to the area
        /// </summary>
        /// <param name="enemyObserver"></param>
        public void Attach(EnemyObserver enemyObserver) =>
            _enemyObservers.Add(enemyObserver);

        /// <summary>
        /// Method to detach enemy from the area
        /// </summary>
        /// <param name="enemyObserver"></param>
        public void Detach(EnemyObserver enemyObserver) =>
            _enemyObservers.Remove(enemyObserver);

        /// <summary>
        /// Method to take area damage for all enemy
        /// </summary>
        public void TakeAreaDamage()
        {
            foreach (var item in _enemyObservers)
                item.TakeDamage(10);
        }
    }
}