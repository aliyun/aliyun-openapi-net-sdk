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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SetDefaultRegistrantProfileRequest : RpcAcsRequest<SetDefaultRegistrantProfileResponse>
    {
        public SetDefaultRegistrantProfileRequest()
            : base("Domain", "2018-01-29", "SetDefaultRegistrantProfile", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? registrantProfileId;

		private string userClientIp;

		[JsonProperty(PropertyName = "RegistrantProfileId")]
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

		[JsonProperty(PropertyName = "UserClientIp")]
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetDefaultRegistrantProfileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetDefaultRegistrantProfileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
