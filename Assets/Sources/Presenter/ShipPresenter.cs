using UnityEngine;

public class ShipPresenter : Presenter
{
    private Root _init;

    public void Init(Root init)
    {
        _init = init;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            if (_init.Ship.Heathe>1)
            {
                _init.Ship.Heathe--;
            }
            else
            {
                _init.Ship.Destroy();
                _init.DisableShip();
            }
        }
    }
}
