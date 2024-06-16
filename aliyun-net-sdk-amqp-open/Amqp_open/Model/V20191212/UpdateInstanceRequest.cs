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
using Aliyun.Acs.amqp_open.Transform;
using Aliyun.Acs.amqp_open.Transform.V20191212;

namespace Aliyun.Acs.amqp_open.Model.V20191212
{
    public class UpdateInstanceRequest : RpcAcsRequest<UpdateInstanceResponse>
    {
        public UpdateInstanceRequest()
            : base("amqp-open", "2019-12-12", "UpdateInstance", "onsproxy", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.amqp_open.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.amqp_open.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? maxPrivateTps;

		private string clientToken;

		private int? storageSize;

		private int? queueCapacity;

		private int? tracingStorageTime;

		private int? maxConnections;

		private bool? supportTracing;

		private string serverlessChargeType;

		private string instanceType;

		private string instanceId;

		private bool? supportEip;

		private string modifyType;

		private long? maxEipTps;

		public long? MaxPrivateTps
		{
			get
			{
				return maxPrivateTps;
			}
			set	
			{
				maxPrivateTps = value;
				DictionaryUtil.Add(QueryParameters, "MaxPrivateTps", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public int? StorageSize
		{
			get
			{
				return storageSize;
			}
			set	
			{
				storageSize = value;
				DictionaryUtil.Add(QueryParameters, "StorageSize", value.ToString());
			}
		}

		public int? QueueCapacity
		{
			get
			{
				return queueCapacity;
			}
			set	
			{
				queueCapacity = value;
				DictionaryUtil.Add(QueryParameters, "QueueCapacity", value.ToString());
			}
		}

		public int? TracingStorageTime
		{
			get
			{
				return tracingStorageTime;
			}
			set	
			{
				tracingStorageTime = value;
				DictionaryUtil.Add(QueryParameters, "TracingStorageTime", value.ToString());
			}
		}

		public int? MaxConnections
		{
			get
			{
				return maxConnections;
			}
			set	
			{
				maxConnections = value;
				DictionaryUtil.Add(QueryParameters, "MaxConnections", value.ToString());
			}
		}

		public bool? SupportTracing
		{
			get
			{
				return supportTracing;
			}
			set	
			{
				supportTracing = value;
				DictionaryUtil.Add(QueryParameters, "SupportTracing", value.ToString());
			}
		}

		public string ServerlessChargeType
		{
			get
			{
				return serverlessChargeType;
			}
			set	
			{
				serverlessChargeType = value;
				DictionaryUtil.Add(QueryParameters, "ServerlessChargeType", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public bool? SupportEip
		{
			get
			{
				return supportEip;
			}
			set	
			{
				supportEip = value;
				DictionaryUtil.Add(QueryParameters, "SupportEip", value.ToString());
			}
		}

		public string ModifyType
		{
			get
			{
				return modifyType;
			}
			set	
			{
				modifyType = value;
				DictionaryUtil.Add(QueryParameters, "ModifyType", value);
			}
		}

		public long? MaxEipTps
		{
			get
			{
				return maxEipTps;
			}
			set	
			{
				maxEipTps = value;
				DictionaryUtil.Add(QueryParameters, "MaxEipTps", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
