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
    /// Summary information about a room.
    /// </summary>
    public partial class RoomSummary
    {
        private string _arn;
        private DateTime? _createTime;
        private string _id;
        private MessageReviewHandler _messageReviewHandler;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Room ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Time when the room was created. This is an ISO 8601 timestamp; <i>note that this is
        /// returned as a string</i>. 
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Room ID, generated by the system. This is a relative identifier, the part of the ARN
        /// that uniquely identifies the room.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MessageReviewHandler. 
        /// <para>
        /// Configuration information for optional review of messages.
        /// </para>
        /// </summary>
        public MessageReviewHandler MessageReviewHandler
        {
            get { return this._messageReviewHandler; }
            set { this._messageReviewHandler = value; }
        }

        // Check to see if MessageReviewHandler property is set
        internal bool IsSetMessageReviewHandler()
        {
            return this._messageReviewHandler != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Room name. The value does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// Time of the room’s last update. This is an ISO 8601 timestamp; <i>note that this is
        /// returned as a string</i>. 
        /// </para>
        /// </summary>
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}