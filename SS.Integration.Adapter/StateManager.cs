﻿//Copyright 2014 Spin Services Limited

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using System;
using System.Collections.Generic;
using SS.Integration.Adapter.Interface;
using SS.Integration.Adapter.MarketRules;
using SS.Integration.Adapter.MarketRules.Interfaces;
using SS.Integration.Adapter.Model;
using SS.Integration.Adapter.Model.Interfaces;
using SS.Integration.Adapter.ProcessState;

namespace SS.Integration.Adapter
{
    internal class StateManager : IStoredObjectProvider, IStateManager, IStateProvider
    {
        private const string PLUGIN_STORE_PREFIX = "plugin_";

        private readonly IObjectProvider<IUpdatableMarketStateCollection> _PersistanceLayer;
        private readonly IObjectProvider<IPluginFixtureState> _PluginPersistanceLayer;
        private readonly Dictionary<string, MarketRulesManager> _RulesManagers;
        private readonly List<IMarketRule> _Rules;


        public StateManager(ISettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException("settings", "ISettings cannot be null");

            _PersistanceLayer = new CachedObjectStoreWithPersistance<IUpdatableMarketStateCollection>(
                new BinaryStoreProvider<IUpdatableMarketStateCollection>(settings.MarketFiltersDirectory, "FilteredMarkets-{0}.bin"),
                "MarketFilters", settings.CacheExpiryInMins * 60);

            _PluginPersistanceLayer = new CachedObjectStoreWithPersistance<IPluginFixtureState>(
                new BinaryStoreProvider<IPluginFixtureState>(settings.MarketFiltersDirectory, "PluginStore-{0}.bin"),
                "MarketFilters", settings.CacheExpiryInMins * 60);

            _RulesManagers = new Dictionary<string, MarketRulesManager>();
            _Rules = new List<IMarketRule>
            {
                InactiveMarketsFilteringRule.Instance,
                VoidUnSettledMarket.Instance
            };

            if (settings.DeltaRuleEnabled)
            {
                _Rules.Add(DeltaRule.Instance);
            }
            
        }

        #region IStoredObjectProvider

        public IUpdatableMarketStateCollection GetObject(string fixtureId)
        {
            return _PersistanceLayer.GetObject(fixtureId);
        }

        public void SetObject(string fixtureId, IUpdatableMarketStateCollection state)
        {
            _PersistanceLayer.SetObject(fixtureId, state);
        }

        public void Remove(string fixtureId)
        {
            _PersistanceLayer.Remove(fixtureId);
        }

        #endregion

        #region IStateProvider

        IMarketStateCollection IStateProvider.GetMarketsState(string fixtureId)
        {
            if(string.IsNullOrEmpty(fixtureId))
                throw new ArgumentNullException("fixtureId", "fixtureId cannot be null");

            return _RulesManagers.ContainsKey(fixtureId) ? _RulesManagers[fixtureId].CurrentState : null;
        }

        public T GetPluginFixtureState<T>(string fixtureId) where T : IPluginFixtureState
        {
            var tmp = GetPluginFixtureState(fixtureId);
            if (tmp == null)
                return default(T);

            return (T)tmp;
        }

        public IPluginFixtureState GetPluginFixtureState(string fixtureId)
        {
            return _PluginPersistanceLayer.GetObject(PLUGIN_STORE_PREFIX + fixtureId);
        }

        public void AddOrUpdatePluginFixtureState(IPluginFixtureState state)
        {
            if(state == null)
                return;

            if (string.IsNullOrEmpty(state.FixtureId))
                throw new Exception("FixtureId cannot be null");

            _PluginPersistanceLayer.SetObject(state.FixtureId, state);
        }

        #endregion

        #region IStateManager

        public IMarketRulesManager CreateNewMarketRuleManager(string fixtureId)
        {
            if (string.IsNullOrEmpty(fixtureId))
                throw new ArgumentNullException("fixtureId", "fixtureId cannot be null or empty");

            if (_RulesManagers.ContainsKey(fixtureId))
                return _RulesManagers[fixtureId];

            var rule_manager = new MarketRulesManager(fixtureId, this, _Rules);
            _RulesManagers.Add(fixtureId, rule_manager);

            return rule_manager;
        }

        public void ClearState(string fixtureId)
        {
            if (string.IsNullOrEmpty(fixtureId))
                return;

            if (_RulesManagers.ContainsKey(fixtureId))
                _RulesManagers.Remove(fixtureId);

            _PersistanceLayer.Remove(fixtureId);
        }

        #endregion

    }
}
