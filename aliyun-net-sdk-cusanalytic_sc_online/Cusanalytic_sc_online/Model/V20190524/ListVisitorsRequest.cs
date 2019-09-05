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
    public class ListVisitorsRequest : RpcAcsRequest<ListVisitorsResponse>
    {
        public ListVisitorsRequest()
            : base("cusanalytic_sc_online", "2019-05-24", "ListVisitors")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string gender;

		private long? ukId;

		private string locationIds;

		private string startTime;

		private int? pageSize;

		private long? enterCount;

		private int? pageIndex;

		private long? ageStart;

		private long? ageEnd;

		private string pkId;

		private string endTime;

		private string storeIds;

		public string Gender
		{
			get
			{
				return gender;
			}
			set	
			{
				gender = value;
				DictionaryUtil.Add(BodyParameters, "Gender", value);
			}
		}

		public long? UkId
		{
			get
			{
				return ukId;
			}
			set	
			{
				ukId = value;
				DictionaryUtil.Add(BodyParameters, "UkId", value.ToString());
			}
		}

		public string LocationIds
		{
			get
			{
				return locationIds;
			}
			set	
			{
				locationIds = value;
				DictionaryUtil.Add(BodyParameters, "LocationIds", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value);
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

		public long? EnterCount
		{
			get
			{
				return enterCount;
			}
			set	
			{
				enterCount = value;
				DictionaryUtil.Add(BodyParameters, "EnterCount", value.ToString());
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

		public long? AgeStart
		{
			get
			{
				return ageStart;
			}
			set	
			{
				ageStart = value;
				DictionaryUtil.Add(BodyParameters, "AgeStart", value.ToString());
			}
		}

		public long? AgeEnd
		{
			get
			{
				return ageEnd;
			}
			set	
			{
				ageEnd = value;
				DictionaryUtil.Add(BodyParameters, "AgeEnd", value.ToString());
			}
		}

		public string PkId
		{
			get
			{
				return pkId;
			}
			set	
			{
				pkId = value;
				DictionaryUtil.Add(BodyParameters, "PkId", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value);
			}
		}

		public string StoreIds
		{
			get
			{
				return storeIds;
			}
			set	
			{
				storeIds = value;
				DictionaryUtil.Add(BodyParameters, "StoreIds", value);
			}
		}

        public override ListVisitorsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListVisitorsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
