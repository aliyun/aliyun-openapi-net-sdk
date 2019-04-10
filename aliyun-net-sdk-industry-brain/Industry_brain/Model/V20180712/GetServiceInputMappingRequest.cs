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
using Aliyun.Acs.industry_brain.Transform;
using Aliyun.Acs.industry_brain.Transform.V20180712;

namespace Aliyun.Acs.industry_brain.Model.V20180712
{
    public class GetServiceInputMappingRequest : RpcAcsRequest<GetServiceInputMappingResponse>
    {
        public GetServiceInputMappingRequest()
            : base("industry_brain", "2018-07-12", "GetServiceInputMapping")
        {
        }

		private bool? showLatestData;

		private int? limit;

		private string serviceId;

		private string algorithmId;

		public bool? ShowLatestData
		{
			get
			{
				return showLatestData;
			}
			set	
			{
				showLatestData = value;
				DictionaryUtil.Add(QueryParameters, "ShowLatestData", value.ToString());
			}
		}

		public int? Limit
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

		public string ServiceId
		{
			get
			{
				return serviceId;
			}
			set	
			{
				serviceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceId", value);
			}
		}

		public string AlgorithmId
		{
			get
			{
				return algorithmId;
			}
			set	
			{
				algorithmId = value;
				DictionaryUtil.Add(QueryParameters, "AlgorithmId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetServiceInputMappingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetServiceInputMappingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
