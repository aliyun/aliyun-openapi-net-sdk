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
	public class DescribeWhiteListEffectiveAssetsResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageSize;

		private int? totalCount;

		private int? currentPage;

		private List<DescribeWhiteListEffectiveAssets_Asset> assets;

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

		public int? Count
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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public List<DescribeWhiteListEffectiveAssets_Asset> Assets
		{
			get
			{
				return assets;
			}
			set	
			{
				assets = value;
			}
		}

		public class DescribeWhiteListEffectiveAssets_Asset
		{

			private string uuid;

			private string machineName;

			private string internetIp;

			private string intranetIp;

			private long? strategyId;

			private string strategyName;

			private int? suspiciousEventCount;

			private int? processMethod;

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

			public string MachineName
			{
				get
				{
					return machineName;
				}
				set	
				{
					machineName = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public long? StrategyId
			{
				get
				{
					return strategyId;
				}
				set	
				{
					strategyId = value;
				}
			}

			public string StrategyName
			{
				get
				{
					return strategyName;
				}
				set	
				{
					strategyName = value;
				}
			}

			public int? SuspiciousEventCount
			{
				get
				{
					return suspiciousEventCount;
				}
				set	
				{
					suspiciousEventCount = value;
				}
			}

			public int? ProcessMethod
			{
				get
				{
					return processMethod;
				}
				set	
				{
					processMethod = value;
				}
			}
		}
	}
}
