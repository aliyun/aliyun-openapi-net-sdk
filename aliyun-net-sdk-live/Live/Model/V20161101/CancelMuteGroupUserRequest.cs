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
    public class CancelMuteGroupUserRequest : RpcAcsRequest<CancelMuteGroupUserResponse>
    {
        public CancelMuteGroupUserRequest()
            : base("live", "2016-11-01", "CancelMuteGroupUser", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> cancelMuteUserList = new List<string>(){ };

		private string operatorUserId;

		private int? broadCastType;

		private string groupId;

		private string appId;

		public List<string> CancelMuteUserList
		{
			get
			{
				return cancelMuteUserList;
			}

			set
			{
				cancelMuteUserList = value;
				if(cancelMuteUserList != null)
				{
					for (int depth1 = 0; depth1 < cancelMuteUserList.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"CancelMuteUserList." + (depth1 + 1), cancelMuteUserList[depth1]);
					}
				}
			}
		}

		public string OperatorUserId
		{
			get
			{
				return operatorUserId;
			}
			set	
			{
				operatorUserId = value;
				DictionaryUtil.Add(BodyParameters, "OperatorUserId", value);
			}
		}

		public int? BroadCastType
		{
			get
			{
				return broadCastType;
			}
			set	
			{
				broadCastType = value;
				DictionaryUtil.Add(BodyParameters, "BroadCastType", value.ToString());
			}
		}

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

        public override CancelMuteGroupUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CancelMuteGroupUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
