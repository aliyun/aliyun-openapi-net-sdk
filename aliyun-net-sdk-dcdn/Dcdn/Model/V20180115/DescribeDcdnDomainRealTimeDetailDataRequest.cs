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
    public class DescribeDcdnDomainRealTimeDetailDataRequest : RpcAcsRequest<DescribeDcdnDomainRealTimeDetailDataResponse>
    {
        public DescribeDcdnDomainRealTimeDetailDataRequest()
            : base("dcdn", "2018-01-15", "DescribeDcdnDomainRealTimeDetailData")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dcdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dcdn.Endpoint.endpointRegionalType, null);
            }
        }

		private string locationNameEn;

		private string startTime;

		private string ispNameEn;

		private string merge;

		private string domainName;

		private string endTime;

		private string mergeLocIsp;

		private long? ownerId;

		private string field;

		public string LocationNameEn
		{
			get
			{
				return locationNameEn;
			}
			set	
			{
				locationNameEn = value;
				DictionaryUtil.Add(QueryParameters, "LocationNameEn", value);
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

		public string IspNameEn
		{
			get
			{
				return ispNameEn;
			}
			set	
			{
				ispNameEn = value;
				DictionaryUtil.Add(QueryParameters, "IspNameEn", value);
			}
		}

		public string Merge
		{
			get
			{
				return merge;
			}
			set	
			{
				merge = value;
				DictionaryUtil.Add(QueryParameters, "Merge", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
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

		public string MergeLocIsp
		{
			get
			{
				return mergeLocIsp;
			}
			set	
			{
				mergeLocIsp = value;
				DictionaryUtil.Add(QueryParameters, "MergeLocIsp", value);
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

		public string Field
		{
			get
			{
				return field;
			}
			set	
			{
				field = value;
				DictionaryUtil.Add(QueryParameters, "Field", value);
			}
		}

        public override DescribeDcdnDomainRealTimeDetailDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDcdnDomainRealTimeDetailDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
