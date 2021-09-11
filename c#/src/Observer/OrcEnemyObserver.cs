namespace Lncodes.DesignPattern.Observer
{
    public sealed class OrcEnemyObserver : EnemyObserver
    {
        public override uint Health { get; protected set; } = 100;

        /// <inheritdoc cref="GoblinEnemyObserver.TakeDamage(uint)"/>
        public override void TakeDamage(uint damage) =>
            Health -= damage;
    }
}