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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class QueryDomainGroupListRequest : RpcAcsRequest<QueryDomainGroupListResponse>
    {
        public QueryDomainGroupListRequest()
            : base("Domain", "2018-01-29", "QueryDomainGroupList", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? showDeletingGroup;

		private string userClientIp;

		private string domainGroupName;

		private string lang;

		public bool? ShowDeletingGroup
		{
			get
			{
				return showDeletingGroup;
			}
			set	
			{
				showDeletingGroup = value;
				DictionaryUtil.Add(QueryParameters, "ShowDeletingGroup", value.ToString());
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string DomainGroupName
		{
			get
			{
				return domainGroupName;
			}
			set	
			{
				domainGroupName = value;
				DictionaryUtil.Add(QueryParameters, "DomainGroupName", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

        public override QueryDomainGroupListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryDomainGroupListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
