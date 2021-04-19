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
using Aliyun.Acs.reid_cloud.Transform;
using Aliyun.Acs.reid_cloud.Transform.V20201029;

namespace Aliyun.Acs.reid_cloud.Model.V20201029
{
    public class DescribeCustomerFlowByLocationRequest : RpcAcsRequest<DescribeCustomerFlowByLocationResponse>
    {
        public DescribeCustomerFlowByLocationRequest()
            : base("reid_cloud", "2020-10-29", "DescribeCustomerFlowByLocation", "1.2.1", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.reid_cloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.reid_cloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string startDate;

		private long? storeId;

		private long? minCount;

		private long? parentAmount;

		private long? maxCount;

		private string endDate;

		private long? locationId;

		private string parentLocationIds;

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

		public long? MinCount
		{
			get
			{
				return minCount;
			}
			set	
			{
				minCount = value;
				DictionaryUtil.Add(BodyParameters, "MinCount", value.ToString());
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

		public long? MaxCount
		{
			get
			{
				return maxCount;
			}
			set	
			{
				maxCount = value;
				DictionaryUtil.Add(BodyParameters, "MaxCount", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeCustomerFlowByLocationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeCustomerFlowByLocationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
