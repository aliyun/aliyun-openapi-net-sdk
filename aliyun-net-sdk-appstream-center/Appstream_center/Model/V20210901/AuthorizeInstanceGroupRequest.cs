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
using Aliyun.Acs.appstream_center;
using Aliyun.Acs.appstream_center.Transform;
using Aliyun.Acs.appstream_center.Transform.V20210901;

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
    public class AuthorizeInstanceGroupRequest : RpcAcsRequest<AuthorizeInstanceGroupResponse>
    {
        public AuthorizeInstanceGroupRequest()
            : base("appstream-center", "2021-09-01", "AuthorizeInstanceGroup")
        {
			Method = MethodType.POST;
        }

		private List<string> unAuthorizeUserIdss = new List<string>(){ };

		private string productType;

		private string appInstanceGroupId;

		private List<string> authorizeUserIdss = new List<string>(){ };

		public List<string> UnAuthorizeUserIdss
		{
			get
			{
				return unAuthorizeUserIdss;
			}

			set
			{
				unAuthorizeUserIdss = value;
			}
		}

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(BodyParameters, "ProductType", value);
			}
		}

		public string AppInstanceGroupId
		{
			get
			{
				return appInstanceGroupId;
			}
			set	
			{
				appInstanceGroupId = value;
				DictionaryUtil.Add(BodyParameters, "AppInstanceGroupId", value);
			}
		}

		public List<string> AuthorizeUserIdss
		{
			get
			{
				return authorizeUserIdss;
			}

			set
			{
				authorizeUserIdss = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AuthorizeInstanceGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AuthorizeInstanceGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
