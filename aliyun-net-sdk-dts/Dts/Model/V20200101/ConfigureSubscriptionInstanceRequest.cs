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
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class ConfigureSubscriptionInstanceRequest : RpcAcsRequest<ConfigureSubscriptionInstanceResponse>
    {
        public ConfigureSubscriptionInstanceRequest()
            : base("Dts", "2020-01-01", "ConfigureSubscriptionInstance", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceEndpointInstanceID;

		private string sourceEndpointOracleSID;

		private string sourceEndpointIP;

		private bool? subscriptionDataTypeDML;

		private string sourceEndpointInstanceType;

		private string accountId;

		private string subscriptionObject;

		private string subscriptionInstanceVSwitchId;

		private string sourceEndpointUserName;

		private string sourceEndpointDatabaseName;

		private string sourceEndpointPort;

		private string sourceEndpointOwnerID;

		private string subscriptionInstanceVPCId;

		private string subscriptionInstanceNetworkType;

		private string subscriptionInstanceId;

		private string sourceEndpointRole;

		private string ownerId;

		private bool? subscriptionDataTypeDDL;

		private string sourceEndpointPassword;

		private string subscriptionInstanceName;

		public string SourceEndpointInstanceID
		{
			get
			{
				return sourceEndpointInstanceID;
			}
			set	
			{
				sourceEndpointInstanceID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.InstanceID", value);
			}
		}

		public string SourceEndpointOracleSID
		{
			get
			{
				return sourceEndpointOracleSID;
			}
			set	
			{
				sourceEndpointOracleSID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.OracleSID", value);
			}
		}

		public string SourceEndpointIP
		{
			get
			{
				return sourceEndpointIP;
			}
			set	
			{
				sourceEndpointIP = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.IP", value);
			}
		}

		public bool? SubscriptionDataTypeDML
		{
			get
			{
				return subscriptionDataTypeDML;
			}
			set	
			{
				subscriptionDataTypeDML = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionDataType.DML", value.ToString());
			}
		}

		public string SourceEndpointInstanceType
		{
			get
			{
				return sourceEndpointInstanceType;
			}
			set	
			{
				sourceEndpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.InstanceType", value);
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(QueryParameters, "AccountId", value);
			}
		}

		public string SubscriptionObject
		{
			get
			{
				return subscriptionObject;
			}
			set	
			{
				subscriptionObject = value;
				DictionaryUtil.Add(BodyParameters, "SubscriptionObject", value);
			}
		}

		public string SubscriptionInstanceVSwitchId
		{
			get
			{
				return subscriptionInstanceVSwitchId;
			}
			set	
			{
				subscriptionInstanceVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionInstance.VSwitchId", value);
			}
		}

		public string SourceEndpointUserName
		{
			get
			{
				return sourceEndpointUserName;
			}
			set	
			{
				sourceEndpointUserName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.UserName", value);
			}
		}

		public string SourceEndpointDatabaseName
		{
			get
			{
				return sourceEndpointDatabaseName;
			}
			set	
			{
				sourceEndpointDatabaseName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.DatabaseName", value);
			}
		}

		public string SourceEndpointPort
		{
			get
			{
				return sourceEndpointPort;
			}
			set	
			{
				sourceEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.Port", value);
			}
		}

		public string SourceEndpointOwnerID
		{
			get
			{
				return sourceEndpointOwnerID;
			}
			set	
			{
				sourceEndpointOwnerID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.OwnerID", value);
			}
		}

		public string SubscriptionInstanceVPCId
		{
			get
			{
				return subscriptionInstanceVPCId;
			}
			set	
			{
				subscriptionInstanceVPCId = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionInstance.VPCId", value);
			}
		}

		public string SubscriptionInstanceNetworkType
		{
			get
			{
				return subscriptionInstanceNetworkType;
			}
			set	
			{
				subscriptionInstanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionInstanceNetworkType", value);
			}
		}

		public string SubscriptionInstanceId
		{
			get
			{
				return subscriptionInstanceId;
			}
			set	
			{
				subscriptionInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionInstanceId", value);
			}
		}

		public string SourceEndpointRole
		{
			get
			{
				return sourceEndpointRole;
			}
			set	
			{
				sourceEndpointRole = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.Role", value);
			}
		}

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

		public bool? SubscriptionDataTypeDDL
		{
			get
			{
				return subscriptionDataTypeDDL;
			}
			set	
			{
				subscriptionDataTypeDDL = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionDataType.DDL", value.ToString());
			}
		}

		public string SourceEndpointPassword
		{
			get
			{
				return sourceEndpointPassword;
			}
			set	
			{
				sourceEndpointPassword = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.Password", value);
			}
		}

		public string SubscriptionInstanceName
		{
			get
			{
				return subscriptionInstanceName;
			}
			set	
			{
				subscriptionInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionInstanceName", value);
			}
		}

        public override ConfigureSubscriptionInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigureSubscriptionInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
