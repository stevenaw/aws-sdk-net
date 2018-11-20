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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.RDSDataService.Model;
using Amazon.RDSDataService.Model.Internal.MarshallTransformations;
using Amazon.RDSDataService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDSDataService
{
    /// <summary>
    /// Implementation for accessing RDSDataService
    ///
    /// AWS RDS DataService provides Http Endpoint to query RDS databases.
    /// </summary>
    public partial class AmazonRDSDataServiceClient : AmazonServiceClient, IAmazonRDSDataService
    {
        private static IServiceMetadata serviceMetadata = new AmazonRDSDataServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRDSDataServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSDataServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSDataServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSDataServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRDSDataServiceClient Configuration Object</param>
        public AmazonRDSDataServiceClient(AmazonRDSDataServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRDSDataServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonRDSDataServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSDataServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRDSDataServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Credentials and an
        /// AmazonRDSDataServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRDSDataServiceClient Configuration Object</param>
        public AmazonRDSDataServiceClient(AWSCredentials credentials, AmazonRDSDataServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSDataServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSDataServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSDataServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRDSDataServiceClient Configuration Object</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRDSDataServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSDataServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSDataServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSDataServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRDSDataServiceClient Configuration Object</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRDSDataServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  ExecuteSql

        /// <summary>
        /// Executes any SQL statement on the target database synchronously
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSql service method.</param>
        /// 
        /// <returns>The response from the ExecuteSql service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// Invalid Request exception
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// Access denied exception
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// Internal service error
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// Internal service unavailable error
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        public virtual ExecuteSqlResponse ExecuteSql(ExecuteSqlRequest request)
        {
            var marshaller = ExecuteSqlRequestMarshaller.Instance;
            var unmarshaller = ExecuteSqlResponseUnmarshaller.Instance;

            return Invoke<ExecuteSqlRequest,ExecuteSqlResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteSql operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSql operation on AmazonRDSDataServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteSql
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        public virtual IAsyncResult BeginExecuteSql(ExecuteSqlRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ExecuteSqlRequestMarshaller.Instance;
            var unmarshaller = ExecuteSqlResponseUnmarshaller.Instance;

            return BeginInvoke<ExecuteSqlRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteSql operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteSql.</param>
        /// 
        /// <returns>Returns a  ExecuteSqlResult from RDSDataService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        public virtual ExecuteSqlResponse EndExecuteSql(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteSqlResponse>(asyncResult);
        }

        #endregion
        
    }
}