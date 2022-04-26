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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// This is the response object from the ListRooms operation.
    /// </summary>
    public partial class ListRoomsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RoomSummary> _rooms = new List<RoomSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more rooms than <code>maxResults</code>, use <code>nextToken</code> in
        /// the request to get the next set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property Rooms. 
        /// <para>
        /// List of the matching rooms (summary information only).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RoomSummary> Rooms
        {
            get { return this._rooms; }
            set { this._rooms = value; }
        }

        // Check to see if Rooms property is set
        internal bool IsSetRooms()
        {
            return this._rooms != null && this._rooms.Count > 0; 
        }

    }
}