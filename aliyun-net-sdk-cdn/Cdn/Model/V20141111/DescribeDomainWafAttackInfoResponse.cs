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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeDomainWafAttackInfoResponse : AcsResponse
	{

		private string domainName;

		private string startTime;

		private string endTime;

		private int? pageNumber;

		private int? pageSize;

		private List<AttackDatas> attackDataList;

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
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

		public List<AttackDatas> AttackDataList
		{
			get
			{
				return attackDataList;
			}
			set	
			{
				attackDataList = value;
			}
		}

		public class AttackDatas{

			private string ip;

			private string time;

			private string url;

			private string type;

			private string result;

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

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
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

			public string Result
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
		}
	}
}