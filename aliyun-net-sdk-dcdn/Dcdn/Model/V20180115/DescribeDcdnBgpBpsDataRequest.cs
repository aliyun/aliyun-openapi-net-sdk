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
using Aliyun.Acs.dcdn;
using Aliyun.Acs.dcdn.Transform;
using Aliyun.Acs.dcdn.Transform.V20180115;

namespace Aliyun.Acs.dcdn.Model.V20180115
{
    public class DescribeDcdnBgpBpsDataRequest : RpcAcsRequest<DescribeDcdnBgpBpsDataResponse>
    {
        public DescribeDcdnBgpBpsDataRequest()
            : base("dcdn", "2018-01-15", "DescribeDcdnBgpBpsData")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dcdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dcdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string isp;

		private string startTime;

		private string endTime;

		private long? ownerId;

		private string interval;

		public string Isp
		{
			get
			{
				return isp;
			}
			set	
			{
				isp = value;
				DictionaryUtil.Add(QueryParameters, "Isp", value);
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
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
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
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeDcdnBgpBpsDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDcdnBgpBpsDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
