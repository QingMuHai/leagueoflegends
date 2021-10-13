﻿using System.Collections.Generic;
using System.Linq;
using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.Collection.Local.ViewModel
{
    public class ItemViewModel : ObservableObject
    {
        public RelayCommand<object> ButtonTest { get; set; }

        private bool _buttonUsed;
        private List<Items> _itemList;

        #region ButtonUsed

        public bool ButtonUsed
        {
            get => _buttonUsed;
            set { _buttonUsed = value; OnPropertyChanged(); }
        }
        #endregion

        #region ItemList

        public List<Items> ItemList
        {
            get { return _itemList; }
            set { _itemList = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public ItemViewModel()
        {
            ItemList = new ItemApi().GetItems();
            ButtonTest = new RelayCommand<object>(Test1, Test2);
        }
        #endregion

        private static string ImgResource(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.png";
        }

        private void Test1(object obj)
        {
            //int cnt = ItemLists.Count;

            //var item = new MyItemListModel
            //{
            //    Seq = cnt,
            //    Name = $"새로운 아이템 세트({cnt})",
            //    Champ = "모든 챔피언",
            //    CheckCommand = new RelayCommand<object>(Checked),
            //    MapType1 = ImgResource("Map", "Summoner's_rift"),
            //    MapType2 = ImgResource("Map", "Howling_Abyss"),
            //};

            //List<MyItemListModel> source = new();

            //foreach(var i in ItemLists)
            //{
            //    source.Add(i);
            //}

            //source.Add(item);

            //ItemLists = source;
        }

        private void Checked(object value)
        {
            ButtonUsed = true;
            var dd = ItemList.Where(x => x.IsChecked);

            //ButtonUsed = ItemLists.Where(x => x.IsChecked);
        }

        private bool Test2(object obj)
        {
            return true;
        }
    }
}
