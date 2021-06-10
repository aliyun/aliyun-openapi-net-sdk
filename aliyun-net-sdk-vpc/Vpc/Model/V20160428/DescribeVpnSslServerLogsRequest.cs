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
    public class DescribeVpnSslServerLogsRequest : RpcAcsRequest<DescribeVpnSslServerLogsResponse>
    {
        public DescribeVpnSslServerLogsRequest()
            : base("Vpc", "2016-04-28", "DescribeVpnSslServerLogs", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? pageNumber;

		private int? minutePeriod;

		private int? pageSize;

		private string vpnSslServerId;

		private int? from;

		private string sslVpnClientCertId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private int? to;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public int? MinutePeriod
		{
			get
			{
				return minutePeriod;
			}
			set	
			{
				minutePeriod = value;
				DictionaryUtil.Add(QueryParameters, "MinutePeriod", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string VpnSslServerId
		{
			get
			{
				return vpnSslServerId;
			}
			set	
			{
				vpnSslServerId = value;
				DictionaryUtil.Add(QueryParameters, "VpnSslServerId", value);
			}
		}

		public int? From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(QueryParameters, "From", value.ToString());
			}
		}

		public string SslVpnClientCertId
		{
			get
			{
				return sslVpnClientCertId;
			}
			set	
			{
				sslVpnClientCertId = value;
				DictionaryUtil.Add(QueryParameters, "SslVpnClientCertId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? To
		{
			get
			{
				return to;
			}
			set	
			{
				to = value;
				DictionaryUtil.Add(QueryParameters, "To", value.ToString());
			}
		}

        public override DescribeVpnSslServerLogsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeVpnSslServerLogsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
