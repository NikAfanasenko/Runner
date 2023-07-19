public class BasePlayer : Player
{
    public BasePlayer(Wallet wallet, HealthBar healthBar, PlayerMoving mooving) : base(wallet, healthBar, mooving)
    {
    }

    public override void Move()
    {
        _mooving.Move();
    }

    public override void PickMoney()
    {
        _wallet.Pick();
    }

    public override void TakeDamage()
    {
        _healthBar.TakeDamage();
    }
}
