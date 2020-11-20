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
using Aliyun.Acs.Cdn;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20180510;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class DescribeDomainUvDataRequest : RpcAcsRequest<DescribeDomainUvDataResponse>
    {
        public DescribeDomainUvDataRequest()
            : base("Cdn", "2018-05-10", "DescribeDomainUvData")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string domainName;

		private string endTime;

		private string startTime;

		private long? ownerId;

		private string securityToken;

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

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

        public override DescribeDomainUvDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDomainUvDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
