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
using Aliyun.Acs.appstream_center;
using Aliyun.Acs.appstream_center.Transform;
using Aliyun.Acs.appstream_center.Transform.V20210901;

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
    public class ModifyAppInstanceGroupAttributeRequest : RpcAcsRequest<ModifyAppInstanceGroupAttributeResponse>
    {
        public ModifyAppInstanceGroupAttributeRequest()
            : base("appstream-center", "2021-09-01", "ModifyAppInstanceGroupAttribute")
        {
			Method = MethodType.POST;
        }

		private NodePool nodePool_;

		private string productType;

		private string appInstanceGroupName;

		private int? sessionTimeout;

		private string appInstanceGroupId;

		[JsonProperty(PropertyName = "NodePool")]
		public NodePool NodePool_
		{
			get
			{
				return nodePool_;
			}

			set
			{
				nodePool_ = value;
				DictionaryUtil.Add(QueryParameters, "NodePool", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "ProductType")]
		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		[JsonProperty(PropertyName = "AppInstanceGroupName")]
		public string AppInstanceGroupName
		{
			get
			{
				return appInstanceGroupName;
			}
			set	
			{
				appInstanceGroupName = value;
				DictionaryUtil.Add(QueryParameters, "AppInstanceGroupName", value);
			}
		}

		[JsonProperty(PropertyName = "SessionTimeout")]
		public int? SessionTimeout
		{
			get
			{
				return sessionTimeout;
			}
			set	
			{
				sessionTimeout = value;
				DictionaryUtil.Add(QueryParameters, "SessionTimeout", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AppInstanceGroupId")]
		public string AppInstanceGroupId
		{
			get
			{
				return appInstanceGroupId;
			}
			set	
			{
				appInstanceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "AppInstanceGroupId", value);
			}
		}

		public class NodePool
		{

			private string nodePoolId;

			private int? nodeCapacity;

			[JsonProperty(PropertyName = "NodePoolId")]
			public string NodePoolId
			{
				get
				{
					return nodePoolId;
				}
				set	
				{
					nodePoolId = value;
				}
			}

			[JsonProperty(PropertyName = "NodeCapacity")]
			public int? NodeCapacity
			{
				get
				{
					return nodeCapacity;
				}
				set	
				{
					nodeCapacity = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyAppInstanceGroupAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAppInstanceGroupAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
