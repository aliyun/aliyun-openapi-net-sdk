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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class CheckServiceForRoleRequest : RpcAcsRequest<CheckServiceForRoleResponse>
    {
        public CheckServiceForRoleRequest()
            : base("live", "2016-11-01", "CheckServiceForRole", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string accountId;

		private string sPIRegionId;

		private string roleArn;

		private string deletionTaskId;

		private string serviceName;

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(QueryParameters, "AccountId", value);
			}
		}

		public string SPIRegionId
		{
			get
			{
				return sPIRegionId;
			}
			set	
			{
				sPIRegionId = value;
				DictionaryUtil.Add(QueryParameters, "SPIRegionId", value);
			}
		}

		public string RoleArn
		{
			get
			{
				return roleArn;
			}
			set	
			{
				roleArn = value;
				DictionaryUtil.Add(QueryParameters, "RoleArn", value);
			}
		}

		public string DeletionTaskId
		{
			get
			{
				return deletionTaskId;
			}
			set	
			{
				deletionTaskId = value;
				DictionaryUtil.Add(QueryParameters, "DeletionTaskId", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

        public override CheckServiceForRoleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckServiceForRoleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
