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
	public class DescribeDomainCCAttackInfoResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private List<DescribeDomainCCAttackInfo_AttackIpDatas> attackIpDataList;

		private List<DescribeDomainCCAttackInfo_AttackedUrlDatas> attackedUrlDataList;

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

		public List<DescribeDomainCCAttackInfo_AttackIpDatas> AttackIpDataList
		{
			get
			{
				return attackIpDataList;
			}
			set	
			{
				attackIpDataList = value;
			}
		}

		public List<DescribeDomainCCAttackInfo_AttackedUrlDatas> AttackedUrlDataList
		{
			get
			{
				return attackedUrlDataList;
			}
			set	
			{
				attackedUrlDataList = value;
			}
		}

		public class DescribeDomainCCAttackInfo_AttackIpDatas
		{

			private string ip;

			private string attackCount;

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

			public string AttackCount
			{
				get
				{
					return attackCount;
				}
				set	
				{
					attackCount = value;
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

		public class DescribeDomainCCAttackInfo_AttackedUrlDatas
		{

			private string url;

			private string attackCount;

			private string result;

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

			public string AttackCount
			{
				get
				{
					return attackCount;
				}
				set	
				{
					attackCount = value;
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