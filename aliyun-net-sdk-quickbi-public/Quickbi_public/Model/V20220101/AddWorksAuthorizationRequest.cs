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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class AddWorksAuthorizationRequest : RpcAcsRequest<AddWorksAuthorizationResponse>
    {
        public AddWorksAuthorizationRequest()
            : base("quickbi-public", "2022-01-01", "AddWorksAuthorization", "2.2.0", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string authorizedId;

		private int? authPoints;

		private int? authorizeScope;

		private string resourceId;

		private string resourceType;

		private string expireDay;

		public string AuthorizedId
		{
			get
			{
				return authorizedId;
			}
			set	
			{
				authorizedId = value;
				DictionaryUtil.Add(QueryParameters, "AuthorizedId", value);
			}
		}

		public int? AuthPoints
		{
			get
			{
				return authPoints;
			}
			set	
			{
				authPoints = value;
				DictionaryUtil.Add(QueryParameters, "AuthPoints", value.ToString());
			}
		}

		public int? AuthorizeScope
		{
			get
			{
				return authorizeScope;
			}
			set	
			{
				authorizeScope = value;
				DictionaryUtil.Add(QueryParameters, "AuthorizeScope", value.ToString());
			}
		}

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId", value);
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string ExpireDay
		{
			get
			{
				return expireDay;
			}
			set	
			{
				expireDay = value;
				DictionaryUtil.Add(QueryParameters, "ExpireDay", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddWorksAuthorizationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddWorksAuthorizationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
