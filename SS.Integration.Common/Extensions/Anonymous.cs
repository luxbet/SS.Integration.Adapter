//Copyright 2014 Spin Services Limited

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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Integration.Common.Extensions
{
    public class Anonymous
    {
        //this method shouldn't be used to instantiate any other dictionary as it can be achievied through normal constructor
        public static IDictionary<TKey, TValue> CreateDictionaryWithAnonymousObject<TKey,TValue>(TKey key, TValue value)
        {
            return new Dictionary<TKey, TValue>();
        }

    }
}

