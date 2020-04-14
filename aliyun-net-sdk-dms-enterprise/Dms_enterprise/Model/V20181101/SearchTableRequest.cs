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
    public class SearchTableRequest : RpcAcsRequest<SearchTableResponse>
    {
        public SearchTableRequest()
            : base("dms-enterprise", "2018-11-01", "SearchTable", "dmsenterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string searchTarget;

		private int? pageSize;

		private string envType;

		private string searchKey;

		private string searchRange;

		private long? tid;

		private int? pageNumber;

		public string SearchTarget
		{
			get
			{
				return searchTarget;
			}
			set	
			{
				searchTarget = value;
				DictionaryUtil.Add(QueryParameters, "SearchTarget", value);
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

		public string EnvType
		{
			get
			{
				return envType;
			}
			set	
			{
				envType = value;
				DictionaryUtil.Add(QueryParameters, "EnvType", value);
			}
		}

		public string SearchKey
		{
			get
			{
				return searchKey;
			}
			set	
			{
				searchKey = value;
				DictionaryUtil.Add(QueryParameters, "SearchKey", value);
			}
		}

		public string SearchRange
		{
			get
			{
				return searchRange;
			}
			set	
			{
				searchRange = value;
				DictionaryUtil.Add(QueryParameters, "SearchRange", value);
			}
		}

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

        public override SearchTableResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchTableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
