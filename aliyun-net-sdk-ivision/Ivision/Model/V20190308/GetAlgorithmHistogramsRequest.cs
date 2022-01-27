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
using Aliyun.Acs.ivision;
using Aliyun.Acs.ivision.Transform;
using Aliyun.Acs.ivision.Transform.V20190308;

namespace Aliyun.Acs.ivision.Model.V20190308
{
    public class GetAlgorithmHistogramsRequest : RpcAcsRequest<GetAlgorithmHistogramsResponse>
    {
        public GetAlgorithmHistogramsRequest()
            : base("ivision", "2019-03-08", "GetAlgorithmHistograms")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ivision.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ivision.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string endDate;

		private string startDate;

		private string algorithmCode;

		private string aggregateType;

		public string EndDate
		{
			get
			{
				return endDate;
			}
			set	
			{
				endDate = value;
				DictionaryUtil.Add(QueryParameters, "EndDate", value);
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
				DictionaryUtil.Add(QueryParameters, "StartDate", value);
			}
		}

		public string AlgorithmCode
		{
			get
			{
				return algorithmCode;
			}
			set	
			{
				algorithmCode = value;
				DictionaryUtil.Add(QueryParameters, "AlgorithmCode", value);
			}
		}

		public string AggregateType
		{
			get
			{
				return aggregateType;
			}
			set	
			{
				aggregateType = value;
				DictionaryUtil.Add(QueryParameters, "AggregateType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetAlgorithmHistogramsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetAlgorithmHistogramsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
