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
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class UpdateUserRequest : RpcAcsRequest<UpdateUserResponse>
    {
        public UpdateUserRequest()
            : base("dms-enterprise", "2018-11-01", "UpdateUser", "dms-enterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string roleNames;

		private long? maxResultCount;

		private long? maxExecuteCount;

		private string userNick;

		private string mobile;

		private long? tid;

		private long? uid;

		[JsonProperty(PropertyName = "RoleNames")]
		public string RoleNames
		{
			get
			{
				return roleNames;
			}
			set	
			{
				roleNames = value;
				DictionaryUtil.Add(QueryParameters, "RoleNames", value);
			}
		}

		[JsonProperty(PropertyName = "MaxResultCount")]
		public long? MaxResultCount
		{
			get
			{
				return maxResultCount;
			}
			set	
			{
				maxResultCount = value;
				DictionaryUtil.Add(QueryParameters, "MaxResultCount", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "MaxExecuteCount")]
		public long? MaxExecuteCount
		{
			get
			{
				return maxExecuteCount;
			}
			set	
			{
				maxExecuteCount = value;
				DictionaryUtil.Add(QueryParameters, "MaxExecuteCount", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "UserNick")]
		public string UserNick
		{
			get
			{
				return userNick;
			}
			set	
			{
				userNick = value;
				DictionaryUtil.Add(QueryParameters, "UserNick", value);
			}
		}

		[JsonProperty(PropertyName = "Mobile")]
		public string Mobile
		{
			get
			{
				return mobile;
			}
			set	
			{
				mobile = value;
				DictionaryUtil.Add(QueryParameters, "Mobile", value);
			}
		}

		[JsonProperty(PropertyName = "Tid")]
		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Uid")]
		public long? Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value.ToString());
			}
		}

        public override UpdateUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
