﻿using Leagueoflegends.Data.Main;
using Leagueoflegends.Windowbase.Mvvm;

namespace Leagueoflegends.Windowbase.Riotcore
{
	public interface IRiotUIElement
	{
		IRiotUIElement UseViewModel(ObservableObject vm);
		void Show(SubMenuModel menu);
	}
}