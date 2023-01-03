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

namespace Aliyun.Acs.DBFS.Model.V20200418
{
	public class GetAutoSnapshotPolicyResponse : AcsResponse
	{

		private string requestId;

		private GetAutoSnapshotPolicy_Data data;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Data")]
		public GetAutoSnapshotPolicy_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetAutoSnapshotPolicy_Data
		{

			private string policyId;

			private string policyName;

			private string accountId;

			private string regionId;

			private string status;

			private string statusDetail;

			private int? retentionDays;

			private int? appliedDbfsNumber;

			private string createdTime;

			private string lastModified;

			private List<string> repeatWeekdays;

			private List<string> timePoints;

			[JsonProperty(PropertyName = "PolicyId")]
			public string PolicyId
			{
				get
				{
					return policyId;
				}
				set	
				{
					policyId = value;
				}
			}

			[JsonProperty(PropertyName = "PolicyName")]
			public string PolicyName
			{
				get
				{
					return policyName;
				}
				set	
				{
					policyName = value;
				}
			}

			[JsonProperty(PropertyName = "AccountId")]
			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "StatusDetail")]
			public string StatusDetail
			{
				get
				{
					return statusDetail;
				}
				set	
				{
					statusDetail = value;
				}
			}

			[JsonProperty(PropertyName = "RetentionDays")]
			public int? RetentionDays
			{
				get
				{
					return retentionDays;
				}
				set	
				{
					retentionDays = value;
				}
			}

			[JsonProperty(PropertyName = "AppliedDbfsNumber")]
			public int? AppliedDbfsNumber
			{
				get
				{
					return appliedDbfsNumber;
				}
				set	
				{
					appliedDbfsNumber = value;
				}
			}

			[JsonProperty(PropertyName = "CreatedTime")]
			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			[JsonProperty(PropertyName = "LastModified")]
			public string LastModified
			{
				get
				{
					return lastModified;
				}
				set	
				{
					lastModified = value;
				}
			}

			[JsonProperty(PropertyName = "RepeatWeekdays")]
			public List<string> RepeatWeekdays
			{
				get
				{
					return repeatWeekdays;
				}
				set	
				{
					repeatWeekdays = value;
				}
			}

			[JsonProperty(PropertyName = "TimePoints")]
			public List<string> TimePoints
			{
				get
				{
					return timePoints;
				}
				set	
				{
					timePoints = value;
				}
			}
		}
	}
}
