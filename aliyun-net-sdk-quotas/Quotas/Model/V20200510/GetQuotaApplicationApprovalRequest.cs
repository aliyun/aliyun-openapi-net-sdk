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
using Aliyun.Acs.quotas.Transform;
using Aliyun.Acs.quotas.Transform.V20200510;

namespace Aliyun.Acs.quotas.Model.V20200510
{
    public class GetQuotaApplicationApprovalRequest : RpcAcsRequest<GetQuotaApplicationApprovalResponse>
    {
        public GetQuotaApplicationApprovalRequest()
            : base("quotas", "2020-05-10", "GetQuotaApplicationApproval", "quotas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string applicationId;

		public string ApplicationId
		{
			get
			{
				return applicationId;
			}
			set	
			{
				applicationId = value;
				DictionaryUtil.Add(BodyParameters, "ApplicationId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetQuotaApplicationApprovalResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetQuotaApplicationApprovalResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
