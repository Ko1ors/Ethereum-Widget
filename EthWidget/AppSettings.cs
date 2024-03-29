﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EthWidget
{
    public static partial class AppSettings
    {
        public static string ethApiKey; // Etherscan.io api key
        public static string ethWallet;
        public static int updateTime;

        public static void Set(string apiKey, string wallet, int time)
        {
            ethApiKey = apiKey;
            ethWallet = wallet;
            updateTime = time;
        }

        public static void Save()
        {
            Properties.Settings.Default.ethApiKey = ethApiKey;
            Properties.Settings.Default.ethWallet = ethWallet;
            Properties.Settings.Default.updateTime = updateTime;
            Properties.Settings.Default.Save();
        }

        public static void Load()
        {
           ethApiKey = Properties.Settings.Default.ethApiKey;
           ethWallet = Properties.Settings.Default.ethWallet;
           updateTime = Properties.Settings.Default.updateTime;
        }
    }
}
