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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the ListPreparedStatements operation.
    /// </summary>
    public partial class ListPreparedStatementsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PreparedStatementSummary> _preparedStatements = new List<PreparedStatementSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token generated by the Athena service that specifies where to continue pagination
        /// if a previous request was truncated. To obtain the next set of pages, pass in the
        /// <code>NextToken</code> from the response object of the previous page call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property PreparedStatements. 
        /// <para>
        /// The list of prepared statements for the workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<PreparedStatementSummary> PreparedStatements
        {
            get { return this._preparedStatements; }
            set { this._preparedStatements = value; }
        }

        // Check to see if PreparedStatements property is set
        internal bool IsSetPreparedStatements()
        {
            return this._preparedStatements != null && this._preparedStatements.Count > 0; 
        }

    }
}