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
using Aliyun.Acs.cloudesl;
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class CheckServiceLinkedRoleForDeletingRequest : RpcAcsRequest<CheckServiceLinkedRoleForDeletingResponse>
    {
        public CheckServiceLinkedRoleForDeletingRequest()
            : base("cloudesl", "2020-02-01", "CheckServiceLinkedRoleForDeleting")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string extraParams;

		private string deletionTaskId;

		private string serviceName;

		private long? ownerId;

		private string sPIRegionId;

		private string roleArn;

		public string ExtraParams
		{
			get
			{
				return extraParams;
			}
			set	
			{
				extraParams = value;
				DictionaryUtil.Add(BodyParameters, "ExtraParams", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CheckServiceLinkedRoleForDeletingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckServiceLinkedRoleForDeletingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
