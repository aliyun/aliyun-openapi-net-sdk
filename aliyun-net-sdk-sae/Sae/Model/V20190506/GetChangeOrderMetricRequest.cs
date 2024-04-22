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
using Aliyun.Acs.sae.Transform;
using Aliyun.Acs.sae.Transform.V20190506;

namespace Aliyun.Acs.sae.Model.V20190506
{
    public class GetChangeOrderMetricRequest : RoaAcsRequest<GetChangeOrderMetricResponse>
    {
        public GetChangeOrderMetricRequest()
            : base("sae", "2019-05-06", "GetChangeOrderMetric", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/sam/getChangeOrderMetric";
			Method = MethodType.GET;
        }

		private string appSource;

		private string createTime;

		private string cpuStrategy;

		private long? limit;

		private string orderBy;

		public string AppSource
		{
			get
			{
				return appSource;
			}
			set	
			{
				appSource = value;
				DictionaryUtil.Add(QueryParameters, "AppSource", value);
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
				DictionaryUtil.Add(QueryParameters, "CreateTime", value);
			}
		}

		public string CpuStrategy
		{
			get
			{
				return cpuStrategy;
			}
			set	
			{
				cpuStrategy = value;
				DictionaryUtil.Add(QueryParameters, "CpuStrategy", value);
			}
		}

		public long? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
			}
		}

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetChangeOrderMetricResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetChangeOrderMetricResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
