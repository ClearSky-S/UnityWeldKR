using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld;
using UnityWeld.Binding;

namespace UnityWeld_Demo
{
    [Binding]
    public class PlusMinusItem : ViewModel
    {
        private bool _isPlus;

        [Binding]
        public bool IsPlus
        {
            get => _isPlus;
            set
            {
                _isPlus = value;
                OnPropertyChanged(nameof(IsPlus));
            }
        }
    }
}
