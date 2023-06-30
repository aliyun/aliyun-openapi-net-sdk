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
using Aliyun.Acs.Rds;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateDBInstanceEndpointRequest : RpcAcsRequest<CreateDBInstanceEndpointResponse>
    {
        public CreateDBInstanceEndpointRequest()
            : base("Rds", "2014-08-15", "CreateDBInstanceEndpoint")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string connectionStringPrefix;

		private long? resourceOwnerId;

		private string clientToken;

		private string resourceGroupId;

		private string dBInstanceId;

		private string dBInstanceEndpointDescription;

		private string dBInstanceEndpointType;

		private string nodeItems;

		private string vSwitchId;

		private string privateIpAddress;

		private string port;

		private string vpcId;

		[JsonProperty(PropertyName = "ConnectionStringPrefix")]
		public string ConnectionStringPrefix
		{
			get
			{
				return connectionStringPrefix;
			}
			set	
			{
				connectionStringPrefix = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionStringPrefix", value);
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

		[JsonProperty(PropertyName = "ClientToken")]
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

		[JsonProperty(PropertyName = "ResourceGroupId")]
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

		[JsonProperty(PropertyName = "DBInstanceId")]
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

		[JsonProperty(PropertyName = "DBInstanceEndpointDescription")]
		public string DBInstanceEndpointDescription
		{
			get
			{
				return dBInstanceEndpointDescription;
			}
			set	
			{
				dBInstanceEndpointDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceEndpointDescription", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceEndpointType")]
		public string DBInstanceEndpointType
		{
			get
			{
				return dBInstanceEndpointType;
			}
			set	
			{
				dBInstanceEndpointType = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceEndpointType", value);
			}
		}

		[JsonProperty(PropertyName = "NodeItems")]
		public string NodeItems
		{
			get
			{
				return nodeItems;
			}
			set	
			{
				nodeItems = value;
				DictionaryUtil.Add(QueryParameters, "NodeItems", value);
			}
		}

		[JsonProperty(PropertyName = "VSwitchId")]
		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		[JsonProperty(PropertyName = "PrivateIpAddress")]
		public string PrivateIpAddress
		{
			get
			{
				return privateIpAddress;
			}
			set	
			{
				privateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
			}
		}

		[JsonProperty(PropertyName = "Port")]
		public string Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value);
			}
		}

		[JsonProperty(PropertyName = "VpcId")]
		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

        public override CreateDBInstanceEndpointResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBInstanceEndpointResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
