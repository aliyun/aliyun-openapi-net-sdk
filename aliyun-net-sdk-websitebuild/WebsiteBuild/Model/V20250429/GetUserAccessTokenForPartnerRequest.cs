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
using Aliyun.Acs.WebsiteBuild;
using Aliyun.Acs.WebsiteBuild.Transform;
using Aliyun.Acs.WebsiteBuild.Transform.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
    public class GetUserAccessTokenForPartnerRequest : RpcAcsRequest<GetUserAccessTokenForPartnerResponse>
    {
        public GetUserAccessTokenForPartnerRequest()
            : base("WebsiteBuild", "2025-04-29", "GetUserAccessTokenForPartner")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string ticket;

		private string siteHost;

		public string Ticket
		{
			get
			{
				return ticket;
			}
			set	
			{
				ticket = value;
				DictionaryUtil.Add(QueryParameters, "Ticket", value);
			}
		}

		public string SiteHost
		{
			get
			{
				return siteHost;
			}
			set	
			{
				siteHost = value;
				DictionaryUtil.Add(QueryParameters, "SiteHost", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetUserAccessTokenForPartnerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetUserAccessTokenForPartnerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
