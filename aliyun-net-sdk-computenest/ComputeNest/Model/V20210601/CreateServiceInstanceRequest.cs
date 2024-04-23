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
using Aliyun.Acs.ComputeNest.Transform;
using Aliyun.Acs.ComputeNest.Transform.V20210601;

namespace Aliyun.Acs.ComputeNest.Model.V20210601
{
    public class CreateServiceInstanceRequest : RpcAcsRequest<CreateServiceInstanceResponse>
    {
        public CreateServiceInstanceRequest()
            : base("ComputeNest", "2021-06-01", "CreateServiceInstance", "computenest", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ComputeNest.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ComputeNest.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private Commodity commodity_;

		private string contactGroup;

		private string clientToken;

		private string specificationCode;

		private string resourceGroupId;

		private bool? enableInstanceOps;

		private string templateName;

		private List<string> tags = new List<string>(){ };

		private bool? dryRun;

		private bool? enableUserPrometheus;

		private string specificationName;

		private string trialType;

		private string name;

		private string serviceVersion;

		private string serviceId;

		private string parameters;

		private OperationMetadata operationMetadata_;

		public Commodity Commodity_
		{
			get
			{
				return commodity_;
			}

			set
			{
				commodity_ = value;
				if(commodity_ != null)
				{

					DictionaryUtil.Add(QueryParameters,"Commodity.PayPeriod", commodity_.PayPeriod);
					DictionaryUtil.Add(QueryParameters,"Commodity.AutoPay", commodity_.AutoPay);
					DictionaryUtil.Add(QueryParameters,"Commodity.AutoRenew", commodity_.AutoRenew);
					DictionaryUtil.Add(QueryParameters,"Commodity.PayPeriodUnit", commodity_.PayPeriodUnit);
				}
			}
		}

		public string ContactGroup
		{
			get
			{
				return contactGroup;
			}
			set	
			{
				contactGroup = value;
				DictionaryUtil.Add(QueryParameters, "ContactGroup", value);
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

		public string SpecificationCode
		{
			get
			{
				return specificationCode;
			}
			set	
			{
				specificationCode = value;
				DictionaryUtil.Add(QueryParameters, "SpecificationCode", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public bool? EnableInstanceOps
		{
			get
			{
				return enableInstanceOps;
			}
			set	
			{
				enableInstanceOps = value;
				DictionaryUtil.Add(QueryParameters, "EnableInstanceOps", value.ToString());
			}
		}

		public string TemplateName
		{
			get
			{
				return templateName;
			}
			set	
			{
				templateName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
			}
		}

		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public bool? EnableUserPrometheus
		{
			get
			{
				return enableUserPrometheus;
			}
			set	
			{
				enableUserPrometheus = value;
				DictionaryUtil.Add(QueryParameters, "EnableUserPrometheus", value.ToString());
			}
		}

		public string SpecificationName
		{
			get
			{
				return specificationName;
			}
			set	
			{
				specificationName = value;
				DictionaryUtil.Add(QueryParameters, "SpecificationName", value);
			}
		}

		public string TrialType
		{
			get
			{
				return trialType;
			}
			set	
			{
				trialType = value;
				DictionaryUtil.Add(QueryParameters, "TrialType", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string ServiceVersion
		{
			get
			{
				return serviceVersion;
			}
			set	
			{
				serviceVersion = value;
				DictionaryUtil.Add(QueryParameters, "ServiceVersion", value);
			}
		}

		public string ServiceId
		{
			get
			{
				return serviceId;
			}
			set	
			{
				serviceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceId", value);
			}
		}

		public string Parameters
		{
			get
			{
				return parameters;
			}
			set	
			{
				parameters = value;
				DictionaryUtil.Add(QueryParameters, "Parameters", value);
			}
		}

		public OperationMetadata OperationMetadata_
		{
			get
			{
				return operationMetadata_;
			}

			set
			{
				operationMetadata_ = value;
				if(operationMetadata_ != null)
				{

					DictionaryUtil.Add(QueryParameters,"OperationMetadata.EndTime", operationMetadata_.EndTime);
					DictionaryUtil.Add(QueryParameters,"OperationMetadata.Resources", operationMetadata_.Resources);
					DictionaryUtil.Add(QueryParameters,"OperationMetadata.StartTime", operationMetadata_.StartTime);
					DictionaryUtil.Add(QueryParameters,"OperationMetadata.ExtraInfo", operationMetadata_.ExtraInfo);
					DictionaryUtil.Add(QueryParameters,"OperationMetadata.ServiceInstanceId", operationMetadata_.ServiceInstanceId);
				}
			}
		}

		public class Commodity
		{

			private long? payPeriod;

			private bool? autoPay;

			private bool? autoRenew;

			private string payPeriodUnit;

			public long? PayPeriod
			{
				get
				{
					return payPeriod;
				}
				set	
				{
					payPeriod = value;
				}
			}

			public bool? AutoPay
			{
				get
				{
					return autoPay;
				}
				set	
				{
					autoPay = value;
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
				}
			}

			public string PayPeriodUnit
			{
				get
				{
					return payPeriodUnit;
				}
				set	
				{
					payPeriodUnit = value;
				}
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public class OperationMetadata
		{

			private string endTime;

			private string resources;

			private string startTime;

			private string extraInfo;

			private string serviceInstanceId;

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string ExtraInfo
			{
				get
				{
					return extraInfo;
				}
				set	
				{
					extraInfo = value;
				}
			}

			public string ServiceInstanceId
			{
				get
				{
					return serviceInstanceId;
				}
				set	
				{
					serviceInstanceId = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateServiceInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateServiceInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
