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
using Aliyun.Acs.reid.Transform;
using Aliyun.Acs.reid.Transform.V20190928;

namespace Aliyun.Acs.reid.Model.V20190928
{
    public class DescribeBaseStatisticsRequest : RpcAcsRequest<DescribeBaseStatisticsResponse>
    {
        public DescribeBaseStatisticsRequest()
            : base("reid", "2019-09-28", "DescribeBaseStatistics", "1.1.8.5", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string date;

		private string extraStatisticTypes;

		private long? storeId;

		private string summaryType;

		private long? locationId;

		public string Date
		{
			get
			{
				return date;
			}
			set	
			{
				date = value;
				DictionaryUtil.Add(BodyParameters, "Date", value);
			}
		}

		public string ExtraStatisticTypes
		{
			get
			{
				return extraStatisticTypes;
			}
			set	
			{
				extraStatisticTypes = value;
				DictionaryUtil.Add(BodyParameters, "ExtraStatisticTypes", value);
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

		public string SummaryType
		{
			get
			{
				return summaryType;
			}
			set	
			{
				summaryType = value;
				DictionaryUtil.Add(BodyParameters, "SummaryType", value);
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

        public override DescribeBaseStatisticsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeBaseStatisticsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
