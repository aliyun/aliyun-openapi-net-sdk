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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class MetastoreListDataResourcesResponse : AcsResponse
	{

		private string requestId;

		private List<MetastoreListDataResources_DataResourceInfo> dataResources;

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

		public List<MetastoreListDataResources_DataResourceInfo> DataResources
		{
			get
			{
				return dataResources;
			}
			set	
			{
				dataResources = value;
			}
		}

		public class MetastoreListDataResources_DataResourceInfo
		{

			private string id;

			private string regionId;

			private string name;

			private string metaType;

			private long? clusterId;

			private string accessType;

			private bool? _default;

			private string description;

			public string Id
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

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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

			public string MetaType
			{
				get
				{
					return metaType;
				}
				set	
				{
					metaType = value;
				}
			}

			public long? ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string AccessType
			{
				get
				{
					return accessType;
				}
				set	
				{
					accessType = value;
				}
			}

			public bool? _Default
			{
				get
				{
					return _default;
				}
				set	
				{
					_default = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}
	}
}
