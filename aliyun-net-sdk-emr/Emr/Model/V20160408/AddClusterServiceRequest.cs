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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class AddClusterServiceRequest : RpcAcsRequest<AddClusterServiceResponse>
    {
        public AddClusterServiceRequest()
            : base("Emr", "2016-04-08", "AddClusterService", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string regionId;

		private List<Service> services;

		private string comment;

		private string clusterId;

		private string accessKeyId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public List<Service> Services
		{
			get
			{
				return services;
			}

			set
			{
				services = value;
				for (int i = 0; i < services.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".ServiceName", services[i].ServiceName);
				}
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

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public class Service
		{

			private string serviceName;

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}
		}

        public override AddClusterServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddClusterServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
