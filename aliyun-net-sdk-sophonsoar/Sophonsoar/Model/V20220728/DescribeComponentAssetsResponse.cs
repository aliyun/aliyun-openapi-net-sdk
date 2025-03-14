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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeComponentAssetsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeComponentAssets_ComponentAssetsItem> componentAssets;

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

		public List<DescribeComponentAssets_ComponentAssetsItem> ComponentAssets
		{
			get
			{
				return componentAssets;
			}
			set	
			{
				componentAssets = value;
			}
		}

		public class DescribeComponentAssets_ComponentAssetsItem
		{

			private long? id;

			private string gmtCreate;

			private string gmtModified;

			private string name;

			private string componentname;

			private string _params;

			private string domainId;

			private string tenantId;

			private string owner;

			private string assetUuid;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Componentname
			{
				get
				{
					return componentname;
				}
				set	
				{
					componentname = value;
				}
			}

			public string _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}

			public string DomainId
			{
				get
				{
					return domainId;
				}
				set	
				{
					domainId = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string AssetUuid
			{
				get
				{
					return assetUuid;
				}
				set	
				{
					assetUuid = value;
				}
			}
		}
	}
}
