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
using Aliyun.Acs.cloudesl;
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class QueryTemplateGroupListRequest : RpcAcsRequest<QueryTemplateGroupListResponse>
    {
        public QueryTemplateGroupListRequest()
            : base("cloudesl", "2020-02-01", "QueryTemplateGroupList")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? pageNumber;

		private string templateVersion;

		private int? pageSize;

		private string eslModelId;

		private int? widthPx;

		private string groupIds;

		private int? heightPx;

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

		public string TemplateVersion
		{
			get
			{
				return templateVersion;
			}
			set	
			{
				templateVersion = value;
				DictionaryUtil.Add(BodyParameters, "TemplateVersion", value);
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

		public string EslModelId
		{
			get
			{
				return eslModelId;
			}
			set	
			{
				eslModelId = value;
				DictionaryUtil.Add(BodyParameters, "EslModelId", value);
			}
		}

		public int? WidthPx
		{
			get
			{
				return widthPx;
			}
			set	
			{
				widthPx = value;
				DictionaryUtil.Add(BodyParameters, "WidthPx", value.ToString());
			}
		}

		public string GroupIds
		{
			get
			{
				return groupIds;
			}
			set	
			{
				groupIds = value;
				DictionaryUtil.Add(BodyParameters, "GroupIds", value);
			}
		}

		public int? HeightPx
		{
			get
			{
				return heightPx;
			}
			set	
			{
				heightPx = value;
				DictionaryUtil.Add(BodyParameters, "HeightPx", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryTemplateGroupListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTemplateGroupListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
