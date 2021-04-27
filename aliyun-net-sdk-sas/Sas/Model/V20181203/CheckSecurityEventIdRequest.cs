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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class CheckSecurityEventIdRequest : RpcAcsRequest<CheckSecurityEventIdResponse>
    {
        public CheckSecurityEventIdRequest()
            : base("Sas", "2018-12-03", "CheckSecurityEventId", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> securityEventIdss = new List<string>(){ };

		private string uuid;

		public List<string> SecurityEventIdss
		{
			get
			{
				return securityEventIdss;
			}

			set
			{
				securityEventIdss = value;
				for (int i = 0; i < securityEventIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SecurityEventIds." + (i + 1) , securityEventIdss[i]);
				}
			}
		}

		public string Uuid
		{
			get
			{
				return uuid;
			}
			set	
			{
				uuid = value;
				DictionaryUtil.Add(QueryParameters, "Uuid", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CheckSecurityEventIdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckSecurityEventIdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
