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
using Aliyun.Acs.mseap;
using Aliyun.Acs.mseap.Transform;
using Aliyun.Acs.mseap.Transform.V20210118;

namespace Aliyun.Acs.mseap.Model.V20210118
{
    public class GetPlatformUserInfoForPartnerRequest : RpcAcsRequest<GetPlatformUserInfoForPartnerResponse>
    {
        public GetPlatformUserInfoForPartnerRequest()
            : base("mseap", "2021-01-18", "GetPlatformUserInfoForPartner")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string userId;

		private string appId;

		private string platformType;

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
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
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string PlatformType
		{
			get
			{
				return platformType;
			}
			set	
			{
				platformType = value;
				DictionaryUtil.Add(QueryParameters, "PlatformType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetPlatformUserInfoForPartnerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetPlatformUserInfoForPartnerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
