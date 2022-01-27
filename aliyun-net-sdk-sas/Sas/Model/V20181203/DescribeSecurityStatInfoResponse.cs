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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeSecurityStatInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeSecurityStatInfo_SecurityEvent securityEvent;

		private DescribeSecurityStatInfo_AttackEvent attackEvent;

		private DescribeSecurityStatInfo_HealthCheck healthCheck;

		private DescribeSecurityStatInfo_Vulnerability vulnerability;

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

		public DescribeSecurityStatInfo_SecurityEvent SecurityEvent
		{
			get
			{
				return securityEvent;
			}
			set	
			{
				securityEvent = value;
			}
		}

		public DescribeSecurityStatInfo_AttackEvent AttackEvent
		{
			get
			{
				return attackEvent;
			}
			set	
			{
				attackEvent = value;
			}
		}

		public DescribeSecurityStatInfo_HealthCheck HealthCheck
		{
			get
			{
				return healthCheck;
			}
			set	
			{
				healthCheck = value;
			}
		}

		public DescribeSecurityStatInfo_Vulnerability Vulnerability
		{
			get
			{
				return vulnerability;
			}
			set	
			{
				vulnerability = value;
			}
		}

		public class DescribeSecurityStatInfo_SecurityEvent
		{

			private int? seriousCount;

			private int? suspiciousCount;

			private int? remindCount;

			private int? totalCount;

			private List<string> dateArray;

			private List<string> valueArray;

			private List<string> levelsOn;

			private List<string> seriousList;

			private List<string> suspiciousList;

			private List<string> remindList;

			private List<string> timeArray;

			public int? SeriousCount
			{
				get
				{
					return seriousCount;
				}
				set	
				{
					seriousCount = value;
				}
			}

			public int? SuspiciousCount
			{
				get
				{
					return suspiciousCount;
				}
				set	
				{
					suspiciousCount = value;
				}
			}

			public int? RemindCount
			{
				get
				{
					return remindCount;
				}
				set	
				{
					remindCount = value;
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

			public List<string> DateArray
			{
				get
				{
					return dateArray;
				}
				set	
				{
					dateArray = value;
				}
			}

			public List<string> ValueArray
			{
				get
				{
					return valueArray;
				}
				set	
				{
					valueArray = value;
				}
			}

			public List<string> LevelsOn
			{
				get
				{
					return levelsOn;
				}
				set	
				{
					levelsOn = value;
				}
			}

			public List<string> SeriousList
			{
				get
				{
					return seriousList;
				}
				set	
				{
					seriousList = value;
				}
			}

			public List<string> SuspiciousList
			{
				get
				{
					return suspiciousList;
				}
				set	
				{
					suspiciousList = value;
				}
			}

			public List<string> RemindList
			{
				get
				{
					return remindList;
				}
				set	
				{
					remindList = value;
				}
			}

			public List<string> TimeArray
			{
				get
				{
					return timeArray;
				}
				set	
				{
					timeArray = value;
				}
			}
		}

		public class DescribeSecurityStatInfo_AttackEvent
		{

			private int? totalCount;

			private List<string> dateArray1;

			private List<string> valueArray2;

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

			public List<string> DateArray1
			{
				get
				{
					return dateArray1;
				}
				set	
				{
					dateArray1 = value;
				}
			}

			public List<string> ValueArray2
			{
				get
				{
					return valueArray2;
				}
				set	
				{
					valueArray2 = value;
				}
			}
		}

		public class DescribeSecurityStatInfo_HealthCheck
		{

			private int? mediumCount;

			private int? highCount;

			private int? lowCount;

			private int? totalCount;

			private List<string> dateArray3;

			private List<string> valueArray4;

			private List<string> levelsOn5;

			private List<string> highList;

			private List<string> mediumList;

			private List<string> lowList;

			private List<string> timeArray6;

			public int? MediumCount
			{
				get
				{
					return mediumCount;
				}
				set	
				{
					mediumCount = value;
				}
			}

			public int? HighCount
			{
				get
				{
					return highCount;
				}
				set	
				{
					highCount = value;
				}
			}

			public int? LowCount
			{
				get
				{
					return lowCount;
				}
				set	
				{
					lowCount = value;
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

			public List<string> DateArray3
			{
				get
				{
					return dateArray3;
				}
				set	
				{
					dateArray3 = value;
				}
			}

			public List<string> ValueArray4
			{
				get
				{
					return valueArray4;
				}
				set	
				{
					valueArray4 = value;
				}
			}

			public List<string> LevelsOn5
			{
				get
				{
					return levelsOn5;
				}
				set	
				{
					levelsOn5 = value;
				}
			}

			public List<string> HighList
			{
				get
				{
					return highList;
				}
				set	
				{
					highList = value;
				}
			}

			public List<string> MediumList
			{
				get
				{
					return mediumList;
				}
				set	
				{
					mediumList = value;
				}
			}

			public List<string> LowList
			{
				get
				{
					return lowList;
				}
				set	
				{
					lowList = value;
				}
			}

			public List<string> TimeArray6
			{
				get
				{
					return timeArray6;
				}
				set	
				{
					timeArray6 = value;
				}
			}
		}

		public class DescribeSecurityStatInfo_Vulnerability
		{

			private int? nntfCount;

			private int? laterCount;

			private int? asapCount;

			private int? totalCount;

			private List<string> dateArray7;

			private List<string> valueArray8;

			private List<string> levelsOn9;

			private List<string> nntfList;

			private List<string> asapList;

			private List<string> laterList;

			private List<string> timeArray10;

			public int? NntfCount
			{
				get
				{
					return nntfCount;
				}
				set	
				{
					nntfCount = value;
				}
			}

			public int? LaterCount
			{
				get
				{
					return laterCount;
				}
				set	
				{
					laterCount = value;
				}
			}

			public int? AsapCount
			{
				get
				{
					return asapCount;
				}
				set	
				{
					asapCount = value;
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

			public List<string> DateArray7
			{
				get
				{
					return dateArray7;
				}
				set	
				{
					dateArray7 = value;
				}
			}

			public List<string> ValueArray8
			{
				get
				{
					return valueArray8;
				}
				set	
				{
					valueArray8 = value;
				}
			}

			public List<string> LevelsOn9
			{
				get
				{
					return levelsOn9;
				}
				set	
				{
					levelsOn9 = value;
				}
			}

			public List<string> NntfList
			{
				get
				{
					return nntfList;
				}
				set	
				{
					nntfList = value;
				}
			}

			public List<string> AsapList
			{
				get
				{
					return asapList;
				}
				set	
				{
					asapList = value;
				}
			}

			public List<string> LaterList
			{
				get
				{
					return laterList;
				}
				set	
				{
					laterList = value;
				}
			}

			public List<string> TimeArray10
			{
				get
				{
					return timeArray10;
				}
				set	
				{
					timeArray10 = value;
				}
			}
		}
	}
}
