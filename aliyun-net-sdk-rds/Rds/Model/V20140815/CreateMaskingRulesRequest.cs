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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateMaskingRulesRequest : RpcAcsRequest<CreateMaskingRulesResponse>
    {
        public CreateMaskingRulesRequest()
            : base("Rds", "2014-08-15", "CreateMaskingRules", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string dBInstanceName;

		private long? resourceOwnerId;

		private string maskingAlgo;

		private string ruleName;

		private string resourceOwnerAccount;

		private string ownerId;

		private string defaultAlgo;

		private RuleConfig ruleConfig_;

		[JsonProperty(PropertyName = "DBInstanceName")]
		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceName", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "MaskingAlgo")]
		public string MaskingAlgo
		{
			get
			{
				return maskingAlgo;
			}
			set	
			{
				maskingAlgo = value;
				DictionaryUtil.Add(QueryParameters, "MaskingAlgo", value);
			}
		}

		[JsonProperty(PropertyName = "RuleName")]
		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
				DictionaryUtil.Add(QueryParameters, "RuleName", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "DefaultAlgo")]
		public string DefaultAlgo
		{
			get
			{
				return defaultAlgo;
			}
			set	
			{
				defaultAlgo = value;
				DictionaryUtil.Add(QueryParameters, "DefaultAlgo", value);
			}
		}

		[JsonProperty(PropertyName = "RuleConfig")]
		public RuleConfig RuleConfig_
		{
			get
			{
				return ruleConfig_;
			}

			set
			{
				ruleConfig_ = value;
				DictionaryUtil.Add(QueryParameters, "RuleConfig", JsonConvert.SerializeObject(value));

			}
		}

		public class RuleConfig
		{

			private List<string> databases = new List<string>(){ };

			private List<string> tables = new List<string>(){ };

			private List<string> columns = new List<string>(){ };

			[JsonProperty(PropertyName = "Databases")]
			public List<string> Databases
			{
				get
				{
					return databases;
				}
				set	
				{
					databases = value;
				}
			}

			[JsonProperty(PropertyName = "Tables")]
			public List<string> Tables
			{
				get
				{
					return tables;
				}
				set	
				{
					tables = value;
				}
			}

			[JsonProperty(PropertyName = "Columns")]
			public List<string> Columns
			{
				get
				{
					return columns;
				}
				set	
				{
					columns = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateMaskingRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateMaskingRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
