namespace Lncodes.DesignPattern.Observer
{
    public sealed class SlimeEnemyObserver : EnemyObserver
    {
        public override uint Health { get; protected set; } = 30;

        /// <inheritdoc cref="GoblinEnemyObserver.TakeDamage(uint)"/>
        public override void TakeDamage(uint damage) =>
            Health -= damage;
    }
}