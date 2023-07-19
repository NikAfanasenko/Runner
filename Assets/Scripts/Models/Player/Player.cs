public abstract class Player 
{
    protected Wallet _wallet;
    protected HealthBar _healthBar;
    protected PlayerMoving _mooving;

    public Player(Wallet wallet, HealthBar healthBar, PlayerMoving mooving)
    {
        _wallet = wallet;
        _healthBar = healthBar;
        _mooving = mooving;
    }

    public abstract void Move();
    public abstract void PickMoney();
    public abstract void TakeDamage();
}
