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
    public class ListVpnCertificateAssociationsRequest : RpcAcsRequest<ListVpnCertificateAssociationsResponse>
    {
        public ListVpnCertificateAssociationsRequest()
            : base("Vpc", "2016-04-28", "ListVpnCertificateAssociations", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> certificateIds = new List<string>(){ };

		private List<string> vpnGatewayIds = new List<string>(){ };

		private string certificateType;

		private string nextToken;

		private int? maxResults;

		public List<string> CertificateIds
		{
			get
			{
				return certificateIds;
			}

			set
			{
				certificateIds = value;
				for (int i = 0; i < certificateIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"CertificateId." + (i + 1) , certificateIds[i]);
				}
			}
		}

		public List<string> VpnGatewayIds
		{
			get
			{
				return vpnGatewayIds;
			}

			set
			{
				vpnGatewayIds = value;
				for (int i = 0; i < vpnGatewayIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"VpnGatewayId." + (i + 1) , vpnGatewayIds[i]);
				}
			}
		}

		public string CertificateType
		{
			get
			{
				return certificateType;
			}
			set	
			{
				certificateType = value;
				DictionaryUtil.Add(QueryParameters, "CertificateType", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListVpnCertificateAssociationsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListVpnCertificateAssociationsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
