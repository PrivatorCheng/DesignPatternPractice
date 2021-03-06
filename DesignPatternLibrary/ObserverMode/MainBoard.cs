﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.ObserverMode
{
    public class MainBoard:IObserver
    {
        private StockData stock;
        private string StockName;
        private int StockCount;
        private double StockPrice;

        public MainBoard(StockData myStock)
        {
            stock = myStock;
            stock.registerObserver(this);
        }

        public void updateSubjectData(string stkName, int stkCount, double stkPrice)
        {
            StockName = stkName;
            StockCount = stkCount;
            StockPrice = stkPrice;
        }
        public string dispResult()
        {
            string dispText = "";
            dispText = "<h2>";
            dispText += "MainBoard" + "StockName:" + StockName + "StockCount:" + StockCount.ToString() + "StockPrice:" + StockPrice.ToString();
            dispText += "</h2>";
            return dispText;
        }

    }
}
