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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class ListMessageGroupUserByIdRequest : RpcAcsRequest<ListMessageGroupUserByIdResponse>
    {
        public ListMessageGroupUserByIdRequest()
            : base("live", "2016-11-01", "ListMessageGroupUserById", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> userIdList = new List<string>(){ };

		private string groupId;

		private string appId;

		[JsonProperty(PropertyName = "UserIdList")]
		public List<string> UserIdList
		{
			get
			{
				return userIdList;
			}

			set
			{
				userIdList = value;
				if(userIdList != null)
				{
					for (int depth1 = 0; depth1 < userIdList.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"UserIdList." + (depth1 + 1), userIdList[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "GroupId")]
		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(BodyParameters, "GroupId", value);
			}
		}

		[JsonProperty(PropertyName = "AppId")]
		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(BodyParameters, "AppId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListMessageGroupUserByIdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListMessageGroupUserByIdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
