// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// The Get Historical Usage Metrics Web Site operation response.
    /// </summary>
    public partial class WebSiteGetHistoricalUsageMetricsResponse : OperationResponse, IEnumerable<HistoricalUsageMetric>
    {
        private IList<HistoricalUsageMetric> _usageMetrics;
        
        /// <summary>
        /// Optional. Historical metric snapshots for the web site.
        /// </summary>
        public IList<HistoricalUsageMetric> UsageMetrics
        {
            get { return this._usageMetrics; }
            set { this._usageMetrics = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// WebSiteGetHistoricalUsageMetricsResponse class.
        /// </summary>
        public WebSiteGetHistoricalUsageMetricsResponse()
        {
            this.UsageMetrics = new LazyList<HistoricalUsageMetric>();
        }
        
        /// <summary>
        /// Gets the sequence of UsageMetrics.
        /// </summary>
        public IEnumerator<HistoricalUsageMetric> GetEnumerator()
        {
            return this.UsageMetrics.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of UsageMetrics.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
