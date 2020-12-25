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
    public class CreateUsersRequest : RpcAcsRequest<CreateUsersResponse>
    {
        public CreateUsersRequest()
            : base("Emr", "2016-04-08", "CreateUsers", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clusterId;

		private List<UserInfo> userInfos = new List<UserInfo>(){ };

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

		public List<UserInfo> UserInfos
		{
			get
			{
				return userInfos;
			}

			set
			{
				userInfos = value;
				for (int i = 0; i < userInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserInfo." + (i + 1) + ".Type", userInfos[i].Type);
					DictionaryUtil.Add(QueryParameters,"UserInfo." + (i + 1) + ".UserId", userInfos[i].UserId);
					DictionaryUtil.Add(QueryParameters,"UserInfo." + (i + 1) + ".UserName", userInfos[i].UserName);
				}
			}
		}

		public class UserInfo
		{

			private string type;

			private string userId;

			private string userName;

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}
		}

        public override CreateUsersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateUsersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
