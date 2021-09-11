namespace Lncodes.DesignPattern.Observer
{
    public abstract class EnemyObserver
    {
        public abstract uint Health { get; protected set; }

        /// <summary>
        /// Method to take damage
        /// </summary>
        /// <param name="damage"></param>
        public abstract void TakeDamage(uint damage);
    }
}
