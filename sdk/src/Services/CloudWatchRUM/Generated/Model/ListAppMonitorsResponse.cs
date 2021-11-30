/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// This is the response object from the ListAppMonitors operation.
    /// </summary>
    public partial class ListAppMonitorsResponse : AmazonWebServiceResponse
    {
        private List<AppMonitorSummary> _appMonitorSummaries = new List<AppMonitorSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AppMonitorSummaries. 
        /// <para>
        /// An array of structures that contain information about the returned app monitors.
        /// </para>
        /// </summary>
        public List<AppMonitorSummary> AppMonitorSummaries
        {
            get { return this._appMonitorSummaries; }
            set { this._appMonitorSummaries = value; }
        }

        // Check to see if AppMonitorSummaries property is set
        internal bool IsSetAppMonitorSummaries()
        {
            return this._appMonitorSummaries != null && this._appMonitorSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that you can use in a subsequent operation to retrieve the next set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}