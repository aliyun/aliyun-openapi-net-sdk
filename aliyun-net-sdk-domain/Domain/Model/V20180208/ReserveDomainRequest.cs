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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180208;

namespace Aliyun.Acs.Domain.Model.V20180208
{
    public class ReserveDomainRequest : RpcAcsRequest<ReserveDomainResponse>
    {
        public ReserveDomainRequest()
            : base("Domain", "2018-02-08", "ReserveDomain", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> channelss = new List<string>(){ };

		private string domainName;

		public List<string> Channelss
		{
			get
			{
				return channelss;
			}

			set
			{
				channelss = value;
				for (int i = 0; i < channelss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Channels." + (i + 1) , channelss[i]);
				}
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(BodyParameters, "DomainName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ReserveDomainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ReserveDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
