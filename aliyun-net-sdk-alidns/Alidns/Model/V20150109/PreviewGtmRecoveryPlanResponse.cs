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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class PreviewGtmRecoveryPlanResponse : AcsResponse
	{

		private string requestId;

		private int? totalItems;

		private int? totalPages;

		private int? pageSize;

		private int? pageNumber;

		private List<PreviewGtmRecoveryPlan_Preview> previews;

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

		public int? TotalItems
		{
			get
			{
				return totalItems;
			}
			set	
			{
				totalItems = value;
			}
		}

		public int? TotalPages
		{
			get
			{
				return totalPages;
			}
			set	
			{
				totalPages = value;
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

		public List<PreviewGtmRecoveryPlan_Preview> Previews
		{
			get
			{
				return previews;
			}
			set	
			{
				previews = value;
			}
		}

		public class PreviewGtmRecoveryPlan_Preview
		{

			private string instanceId;

			private string name;

			private string userDomainName;

			private List<PreviewGtmRecoveryPlan_SwitchInfo> switchInfos;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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

			public string UserDomainName
			{
				get
				{
					return userDomainName;
				}
				set	
				{
					userDomainName = value;
				}
			}

			public List<PreviewGtmRecoveryPlan_SwitchInfo> SwitchInfos
			{
				get
				{
					return switchInfos;
				}
				set	
				{
					switchInfos = value;
				}
			}

			public class PreviewGtmRecoveryPlan_SwitchInfo
			{

				private string strategyName;

				private string content;

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

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}
			}
		}
	}
}
