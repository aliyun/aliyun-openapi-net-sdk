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

namespace Aliyun.Acs.ltl.Model.V20190510
{
	public class DescribeMPCoSResourceInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeMPCoSResourceInfo_Data data;

		[JsonProperty(PropertyName = "Code")]
		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public DescribeMPCoSResourceInfo_Data Data
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

		public class DescribeMPCoSResourceInfo_Data
		{

			private long? phaseGroupQuota;

			private long? memberQuota;

			private long? usedMember;

			private long? usedPhaseGroup;

			private List<DescribeMPCoSResourceInfo_PhaseQuotaInfo> phaseQuotaInfoList;

			[JsonProperty(PropertyName = "PhaseGroupQuota")]
			public long? PhaseGroupQuota
			{
				get
				{
					return phaseGroupQuota;
				}
				set	
				{
					phaseGroupQuota = value;
				}
			}

			[JsonProperty(PropertyName = "MemberQuota")]
			public long? MemberQuota
			{
				get
				{
					return memberQuota;
				}
				set	
				{
					memberQuota = value;
				}
			}

			[JsonProperty(PropertyName = "UsedMember")]
			public long? UsedMember
			{
				get
				{
					return usedMember;
				}
				set	
				{
					usedMember = value;
				}
			}

			[JsonProperty(PropertyName = "UsedPhaseGroup")]
			public long? UsedPhaseGroup
			{
				get
				{
					return usedPhaseGroup;
				}
				set	
				{
					usedPhaseGroup = value;
				}
			}

			[JsonProperty(PropertyName = "PhaseQuotaInfoList")]
			public List<DescribeMPCoSResourceInfo_PhaseQuotaInfo> PhaseQuotaInfoList
			{
				get
				{
					return phaseQuotaInfoList;
				}
				set	
				{
					phaseQuotaInfoList = value;
				}
			}

			public class DescribeMPCoSResourceInfo_PhaseQuotaInfo
			{

				private string phaseGroupId;

				private string phaseGroupName;

				private long? phaseQuota;

				private long? usedPhase;

				[JsonProperty(PropertyName = "PhaseGroupId")]
				public string PhaseGroupId
				{
					get
					{
						return phaseGroupId;
					}
					set	
					{
						phaseGroupId = value;
					}
				}

				[JsonProperty(PropertyName = "PhaseGroupName")]
				public string PhaseGroupName
				{
					get
					{
						return phaseGroupName;
					}
					set	
					{
						phaseGroupName = value;
					}
				}

				[JsonProperty(PropertyName = "PhaseQuota")]
				public long? PhaseQuota
				{
					get
					{
						return phaseQuota;
					}
					set	
					{
						phaseQuota = value;
					}
				}

				[JsonProperty(PropertyName = "UsedPhase")]
				public long? UsedPhase
				{
					get
					{
						return usedPhase;
					}
					set	
					{
						usedPhase = value;
					}
				}
			}
		}
	}
}
