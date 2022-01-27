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
using Aliyun.Acs.scdn;
using Aliyun.Acs.scdn.Transform;
using Aliyun.Acs.scdn.Transform.V20171115;

namespace Aliyun.Acs.scdn.Model.V20171115
{
    public class SetScdnDomainBizInfoRequest : RpcAcsRequest<SetScdnDomainBizInfoResponse>
    {
        public SetScdnDomainBizInfoRequest()
            : base("scdn", "2017-11-15", "SetScdnDomainBizInfo")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.scdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.scdn.Endpoint.endpointRegionalType, null);
            }
        }

		private string bizName;

		private string domainName;

		private long? ownerId;

		public string BizName
		{
			get
			{
				return bizName;
			}
			set	
			{
				bizName = value;
				DictionaryUtil.Add(QueryParameters, "BizName", value);
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

        public override SetScdnDomainBizInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetScdnDomainBizInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
