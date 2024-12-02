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

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class GetProjectResponse : AcsResponse
	{

		private string requestId;

		private string name;

		private string description;

		private string offlineDatasourceType;

		private string offlineDatasourceId;

		private string offlineDatasourceName;

		private string onlineDatasourceType;

		private string onlineDatasourceId;

		private string onlineDatasourceName;

		private int? offlineLifecycle;

		private int? featureEntityCount;

		private int? featureViewCount;

		private int? modelCount;

		private string owner;

		private string gmtCreateTime;

		private string gmtModifiedTime;

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

		public string OfflineDatasourceType
		{
			get
			{
				return offlineDatasourceType;
			}
			set	
			{
				offlineDatasourceType = value;
			}
		}

		public string OfflineDatasourceId
		{
			get
			{
				return offlineDatasourceId;
			}
			set	
			{
				offlineDatasourceId = value;
			}
		}

		public string OfflineDatasourceName
		{
			get
			{
				return offlineDatasourceName;
			}
			set	
			{
				offlineDatasourceName = value;
			}
		}

		public string OnlineDatasourceType
		{
			get
			{
				return onlineDatasourceType;
			}
			set	
			{
				onlineDatasourceType = value;
			}
		}

		public string OnlineDatasourceId
		{
			get
			{
				return onlineDatasourceId;
			}
			set	
			{
				onlineDatasourceId = value;
			}
		}

		public string OnlineDatasourceName
		{
			get
			{
				return onlineDatasourceName;
			}
			set	
			{
				onlineDatasourceName = value;
			}
		}

		public int? OfflineLifecycle
		{
			get
			{
				return offlineLifecycle;
			}
			set	
			{
				offlineLifecycle = value;
			}
		}

		public int? FeatureEntityCount
		{
			get
			{
				return featureEntityCount;
			}
			set	
			{
				featureEntityCount = value;
			}
		}

		public int? FeatureViewCount
		{
			get
			{
				return featureViewCount;
			}
			set	
			{
				featureViewCount = value;
			}
		}

		public int? ModelCount
		{
			get
			{
				return modelCount;
			}
			set	
			{
				modelCount = value;
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

		public string GmtCreateTime
		{
			get
			{
				return gmtCreateTime;
			}
			set	
			{
				gmtCreateTime = value;
			}
		}

		public string GmtModifiedTime
		{
			get
			{
				return gmtModifiedTime;
			}
			set	
			{
				gmtModifiedTime = value;
			}
		}
	}
}
