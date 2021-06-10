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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class ListIpsecServersRequest : RpcAcsRequest<ListIpsecServersResponse>
    {
        public ListIpsecServersRequest()
            : base("Vpc", "2016-04-28", "ListIpsecServers", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string vpnGatewayId;

		private string nextToken;

		private string ipsecServerName;

		private int? maxResults;

		private List<string> ipsecServerIds = new List<string>(){ };

		public string VpnGatewayId
		{
			get
			{
				return vpnGatewayId;
			}
			set	
			{
				vpnGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "VpnGatewayId", value);
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public string IpsecServerName
		{
			get
			{
				return ipsecServerName;
			}
			set	
			{
				ipsecServerName = value;
				DictionaryUtil.Add(QueryParameters, "IpsecServerName", value);
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public List<string> IpsecServerIds
		{
			get
			{
				return ipsecServerIds;
			}

			set
			{
				ipsecServerIds = value;
				for (int i = 0; i < ipsecServerIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"IpsecServerId." + (i + 1) , ipsecServerIds[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListIpsecServersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListIpsecServersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
