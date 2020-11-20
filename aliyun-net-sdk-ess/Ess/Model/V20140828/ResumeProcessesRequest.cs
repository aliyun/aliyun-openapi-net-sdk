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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class ResumeProcessesRequest : RpcAcsRequest<ResumeProcessesResponse>
    {
        public ResumeProcessesRequest()
            : base("Ess", "2014-08-28", "ResumeProcesses", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string scalingGroupId;

		private List<string> processs = new List<string>(){ };

		private string resourceOwnerAccount;

		private long? ownerId;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string ScalingGroupId
		{
			get
			{
				return scalingGroupId;
			}
			set	
			{
				scalingGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId", value);
			}
		}

		public List<string> Processs
		{
			get
			{
				return processs;
			}

			set
			{
				processs = value;
				for (int i = 0; i < processs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Process." + (i + 1) , processs[i]);
				}
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
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

        public override ResumeProcessesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ResumeProcessesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
