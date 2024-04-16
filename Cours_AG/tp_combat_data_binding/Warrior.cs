using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_combat_data_binding
{
    public class Warrior : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Attack { get; set; }

        private int hp;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int HP
		{
			get { return hp; }
			set 
			{
				if (hp != value)
				{
					hp = value;
					NotifyPropertyChanged("HP");
				}
			}
		}

		public void NotifyPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public Warrior(string initName)
		{
			Name = initName;
			HP = 100;
			Attack = 10;
		}

        public Warrior(string initName, int initAttack)
        {
            Name = initName;
            HP = 100;
            Attack = initAttack;
        }

        public void AttackWarrior(Warrior targetedWarrior)
		{
			targetedWarrior.HP -= Attack;
		}

	}
}
