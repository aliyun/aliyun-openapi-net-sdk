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

namespace Aliyun.Acs.Sas_api.Model.V20170705
{
	public class DescribePerDateDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePerDateData_DataViewItem> dataView;

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

		public List<DescribePerDateData_DataViewItem> DataView
		{
			get
			{
				return dataView;
			}
			set	
			{
				dataView = value;
			}
		}

		public class DescribePerDateData_DataViewItem
		{

			private string dataTime;

			private long? callTimes;

			private long? totalHit;

			private long? hitRate;

			private long? isGreyPhone;

			private long? isBlackPhone;

			private long? isVirtualOperator;

			private long? isOpenCommonPort1d;

			private long? isOpenCommonPort7d;

			private long? isOpenCommonPort30d;

			private long? isCheatFlow1d;

			private long? isCheatFlow7d;

			private long? isCheatFlow30d;

			private long? isProxy1d;

			private long? isProxy7d;

			private long? isProxy30d;

			private long? isHiJack1d;

			private long? isHiJack7d;

			private long? isHiJack30d;

			private long? isC21d;

			private long? isC27d;

			private long? isC230d;

			private long? isBotnet1d;

			private long? isBotnet7d;

			private long? isBotnet30d;

			private long? isNetAttack1d;

			private long? isNetAttack7d;

			private long? isNetAttack30d;

			private long? isBlackCampaign1d;

			private long? isBlackCampaign7d;

			private long? isBlackCampaign30d;

			public string DataTime
			{
				get
				{
					return dataTime;
				}
				set	
				{
					dataTime = value;
				}
			}

			public long? CallTimes
			{
				get
				{
					return callTimes;
				}
				set	
				{
					callTimes = value;
				}
			}

			public long? TotalHit
			{
				get
				{
					return totalHit;
				}
				set	
				{
					totalHit = value;
				}
			}

			public long? HitRate
			{
				get
				{
					return hitRate;
				}
				set	
				{
					hitRate = value;
				}
			}

			public long? IsGreyPhone
			{
				get
				{
					return isGreyPhone;
				}
				set	
				{
					isGreyPhone = value;
				}
			}

			public long? IsBlackPhone
			{
				get
				{
					return isBlackPhone;
				}
				set	
				{
					isBlackPhone = value;
				}
			}

			public long? IsVirtualOperator
			{
				get
				{
					return isVirtualOperator;
				}
				set	
				{
					isVirtualOperator = value;
				}
			}

			public long? IsOpenCommonPort1d
			{
				get
				{
					return isOpenCommonPort1d;
				}
				set	
				{
					isOpenCommonPort1d = value;
				}
			}

			public long? IsOpenCommonPort7d
			{
				get
				{
					return isOpenCommonPort7d;
				}
				set	
				{
					isOpenCommonPort7d = value;
				}
			}

			public long? IsOpenCommonPort30d
			{
				get
				{
					return isOpenCommonPort30d;
				}
				set	
				{
					isOpenCommonPort30d = value;
				}
			}

			public long? IsCheatFlow1d
			{
				get
				{
					return isCheatFlow1d;
				}
				set	
				{
					isCheatFlow1d = value;
				}
			}

			public long? IsCheatFlow7d
			{
				get
				{
					return isCheatFlow7d;
				}
				set	
				{
					isCheatFlow7d = value;
				}
			}

			public long? IsCheatFlow30d
			{
				get
				{
					return isCheatFlow30d;
				}
				set	
				{
					isCheatFlow30d = value;
				}
			}

			public long? IsProxy1d
			{
				get
				{
					return isProxy1d;
				}
				set	
				{
					isProxy1d = value;
				}
			}

			public long? IsProxy7d
			{
				get
				{
					return isProxy7d;
				}
				set	
				{
					isProxy7d = value;
				}
			}

			public long? IsProxy30d
			{
				get
				{
					return isProxy30d;
				}
				set	
				{
					isProxy30d = value;
				}
			}

			public long? IsHiJack1d
			{
				get
				{
					return isHiJack1d;
				}
				set	
				{
					isHiJack1d = value;
				}
			}

			public long? IsHiJack7d
			{
				get
				{
					return isHiJack7d;
				}
				set	
				{
					isHiJack7d = value;
				}
			}

			public long? IsHiJack30d
			{
				get
				{
					return isHiJack30d;
				}
				set	
				{
					isHiJack30d = value;
				}
			}

			public long? IsC21d
			{
				get
				{
					return isC21d;
				}
				set	
				{
					isC21d = value;
				}
			}

			public long? IsC27d
			{
				get
				{
					return isC27d;
				}
				set	
				{
					isC27d = value;
				}
			}

			public long? IsC230d
			{
				get
				{
					return isC230d;
				}
				set	
				{
					isC230d = value;
				}
			}

			public long? IsBotnet1d
			{
				get
				{
					return isBotnet1d;
				}
				set	
				{
					isBotnet1d = value;
				}
			}

			public long? IsBotnet7d
			{
				get
				{
					return isBotnet7d;
				}
				set	
				{
					isBotnet7d = value;
				}
			}

			public long? IsBotnet30d
			{
				get
				{
					return isBotnet30d;
				}
				set	
				{
					isBotnet30d = value;
				}
			}

			public long? IsNetAttack1d
			{
				get
				{
					return isNetAttack1d;
				}
				set	
				{
					isNetAttack1d = value;
				}
			}

			public long? IsNetAttack7d
			{
				get
				{
					return isNetAttack7d;
				}
				set	
				{
					isNetAttack7d = value;
				}
			}

			public long? IsNetAttack30d
			{
				get
				{
					return isNetAttack30d;
				}
				set	
				{
					isNetAttack30d = value;
				}
			}

			public long? IsBlackCampaign1d
			{
				get
				{
					return isBlackCampaign1d;
				}
				set	
				{
					isBlackCampaign1d = value;
				}
			}

			public long? IsBlackCampaign7d
			{
				get
				{
					return isBlackCampaign7d;
				}
				set	
				{
					isBlackCampaign7d = value;
				}
			}

			public long? IsBlackCampaign30d
			{
				get
				{
					return isBlackCampaign30d;
				}
				set	
				{
					isBlackCampaign30d = value;
				}
			}
		}
	}
}
