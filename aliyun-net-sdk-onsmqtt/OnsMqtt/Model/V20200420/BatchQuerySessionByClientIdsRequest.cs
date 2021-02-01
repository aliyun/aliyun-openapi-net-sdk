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
using Aliyun.Acs.OnsMqtt.Transform;
using Aliyun.Acs.OnsMqtt.Transform.V20200420;

namespace Aliyun.Acs.OnsMqtt.Model.V20200420
{
    public class BatchQuerySessionByClientIdsRequest : RpcAcsRequest<BatchQuerySessionByClientIdsResponse>
    {
        public BatchQuerySessionByClientIdsRequest()
            : base("OnsMqtt", "2020-04-20", "BatchQuerySessionByClientIds", "onsmqtt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OnsMqtt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OnsMqtt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> clientIdLists = new List<string>(){ };

		private string instanceId;

		public List<string> ClientIdLists
		{
			get
			{
				return clientIdLists;
			}

			set
			{
				clientIdLists = value;
				for (int i = 0; i < clientIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ClientIdList." + (i + 1) , clientIdLists[i]);
				}
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override BatchQuerySessionByClientIdsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchQuerySessionByClientIdsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
