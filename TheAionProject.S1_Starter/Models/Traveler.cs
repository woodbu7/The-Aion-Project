﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Traveler : Character
    {
        #region ENUMERABLES

        public enum Weapon
        {
            None,
            Laser,
            Sword,
            Knife,
            Pistol
        }

        #endregion

        #region FIELDS

        private string _homePlanet;
        private bool _isExperienced;
        private Weapon _weaponOfChoice;

        #endregion


        #region PROPERTIES

        public string HomePlanet
        {
            get { return _homePlanet; }
            set { _homePlanet = value; }
        }

        public bool IsExperienced
        {
            get { return _isExperienced; }
            set { _isExperienced = value; }
        }

        public Weapon WeaponOfChoice
        {
            get { return _weaponOfChoice; }
            set { _weaponOfChoice = value; }
        }


        #endregion


        #region CONSTRUCTORS

        public Traveler()
        {

        }

        public Traveler(string name, RaceType race, int spaceTimeLocationID, bool isExperienced) : base(name, race, spaceTimeLocationID)
        {

        }

        #endregion


        #region METHODS

        public override string Greeting()
        {
            return $"Hello, my name is {base.Name}, I am a {base.Race}, and I am from {_homePlanet}.";
        }

        public override string DefenseResponse()
        {
            return $"I am a {base.Race}! I will defeat you!";
        }

        #endregion
    }
}
