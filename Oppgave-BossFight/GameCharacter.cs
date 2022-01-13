using System;

namespace Oppgave_BossFight
{
    public class GameCharacter
    {
        public int _health;
        public int _strength;
        public int _stamina;
        public bool _alive;
        public int _maxStamina;
        public string _name;

        public GameCharacter(int health, int strength, int stamina, string name)
        {
            _health = health;
            _strength = strength;   
            _stamina = stamina;
            _alive = true;
            _maxStamina = stamina;
            _name = name;
        }

        public void Fight(GameCharacter enemy)
        {
            if (_stamina <= 0)
            {
                Recharge();
            }
            else
            {
                enemy._health -= _strength;
                _stamina -= 10;
                Console.WriteLine(enemy._health);
                if (enemy._health <= 0)
                {
                    enemy._alive = false;
                }
            }
        }

        public void Recharge()
        {
            _stamina = _maxStamina;

            Console.WriteLine(_name + " Recharging....");
        }
    }
}