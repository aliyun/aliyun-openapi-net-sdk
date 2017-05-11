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
	public class DescribeHistoryCharge95InfoResponse : AcsResponse
	{

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private long? totalPages;

		private string userName;

		private List<HistoryCharge95Info> historyCharge95Infos;

		public long? PageNumber
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

		public long? PageSize
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

		public long? TotalCount
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

		public long? TotalPages
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

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
			}
		}

		public List<HistoryCharge95Info> HistoryCharge95Infos
		{
			get
			{
				return historyCharge95Infos;
			}
			set	
			{
				historyCharge95Infos = value;
			}
		}

		public class HistoryCharge95Info{

			private string domainName;

			private string billTime;

			private string chargeItem;

			private long? max95Bps;

			private string max95BpsTime;

			private float? effectiveFactor;

			private string startTime;

			private string endTime;

			private float? proportion;

			private string downloadUrl;

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

			public string BillTime
			{
				get
				{
					return billTime;
				}
				set	
				{
					billTime = value;
				}
			}

			public string ChargeItem
			{
				get
				{
					return chargeItem;
				}
				set	
				{
					chargeItem = value;
				}
			}

			public long? Max95Bps
			{
				get
				{
					return max95Bps;
				}
				set	
				{
					max95Bps = value;
				}
			}

			public string Max95BpsTime
			{
				get
				{
					return max95BpsTime;
				}
				set	
				{
					max95BpsTime = value;
				}
			}

			public float? EffectiveFactor
			{
				get
				{
					return effectiveFactor;
				}
				set	
				{
					effectiveFactor = value;
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

			public float? Proportion
			{
				get
				{
					return proportion;
				}
				set	
				{
					proportion = value;
				}
			}

			public string DownloadUrl
			{
				get
				{
					return downloadUrl;
				}
				set	
				{
					downloadUrl = value;
				}
			}
		}
	}
}