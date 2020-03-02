/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAnomalyDetectors operation.
    /// Lists the anomaly detection models that you have created in your account. You can
    /// list all models in your account or filter the results to only the models that are
    /// related to a certain namespace, metric name, or metric dimension.
    /// </summary>
    public partial class DescribeAnomalyDetectorsRequest : AmazonCloudWatchRequest
    {
        private List<Dimension> _dimensions = new List<Dimension>();
        private int? _maxResults;
        private string _metricName;
        private string _awsNamespace;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Limits the results to only the anomaly detection models that are associated with the
        /// specified metric dimensions. If there are multiple metrics that have these dimensions
        /// and have anomaly detection models associated, they're all returned.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in one operation. The maximum value that you
        /// can specify is 100.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another call with the returned <code>NextToken</code>
        /// value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// Limits the results to only the anomaly detection models that are associated with the
        /// specified metric name. If there are multiple metrics with this name in different namespaces
        /// that have anomaly detection models, they're all returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// Limits the results to only the anomaly detection models that are associated with the
        /// specified namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use the token returned by the previous operation to request the next page of results.
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