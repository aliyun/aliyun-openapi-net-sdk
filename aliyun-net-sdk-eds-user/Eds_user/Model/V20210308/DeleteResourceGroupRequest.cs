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
using Aliyun.Acs.eds_user.Transform;
using Aliyun.Acs.eds_user.Transform.V20210308;

namespace Aliyun.Acs.eds_user.Model.V20210308
{
    public class DeleteResourceGroupRequest : RpcAcsRequest<DeleteResourceGroupResponse>
    {
        public DeleteResourceGroupRequest()
            : base("eds-user", "2021-03-08", "DeleteResourceGroup", "eds-user", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceGroupId;

		private List<string> resourceGroupIds = new List<string>(){ };

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public List<string> ResourceGroupIds
		{
			get
			{
				return resourceGroupIds;
			}

			set
			{
				resourceGroupIds = value;
				if(resourceGroupIds != null)
				{
					for (int depth1 = 0; depth1 < resourceGroupIds.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ResourceGroupIds." + (depth1 + 1), resourceGroupIds[depth1]);
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteResourceGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteResourceGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
