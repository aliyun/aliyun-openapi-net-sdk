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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeTopRiskyAssetsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeTopRiskyAssets_TopRiskyAsset> topRiskyAssets;

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

		public List<DescribeTopRiskyAssets_TopRiskyAsset> TopRiskyAssets
		{
			get
			{
				return topRiskyAssets;
			}
			set	
			{
				topRiskyAssets = value;
			}
		}

		public class DescribeTopRiskyAssets_TopRiskyAsset
		{

			private string type;

			private List<DescribeTopRiskyAssets_AssetInfo> assetInfos;

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public List<DescribeTopRiskyAssets_AssetInfo> AssetInfos
			{
				get
				{
					return assetInfos;
				}
				set	
				{
					assetInfos = value;
				}
			}

			public class DescribeTopRiskyAssets_AssetInfo
			{

				private string uuid;

				private string ip;

				private string instanceName;

				private string count;

				public string Uuid
				{
					get
					{
						return uuid;
					}
					set	
					{
						uuid = value;
					}
				}

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
					}
				}

				public string InstanceName
				{
					get
					{
						return instanceName;
					}
					set	
					{
						instanceName = value;
					}
				}

				public string Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}
			}
		}
	}
}
