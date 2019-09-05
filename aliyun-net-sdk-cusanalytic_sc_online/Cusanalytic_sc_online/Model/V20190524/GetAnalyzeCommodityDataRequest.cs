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
using Aliyun.Acs.cusanalytic_sc_online;
using Aliyun.Acs.cusanalytic_sc_online.Transform;
using Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
    public class GetAnalyzeCommodityDataRequest : RpcAcsRequest<GetAnalyzeCommodityDataResponse>
    {
        public GetAnalyzeCommodityDataRequest()
            : base("cusanalytic_sc_online", "2019-05-24", "GetAnalyzeCommodityData")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? storeId;

		private string startDate;

		private long? endUserCount;

		private int? pageSize;

		private int? pageIndex;

		private long? stayPeriod;

		private long? startUserCount;

		private long? minSupportCount;

		private string endDate;

		public long? StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value.ToString());
			}
		}

		public string StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
				DictionaryUtil.Add(BodyParameters, "StartDate", value);
			}
		}

		public long? EndUserCount
		{
			get
			{
				return endUserCount;
			}
			set	
			{
				endUserCount = value;
				DictionaryUtil.Add(BodyParameters, "EndUserCount", value.ToString());
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

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
				DictionaryUtil.Add(BodyParameters, "PageIndex", value.ToString());
			}
		}

		public long? StayPeriod
		{
			get
			{
				return stayPeriod;
			}
			set	
			{
				stayPeriod = value;
				DictionaryUtil.Add(BodyParameters, "StayPeriod", value.ToString());
			}
		}

		public long? StartUserCount
		{
			get
			{
				return startUserCount;
			}
			set	
			{
				startUserCount = value;
				DictionaryUtil.Add(BodyParameters, "StartUserCount", value.ToString());
			}
		}

		public long? MinSupportCount
		{
			get
			{
				return minSupportCount;
			}
			set	
			{
				minSupportCount = value;
				DictionaryUtil.Add(BodyParameters, "MinSupportCount", value.ToString());
			}
		}

		public string EndDate
		{
			get
			{
				return endDate;
			}
			set	
			{
				endDate = value;
				DictionaryUtil.Add(BodyParameters, "EndDate", value);
			}
		}

        public override GetAnalyzeCommodityDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetAnalyzeCommodityDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
