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
    public class ModifyClusterServiceConfigRequest : RpcAcsRequest<ModifyClusterServiceConfigResponse>
    {
        public ModifyClusterServiceConfigRequest()
            : base("Emr", "2016-04-08", "ModifyClusterServiceConfig", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? refreshHostConfig;

		private long? resourceOwnerId;

		private string hostInstanceId;

		private string serviceName;

		private List<string> gatewayClusterIdLists = new List<string>(){ };

		private string configParams;

		private string configType;

		private string groupId;

		private string clusterId;

		private string customConfigParams;

		private string comment;

		public bool? RefreshHostConfig
		{
			get
			{
				return refreshHostConfig;
			}
			set	
			{
				refreshHostConfig = value;
				DictionaryUtil.Add(QueryParameters, "RefreshHostConfig", value.ToString());
			}
		}

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

		public string HostInstanceId
		{
			get
			{
				return hostInstanceId;
			}
			set	
			{
				hostInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "HostInstanceId", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public List<string> GatewayClusterIdLists
		{
			get
			{
				return gatewayClusterIdLists;
			}

			set
			{
				gatewayClusterIdLists = value;
				for (int i = 0; i < gatewayClusterIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"GatewayClusterIdList." + (i + 1) , gatewayClusterIdLists[i]);
				}
			}
		}

		public string ConfigParams
		{
			get
			{
				return configParams;
			}
			set	
			{
				configParams = value;
				DictionaryUtil.Add(QueryParameters, "ConfigParams", value);
			}
		}

		public string ConfigType
		{
			get
			{
				return configType;
			}
			set	
			{
				configType = value;
				DictionaryUtil.Add(QueryParameters, "ConfigType", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
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

		public string CustomConfigParams
		{
			get
			{
				return customConfigParams;
			}
			set	
			{
				customConfigParams = value;
				DictionaryUtil.Add(QueryParameters, "CustomConfigParams", value);
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

        public override ModifyClusterServiceConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyClusterServiceConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
