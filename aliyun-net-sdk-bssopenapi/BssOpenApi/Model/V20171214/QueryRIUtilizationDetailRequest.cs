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
using Aliyun.Acs.BssOpenApi;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class QueryRIUtilizationDetailRequest : RpcAcsRequest<QueryRIUtilizationDetailResponse>
    {
        public QueryRIUtilizationDetailRequest()
            : base("BssOpenApi", "2017-12-14", "QueryRIUtilizationDetail")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string deductedInstanceId;

		private string instanceSpec;

		private string endTime;

		private string rIInstanceId;

		private string startTime;

		private int? pageNum;

		private int? pageSize;

		private string rICommodityCode;

		public string DeductedInstanceId
		{
			get
			{
				return deductedInstanceId;
			}
			set	
			{
				deductedInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DeductedInstanceId", value);
			}
		}

		public string InstanceSpec
		{
			get
			{
				return instanceSpec;
			}
			set	
			{
				instanceSpec = value;
				DictionaryUtil.Add(QueryParameters, "InstanceSpec", value);
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

		public string RIInstanceId
		{
			get
			{
				return rIInstanceId;
			}
			set	
			{
				rIInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "RIInstanceId", value);
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

		public string RICommodityCode
		{
			get
			{
				return rICommodityCode;
			}
			set	
			{
				rICommodityCode = value;
				DictionaryUtil.Add(QueryParameters, "RICommodityCode", value);
			}
		}

        public override QueryRIUtilizationDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryRIUtilizationDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
