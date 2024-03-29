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
    public class CreateInstanceRequest : RpcAcsRequest<CreateInstanceResponse>
    {
        public CreateInstanceRequest()
            : base("amqp-open", "2019-12-12", "CreateInstance", "onsproxy", "openAPI")
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

		private string periodCycle;

		private int? storageSize;

		private int? queueCapacity;

		private int? tracingStorageTime;

		private int? maxConnections;

		private bool? supportTracing;

		private string serverlessChargeType;

		private string instanceType;

		private string renewStatus;

		private int? autoRenewPeriod;

		private int? period;

		private string renewalDurationUnit;

		private string instanceName;

		private bool? autoRenew;

		private bool? supportEip;

		private long? maxEipTps;

		private string paymentType;

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

		public string PeriodCycle
		{
			get
			{
				return periodCycle;
			}
			set	
			{
				periodCycle = value;
				DictionaryUtil.Add(QueryParameters, "PeriodCycle", value);
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

		public string RenewStatus
		{
			get
			{
				return renewStatus;
			}
			set	
			{
				renewStatus = value;
				DictionaryUtil.Add(QueryParameters, "RenewStatus", value);
			}
		}

		public int? AutoRenewPeriod
		{
			get
			{
				return autoRenewPeriod;
			}
			set	
			{
				autoRenewPeriod = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenewPeriod", value.ToString());
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string RenewalDurationUnit
		{
			get
			{
				return renewalDurationUnit;
			}
			set	
			{
				renewalDurationUnit = value;
				DictionaryUtil.Add(QueryParameters, "RenewalDurationUnit", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
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

		public string PaymentType
		{
			get
			{
				return paymentType;
			}
			set	
			{
				paymentType = value;
				DictionaryUtil.Add(QueryParameters, "PaymentType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
