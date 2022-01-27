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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyDBProxyEndpointRequest : RpcAcsRequest<ModifyDBProxyEndpointResponse>
    {
        public ModifyDBProxyEndpointRequest()
            : base("Rds", "2014-08-15", "ModifyDBProxyEndpoint", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string configDBProxyFeatures;

		private string dBInstanceId;

		private string readOnlyInstanceWeight;

		private string readOnlyInstanceMaxDelayTime;

		private string resourceOwnerAccount;

		private string dbEndpointAliases;

		private string dbEndpointOperator;

		private string dbEndpointType;

		private long? ownerId;

		private string dbEndpointReadWriteMode;

		private string dBProxyEndpointId;

		private string readOnlyInstanceDistributionType;

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

		public string ConfigDBProxyFeatures
		{
			get
			{
				return configDBProxyFeatures;
			}
			set	
			{
				configDBProxyFeatures = value;
				DictionaryUtil.Add(QueryParameters, "ConfigDBProxyFeatures", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string ReadOnlyInstanceWeight
		{
			get
			{
				return readOnlyInstanceWeight;
			}
			set	
			{
				readOnlyInstanceWeight = value;
				DictionaryUtil.Add(QueryParameters, "ReadOnlyInstanceWeight", value);
			}
		}

		public string ReadOnlyInstanceMaxDelayTime
		{
			get
			{
				return readOnlyInstanceMaxDelayTime;
			}
			set	
			{
				readOnlyInstanceMaxDelayTime = value;
				DictionaryUtil.Add(QueryParameters, "ReadOnlyInstanceMaxDelayTime", value);
			}
		}

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

		public string DbEndpointAliases
		{
			get
			{
				return dbEndpointAliases;
			}
			set	
			{
				dbEndpointAliases = value;
				DictionaryUtil.Add(QueryParameters, "DbEndpointAliases", value);
			}
		}

		public string DbEndpointOperator
		{
			get
			{
				return dbEndpointOperator;
			}
			set	
			{
				dbEndpointOperator = value;
				DictionaryUtil.Add(QueryParameters, "DbEndpointOperator", value);
			}
		}

		public string DbEndpointType
		{
			get
			{
				return dbEndpointType;
			}
			set	
			{
				dbEndpointType = value;
				DictionaryUtil.Add(QueryParameters, "DbEndpointType", value);
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

		public string DbEndpointReadWriteMode
		{
			get
			{
				return dbEndpointReadWriteMode;
			}
			set	
			{
				dbEndpointReadWriteMode = value;
				DictionaryUtil.Add(QueryParameters, "DbEndpointReadWriteMode", value);
			}
		}

		public string DBProxyEndpointId
		{
			get
			{
				return dBProxyEndpointId;
			}
			set	
			{
				dBProxyEndpointId = value;
				DictionaryUtil.Add(QueryParameters, "DBProxyEndpointId", value);
			}
		}

		public string ReadOnlyInstanceDistributionType
		{
			get
			{
				return readOnlyInstanceDistributionType;
			}
			set	
			{
				readOnlyInstanceDistributionType = value;
				DictionaryUtil.Add(QueryParameters, "ReadOnlyInstanceDistributionType", value);
			}
		}

        public override ModifyDBProxyEndpointResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBProxyEndpointResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
