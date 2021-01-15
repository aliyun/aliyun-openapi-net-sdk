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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class ModifyAppGroupQuotaResponse : AcsResponse
	{

		private string requestId;

		private ModifyAppGroupQuota_Result result;

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

		public ModifyAppGroupQuota_Result Result
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

		public class ModifyAppGroupQuota_Result
		{

			private string id;

			private string name;

			private string currentVersion;

			private int? switchedTime;

			private int? chargingWay;

			private string type;

			private string projectId;

			private string chargeType;

			private string expireOn;

			private string instanceId;

			private string commodityCode;

			private string processingOrderId;

			private int? firstRankAlgoDeploymentId;

			private int? secondRankAlgoDeploymentId;

			private int? pendingSecondRankAlgoDeploymentId;

			private string description;

			private int? produced;

			private int? lockedByExpiration;

			private int? hasPendingQuotaReviewTask;

			private int? created;

			private int? updated;

			private string status;

			private string lockMode;

			private ModifyAppGroupQuota_Quota quota;

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

			public ModifyAppGroupQuota_Quota Quota
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

			public class ModifyAppGroupQuota_Quota
			{

				private int? docSize;

				private int? computeResource;

				private string spec;

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
			}
		}
	}
}
