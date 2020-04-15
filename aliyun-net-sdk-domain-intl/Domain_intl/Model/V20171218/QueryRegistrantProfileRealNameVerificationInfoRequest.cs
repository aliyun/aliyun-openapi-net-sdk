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
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class QueryRegistrantProfileRealNameVerificationInfoRequest : RpcAcsRequest<QueryRegistrantProfileRealNameVerificationInfoResponse>
    {
        public QueryRegistrantProfileRealNameVerificationInfoRequest()
            : base("Domain-intl", "2017-12-18", "QueryRegistrantProfileRealNameVerificationInfo", "domain", "openAPI")
        {
        }

		private bool? fetchImage;

		private long? registrantProfileId;

		private string userClientIp;

		private string lang;

		public bool? FetchImage
		{
			get
			{
				return fetchImage;
			}
			set	
			{
				fetchImage = value;
				DictionaryUtil.Add(QueryParameters, "FetchImage", value.ToString());
			}
		}

		public long? RegistrantProfileId
		{
			get
			{
				return registrantProfileId;
			}
			set	
			{
				registrantProfileId = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantProfileId", value.ToString());
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

        public override QueryRegistrantProfileRealNameVerificationInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryRegistrantProfileRealNameVerificationInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
