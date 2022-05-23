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
using Aliyun.Acs.btripOpen;
using Aliyun.Acs.btripOpen.Transform;
using Aliyun.Acs.btripOpen.Transform.V20220517;

namespace Aliyun.Acs.btripOpen.Model.V20220517
{
    public class TakeAccessTokenRequest : RoaAcsRequest<TakeAccessTokenResponse>
    {
        public TakeAccessTokenRequest()
            : base("btripOpen", "2022-05-17", "TakeAccessToken")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/btrip/open/access-token/take";
			Method = MethodType.GET;
        }

		private string app_key;

		private string app_secret;

		public string App_key
		{
			get
			{
				return app_key;
			}
			set	
			{
				app_key = value;
				DictionaryUtil.Add(QueryParameters, "app_key", value);
			}
		}

		public string App_secret
		{
			get
			{
				return app_secret;
			}
			set	
			{
				app_secret = value;
				DictionaryUtil.Add(QueryParameters, "app_secret", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TakeAccessTokenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TakeAccessTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
