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
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class QuerySavingsPlansDiscountRequest : RpcAcsRequest<QuerySavingsPlansDiscountResponse>
    {
        public QuerySavingsPlansDiscountRequest()
            : base("BssOpenApi", "2017-12-14", "QuerySavingsPlansDiscount", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
        }

		private string commodityCode;

		private string locale;

		private int? pageNum;

		private string cycle;

		private string spec;

		private string moduleCode;

		private string payMode;

		private int? pageSize;

		private string spnType;

		private string region;

		public string CommodityCode
		{
			get
			{
				return commodityCode;
			}
			set	
			{
				commodityCode = value;
				DictionaryUtil.Add(QueryParameters, "CommodityCode", value);
			}
		}

		public string Locale
		{
			get
			{
				return locale;
			}
			set	
			{
				locale = value;
				DictionaryUtil.Add(QueryParameters, "Locale", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public string Cycle
		{
			get
			{
				return cycle;
			}
			set	
			{
				cycle = value;
				DictionaryUtil.Add(QueryParameters, "Cycle", value);
			}
		}

		public string Spec
		{
			get
			{
				return spec;
			}
			set	
			{
				spec = value;
				DictionaryUtil.Add(QueryParameters, "Spec", value);
			}
		}

		public string ModuleCode
		{
			get
			{
				return moduleCode;
			}
			set	
			{
				moduleCode = value;
				DictionaryUtil.Add(QueryParameters, "ModuleCode", value);
			}
		}

		public string PayMode
		{
			get
			{
				return payMode;
			}
			set	
			{
				payMode = value;
				DictionaryUtil.Add(QueryParameters, "PayMode", value);
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

		public string SpnType
		{
			get
			{
				return spnType;
			}
			set	
			{
				spnType = value;
				DictionaryUtil.Add(QueryParameters, "SpnType", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QuerySavingsPlansDiscountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QuerySavingsPlansDiscountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
