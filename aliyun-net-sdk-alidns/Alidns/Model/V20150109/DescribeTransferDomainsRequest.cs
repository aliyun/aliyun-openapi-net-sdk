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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class DescribeTransferDomainsRequest : RpcAcsRequest<DescribeTransferDomainsResponse>
    {
        public DescribeTransferDomainsRequest()
            : base("Alidns", "2015-01-09", "DescribeTransferDomains", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? fromUserId;

		private long? pageNumber;

		private long? targetUserId;

		private long? pageSize;

		private string lang;

		private string domainName;

		private string transferType;

		public long? FromUserId
		{
			get
			{
				return fromUserId;
			}
			set	
			{
				fromUserId = value;
				DictionaryUtil.Add(QueryParameters, "FromUserId", value.ToString());
			}
		}

		public long? PageNumber
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

		public long? TargetUserId
		{
			get
			{
				return targetUserId;
			}
			set	
			{
				targetUserId = value;
				DictionaryUtil.Add(QueryParameters, "TargetUserId", value.ToString());
			}
		}

		public long? PageSize
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

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string TransferType
		{
			get
			{
				return transferType;
			}
			set	
			{
				transferType = value;
				DictionaryUtil.Add(QueryParameters, "TransferType", value);
			}
		}

        public override DescribeTransferDomainsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeTransferDomainsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
