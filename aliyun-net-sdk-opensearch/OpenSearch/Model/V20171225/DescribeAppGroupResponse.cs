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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class DescribeAppGroupResponse : AcsResponse
	{

		private string requestId;

		private DescribeAppGroup_Result result;

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

		public DescribeAppGroup_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeAppGroup_Result
		{

			private int? created;

			private string currentVersion;

			private int? pendingSecondRankAlgoDeploymentId;

			private string lockMode;

			private int? updated;

			private string id;

			private string chargeType;

			private int? hasPendingQuotaReviewTask;

			private int? secondRankAlgoDeploymentId;

			private string name;

			private string instanceId;

			private string processingOrderId;

			private int? chargingWay;

			private string type;

			private string status;

			private string projectId;

			private int? switchedTime;

			private string commodityCode;

			private string expireOn;

			private string domain;

			private string description;

			private int? firstRankAlgoDeploymentId;

			private int? produced;

			private int? lockedByExpiration;

			private List<DescribeAppGroup_TagsItem> tags;

			private DescribeAppGroup_Quota quota;

			public int? Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public string CurrentVersion
			{
				get
				{
					return currentVersion;
				}
				set	
				{
					currentVersion = value;
				}
			}

			public int? PendingSecondRankAlgoDeploymentId
			{
				get
				{
					return pendingSecondRankAlgoDeploymentId;
				}
				set	
				{
					pendingSecondRankAlgoDeploymentId = value;
				}
			}

			public string LockMode
			{
				get
				{
					return lockMode;
				}
				set	
				{
					lockMode = value;
				}
			}

			public int? Updated
			{
				get
				{
					return updated;
				}
				set	
				{
					updated = value;
				}
			}

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

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public int? HasPendingQuotaReviewTask
			{
				get
				{
					return hasPendingQuotaReviewTask;
				}
				set	
				{
					hasPendingQuotaReviewTask = value;
				}
			}

			public int? SecondRankAlgoDeploymentId
			{
				get
				{
					return secondRankAlgoDeploymentId;
				}
				set	
				{
					secondRankAlgoDeploymentId = value;
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

			public string ProcessingOrderId
			{
				get
				{
					return processingOrderId;
				}
				set	
				{
					processingOrderId = value;
				}
			}

			public int? ChargingWay
			{
				get
				{
					return chargingWay;
				}
				set	
				{
					chargingWay = value;
				}
			}

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

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public int? SwitchedTime
			{
				get
				{
					return switchedTime;
				}
				set	
				{
					switchedTime = value;
				}
			}

			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
				}
			}

			public string ExpireOn
			{
				get
				{
					return expireOn;
				}
				set	
				{
					expireOn = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
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

			public int? FirstRankAlgoDeploymentId
			{
				get
				{
					return firstRankAlgoDeploymentId;
				}
				set	
				{
					firstRankAlgoDeploymentId = value;
				}
			}

			public int? Produced
			{
				get
				{
					return produced;
				}
				set	
				{
					produced = value;
				}
			}

			public int? LockedByExpiration
			{
				get
				{
					return lockedByExpiration;
				}
				set	
				{
					lockedByExpiration = value;
				}
			}

			public List<DescribeAppGroup_TagsItem> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public DescribeAppGroup_Quota Quota
			{
				get
				{
					return quota;
				}
				set	
				{
					quota = value;
				}
			}

			public class DescribeAppGroup_TagsItem
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeAppGroup_Quota
			{

				private string spec;

				private int? docSize;

				private int? computeResource;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? DocSize
				{
					get
					{
						return docSize;
					}
					set	
					{
						docSize = value;
					}
				}

				public int? ComputeResource
				{
					get
					{
						return computeResource;
					}
					set	
					{
						computeResource = value;
					}
				}
			}
		}
	}
}
