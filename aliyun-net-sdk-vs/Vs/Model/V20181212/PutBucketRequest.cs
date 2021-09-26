/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class PutBucketRequest : RpcAcsRequest<PutBucketResponse>
    {
        public PutBucketRequest()
            : base("vs", "2018-12-12", "PutBucket", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dataRedundancyType;

		private string endpoint;

		private string bucketName;

		private string bucketAcl;

		private string dispatcherType;

		private long? ownerId;

		private string resourceType;

		private string storageClass;

		private string comment;

		public string DataRedundancyType
		{
			get
			{
				return dataRedundancyType;
			}
			set	
			{
				dataRedundancyType = value;
				DictionaryUtil.Add(QueryParameters, "DataRedundancyType", value);
			}
		}

		public string Endpoint
		{
			get
			{
				return endpoint;
			}
			set	
			{
				endpoint = value;
				DictionaryUtil.Add(QueryParameters, "Endpoint", value);
			}
		}

		public string BucketName
		{
			get
			{
				return bucketName;
			}
			set	
			{
				bucketName = value;
				DictionaryUtil.Add(QueryParameters, "BucketName", value);
			}
		}

		public string BucketAcl
		{
			get
			{
				return bucketAcl;
			}
			set	
			{
				bucketAcl = value;
				DictionaryUtil.Add(QueryParameters, "BucketAcl", value);
			}
		}

		public string DispatcherType
		{
			get
			{
				return dispatcherType;
			}
			set	
			{
				dispatcherType = value;
				DictionaryUtil.Add(QueryParameters, "DispatcherType", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string StorageClass
		{
			get
			{
				return storageClass;
			}
			set	
			{
				storageClass = value;
				DictionaryUtil.Add(QueryParameters, "StorageClass", value);
			}
		}

		public string Comment
		{
			get
			{
				return comment;
			}
			set	
			{
				comment = value;
				DictionaryUtil.Add(QueryParameters, "Comment", value);
			}
		}

        public override PutBucketResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PutBucketResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
