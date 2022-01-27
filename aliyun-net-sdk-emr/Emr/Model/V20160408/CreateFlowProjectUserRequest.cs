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
    public class CreateFlowProjectUserRequest : RpcAcsRequest<CreateFlowProjectUserResponse>
    {
        public CreateFlowProjectUserRequest()
            : base("Emr", "2016-04-08", "CreateFlowProjectUser", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string projectId;

		private List<User> users = new List<User>(){ };

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

		public List<User> Users
		{
			get
			{
				return users;
			}

			set
			{
				users = value;
				for (int i = 0; i < users.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"User." + (i + 1) + ".UserId", users[i].UserId);
					DictionaryUtil.Add(QueryParameters,"User." + (i + 1) + ".UserName", users[i].UserName);
				}
			}
		}

		public class User
		{

			private string userId;

			private string userName;

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

        public override CreateFlowProjectUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateFlowProjectUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
