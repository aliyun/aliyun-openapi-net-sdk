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
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20181212;

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
    public class GetMainPartListRequest : RpcAcsRequest<GetMainPartListResponse>
    {
        public GetMainPartListRequest()
            : base("UniMkt", "2018-12-12", "GetMainPartList", "1.0.0", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string accountType;

		private int? pageSize;

		private int? pageIndex;

		private int? mainType;

		private long? parentMainId;

		private string mainName;

		public string AccountType
		{
			get
			{
				return accountType;
			}
			set	
			{
				accountType = value;
				DictionaryUtil.Add(QueryParameters, "AccountType", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
				DictionaryUtil.Add(QueryParameters, "PageIndex", value.ToString());
			}
		}

		public int? MainType
		{
			get
			{
				return mainType;
			}
			set	
			{
				mainType = value;
				DictionaryUtil.Add(QueryParameters, "MainType", value.ToString());
			}
		}

		public long? ParentMainId
		{
			get
			{
				return parentMainId;
			}
			set	
			{
				parentMainId = value;
				DictionaryUtil.Add(QueryParameters, "ParentMainId", value.ToString());
			}
		}

		public string MainName
		{
			get
			{
				return mainName;
			}
			set	
			{
				mainName = value;
				DictionaryUtil.Add(QueryParameters, "MainName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetMainPartListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetMainPartListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
