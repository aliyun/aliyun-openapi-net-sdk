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
	public class DescribeCdnDomainLogsResponse : AcsResponse
	{

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private DescribeCdnDomainLogs_DomainLogModel domainLogModel;

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

		public DescribeCdnDomainLogs_DomainLogModel DomainLogModel
		{
			get
			{
				return domainLogModel;
			}
			set	
			{
				domainLogModel = value;
			}
		}

		public class DescribeCdnDomainLogs_DomainLogModel
		{

			private string domainName;

			private List<DescribeCdnDomainLogs_DomainLogDetail> domainLogDetails;

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

			public List<DescribeCdnDomainLogs_DomainLogDetail> DomainLogDetails
			{
				get
				{
					return domainLogDetails;
				}
				set	
				{
					domainLogDetails = value;
				}
			}

			public class DescribeCdnDomainLogs_DomainLogDetail
			{

				private string logName;

				private string logPath;

				private long? logSize;

				private string startTime;

				private string endTime;

				public string LogName
				{
					get
					{
						return logName;
					}
					set	
					{
						logName = value;
					}
				}

				public string LogPath
				{
					get
					{
						return logPath;
					}
					set	
					{
						logPath = value;
					}
				}

				public long? LogSize
				{
					get
					{
						return logSize;
					}
					set	
					{
						logSize = value;
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
			}
		}
	}
}