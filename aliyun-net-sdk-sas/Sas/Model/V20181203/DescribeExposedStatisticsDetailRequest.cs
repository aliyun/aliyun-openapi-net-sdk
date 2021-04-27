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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class DescribeExposedStatisticsDetailRequest : RpcAcsRequest<DescribeExposedStatisticsDetailResponse>
    {
        public DescribeExposedStatisticsDetailRequest()
            : base("Sas", "2018-12-03", "DescribeExposedStatisticsDetail", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string statisticsType;

		private string statisticsTypeGatewayType;

		private int? currentPage;

		private string statisticsTypeInstanceValue;

		private int? pageSize;

		public string StatisticsType
		{
			get
			{
				return statisticsType;
			}
			set	
			{
				statisticsType = value;
				DictionaryUtil.Add(QueryParameters, "StatisticsType", value);
			}
		}

		public string StatisticsTypeGatewayType
		{
			get
			{
				return statisticsTypeGatewayType;
			}
			set	
			{
				statisticsTypeGatewayType = value;
				DictionaryUtil.Add(QueryParameters, "StatisticsTypeGatewayType", value);
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public string StatisticsTypeInstanceValue
		{
			get
			{
				return statisticsTypeInstanceValue;
			}
			set	
			{
				statisticsTypeInstanceValue = value;
				DictionaryUtil.Add(QueryParameters, "StatisticsTypeInstanceValue", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeExposedStatisticsDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeExposedStatisticsDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
