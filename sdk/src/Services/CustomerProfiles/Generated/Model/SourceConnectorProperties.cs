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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SourceConnectorProperties
    {
        private MarketoSourceProperties _marketo;
        private S3SourceProperties _s3;
        private SalesforceSourceProperties _salesforce;
        private ServiceNowSourceProperties _serviceNow;
        private ZendeskSourceProperties _zendesk;

        /// <summary>
        /// Gets and sets the property Marketo.
        /// </summary>
        public MarketoSourceProperties Marketo
        {
            get { return this._marketo; }
            set { this._marketo = value; }
        }

        // Check to see if Marketo property is set
        internal bool IsSetMarketo()
        {
            return this._marketo != null;
        }

        /// <summary>
        /// Gets and sets the property S3.
        /// </summary>
        public S3SourceProperties S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

        /// <summary>
        /// Gets and sets the property Salesforce.
        /// </summary>
        public SalesforceSourceProperties Salesforce
        {
            get { return this._salesforce; }
            set { this._salesforce = value; }
        }

        // Check to see if Salesforce property is set
        internal bool IsSetSalesforce()
        {
            return this._salesforce != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNow.
        /// </summary>
        public ServiceNowSourceProperties ServiceNow
        {
            get { return this._serviceNow; }
            set { this._serviceNow = value; }
        }

        // Check to see if ServiceNow property is set
        internal bool IsSetServiceNow()
        {
            return this._serviceNow != null;
        }

        /// <summary>
        /// Gets and sets the property Zendesk.
        /// </summary>
        public ZendeskSourceProperties Zendesk
        {
            get { return this._zendesk; }
            set { this._zendesk = value; }
        }

        // Check to see if Zendesk property is set
        internal bool IsSetZendesk()
        {
            return this._zendesk != null;
        }

    }
}