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
    public class DescribeSnatTableEntriesRequest : RpcAcsRequest<DescribeSnatTableEntriesResponse>
    {
        public DescribeSnatTableEntriesRequest()
            : base("Vpc", "2016-04-28", "DescribeSnatTableEntries", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string sourceCIDR;

		private string snatIp;

		private int? pageNumber;

		private string sourceVSwitchId;

		private int? pageSize;

		private string snatEntryId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string snatTableId;

		private long? ownerId;

		private string snatEntryName;

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

		public string SourceCIDR
		{
			get
			{
				return sourceCIDR;
			}
			set	
			{
				sourceCIDR = value;
				DictionaryUtil.Add(QueryParameters, "SourceCIDR", value);
			}
		}

		public string SnatIp
		{
			get
			{
				return snatIp;
			}
			set	
			{
				snatIp = value;
				DictionaryUtil.Add(QueryParameters, "SnatIp", value);
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

		public string SourceVSwitchId
		{
			get
			{
				return sourceVSwitchId;
			}
			set	
			{
				sourceVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "SourceVSwitchId", value);
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

		public string SnatEntryId
		{
			get
			{
				return snatEntryId;
			}
			set	
			{
				snatEntryId = value;
				DictionaryUtil.Add(QueryParameters, "SnatEntryId", value);
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

		public string SnatTableId
		{
			get
			{
				return snatTableId;
			}
			set	
			{
				snatTableId = value;
				DictionaryUtil.Add(QueryParameters, "SnatTableId", value);
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

		public string SnatEntryName
		{
			get
			{
				return snatEntryName;
			}
			set	
			{
				snatEntryName = value;
				DictionaryUtil.Add(QueryParameters, "SnatEntryName", value);
			}
		}

        public override DescribeSnatTableEntriesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSnatTableEntriesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
