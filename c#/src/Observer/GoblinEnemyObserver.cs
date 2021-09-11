namespace Lncodes.DesignPattern.Observer
{
    public sealed class GoblinEnemyObserver : EnemyObserver
    {
        public override uint Health { get; protected set; } = 50;

        /// <inheritdoc cref="GoblinEnemyObserver.TakeDamage(uint)"/>
        public override void TakeDamage(uint damage) =>
            Health -= damage;
    }
}