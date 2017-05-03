using System;
using System.Collections.Generic;

namespace TowerInnCafeCatering.Models
{
    public interface ITakeOutTrayRepository
    {
        List<TakeOutTray> TakeOutTrays { get; }
    }
}