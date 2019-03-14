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
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class DescribeCenVbrHealthCheckRequest : RpcAcsRequest<DescribeCenVbrHealthCheckResponse>
    {
        public DescribeCenVbrHealthCheckRequest()
            : base("Cbn", "2017-09-12", "DescribeCenVbrHealthCheck", "cbn", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string cenId;

		private long? vbrInstanceOwnerId;

		private string ownerAccount;

		private string vbrInstanceId;

		private int? pageSize;

		private string action;

		private long? ownerId;

		private string vbrInstanceRegionId;

		private int? pageNumber;

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

		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
				DictionaryUtil.Add(QueryParameters, "CenId", value);
			}
		}

		public long? VbrInstanceOwnerId
		{
			get
			{
				return vbrInstanceOwnerId;
			}
			set	
			{
				vbrInstanceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "VbrInstanceOwnerId", value.ToString());
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

		public string VbrInstanceId
		{
			get
			{
				return vbrInstanceId;
			}
			set	
			{
				vbrInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "VbrInstanceId", value);
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

		public string VbrInstanceRegionId
		{
			get
			{
				return vbrInstanceRegionId;
			}
			set	
			{
				vbrInstanceRegionId = value;
				DictionaryUtil.Add(QueryParameters, "VbrInstanceRegionId", value);
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

        public override DescribeCenVbrHealthCheckResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeCenVbrHealthCheckResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
