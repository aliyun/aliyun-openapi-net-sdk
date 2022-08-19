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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeVpnCrossAccountAuthorizationsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeVpnCrossAccountAuthorizations_CrossAccountAuthorization> crossAccountAuthorizations;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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
			}
		}

		public List<DescribeVpnCrossAccountAuthorizations_CrossAccountAuthorization> CrossAccountAuthorizations
		{
			get
			{
				return crossAccountAuthorizations;
			}
			set	
			{
				crossAccountAuthorizations = value;
			}
		}

		public class DescribeVpnCrossAccountAuthorizations_CrossAccountAuthorization
		{

			private string vpnConnectionId;

			private long? bindUid;

			private string bindProduct;

			private string bindInstance;

			private long? aliUid;

			private long? creationTime;

			public string VpnConnectionId
			{
				get
				{
					return vpnConnectionId;
				}
				set	
				{
					vpnConnectionId = value;
				}
			}

			public long? BindUid
			{
				get
				{
					return bindUid;
				}
				set	
				{
					bindUid = value;
				}
			}

			public string BindProduct
			{
				get
				{
					return bindProduct;
				}
				set	
				{
					bindProduct = value;
				}
			}

			public string BindInstance
			{
				get
				{
					return bindInstance;
				}
				set	
				{
					bindInstance = value;
				}
			}

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public long? CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}
		}
	}
}
