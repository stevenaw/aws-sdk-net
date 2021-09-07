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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the SendActivationCode operation.
    /// Sends an activation code to a contact channel. The contact can use this code to activate
    /// the contact channel in the console or with the <code>ActivateChannel</code> operation.
    /// Incident Manager can't engage a contact channel until it has been activated.
    /// </summary>
    public partial class SendActivationCodeRequest : AmazonSSMContactsRequest
    {
        private string _contactChannelId;

        /// <summary>
        /// Gets and sets the property ContactChannelId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ContactChannelId
        {
            get { return this._contactChannelId; }
            set { this._contactChannelId = value; }
        }

        // Check to see if ContactChannelId property is set
        internal bool IsSetContactChannelId()
        {
            return this._contactChannelId != null;
        }

    }
}