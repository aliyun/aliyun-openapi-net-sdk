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
    public class GetAnalyzePlaceDataRequest : RpcAcsRequest<GetAnalyzePlaceDataResponse>
    {
        public GetAnalyzePlaceDataRequest()
            : base("cusanalytic_sc_online", "2019-05-24", "GetAnalyzePlaceData")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? endUVCount;

		private string startDate;

		private long? storeId;

		private long? parentAmount;

		private long? startUVCount;

		private string endDate;

		private long? locationId;

		private string parentLocationIds;

		public long? EndUVCount
		{
			get
			{
				return endUVCount;
			}
			set	
			{
				endUVCount = value;
				DictionaryUtil.Add(BodyParameters, "EndUVCount", value.ToString());
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

		public long? ParentAmount
		{
			get
			{
				return parentAmount;
			}
			set	
			{
				parentAmount = value;
				DictionaryUtil.Add(BodyParameters, "ParentAmount", value.ToString());
			}
		}

		public long? StartUVCount
		{
			get
			{
				return startUVCount;
			}
			set	
			{
				startUVCount = value;
				DictionaryUtil.Add(BodyParameters, "StartUVCount", value.ToString());
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

		public long? LocationId
		{
			get
			{
				return locationId;
			}
			set	
			{
				locationId = value;
				DictionaryUtil.Add(BodyParameters, "LocationId", value.ToString());
			}
		}

		public string ParentLocationIds
		{
			get
			{
				return parentLocationIds;
			}
			set	
			{
				parentLocationIds = value;
				DictionaryUtil.Add(BodyParameters, "ParentLocationIds", value);
			}
		}

        public override GetAnalyzePlaceDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetAnalyzePlaceDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
