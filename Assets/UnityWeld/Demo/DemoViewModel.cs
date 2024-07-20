using System;
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
        [SerializeField] ViewModelCollection _plusMinusItemCollection;

        private void SetCount(int count)
        {
            Count = count;
            IsMinus = Count < 0;
            _plusMinusItemCollection.PrepareViewModels(Math.Abs(Count));
            foreach (var item in _plusMinusItemCollection.GetViewModels())
            {
                var plusMinusItem = item as PlusMinusItem;
                if (plusMinusItem != null)
                {
                    plusMinusItem.IsPlus = Count > 0;
                }
            }
        }


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
            SetCount(Count+1);
        }
        [Binding]
        public void OnClickSubtract()
        {
            SetCount(Count-1);
        }
    }
}
