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
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class ListDataServiceApisRequest : RpcAcsRequest<ListDataServiceApisResponse>
    {
        public ListDataServiceApisRequest()
            : base("dataworks-public", "2020-05-18", "ListDataServiceApis", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string apiNameKeyword;

		private string apiPathKeyword;

		private string creatorId;

		private int? pageNumber;

		private int? pageSize;

		private long? tenantId;

		private long? projectId;

		public string ApiNameKeyword
		{
			get
			{
				return apiNameKeyword;
			}
			set	
			{
				apiNameKeyword = value;
				DictionaryUtil.Add(BodyParameters, "ApiNameKeyword", value);
			}
		}

		public string ApiPathKeyword
		{
			get
			{
				return apiPathKeyword;
			}
			set	
			{
				apiPathKeyword = value;
				DictionaryUtil.Add(BodyParameters, "ApiPathKeyword", value);
			}
		}

		public string CreatorId
		{
			get
			{
				return creatorId;
			}
			set	
			{
				creatorId = value;
				DictionaryUtil.Add(BodyParameters, "CreatorId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(BodyParameters, "TenantId", value.ToString());
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDataServiceApisResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDataServiceApisResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
