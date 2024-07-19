using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld;
using UnityWeld.Binding;

namespace UnityWeld_Demo
{
    [Binding]
    public class DemoViewModel : ViewModel
    {
        private int _count;

        [Binding]
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        private bool _isMinus;

        [Binding]
        public bool IsMinus
        {
            get => _isMinus;
            set
            {
                _isMinus = value;
                OnPropertyChanged(nameof(IsMinus));
            }
        }
        
        [Binding]
        public void OnClickAdd()
        {
            Count++;
            IsMinus = Count < 0;
        }
        [Binding]
        public void OnClickSubtract()
        {
            Count--;
            IsMinus = Count < 0;
        }
    }
}
