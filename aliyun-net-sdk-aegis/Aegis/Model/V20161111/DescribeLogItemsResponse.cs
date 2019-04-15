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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeLogItemsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? crackTotalCount;

		private int? setPageSize;

		private int? processOffset;

		private int? networkOffset;

		private int? portSnapshotOffset;

		private int? processSnapshotTotalCount;

		private int? crackOffset;

		private int? networkTotalCount;

		private int? portSnapshotTotalCount;

		private int? processSnapshotOffset;

		private int? processTotalCount;

		private int? loginTotalCount;

		private int? currentPage;

		private int? accountSnapshotOffset;

		private int? accountSnapshotTotalCount;

		private List<DescribeLogItems_LogsListItem> logsList;

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

		public int? CrackTotalCount
		{
			get
			{
				return crackTotalCount;
			}
			set	
			{
				crackTotalCount = value;
			}
		}

		public int? SetPageSize
		{
			get
			{
				return setPageSize;
			}
			set	
			{
				setPageSize = value;
			}
		}

		public int? ProcessOffset
		{
			get
			{
				return processOffset;
			}
			set	
			{
				processOffset = value;
			}
		}

		public int? NetworkOffset
		{
			get
			{
				return networkOffset;
			}
			set	
			{
				networkOffset = value;
			}
		}

		public int? PortSnapshotOffset
		{
			get
			{
				return portSnapshotOffset;
			}
			set	
			{
				portSnapshotOffset = value;
			}
		}

		public int? ProcessSnapshotTotalCount
		{
			get
			{
				return processSnapshotTotalCount;
			}
			set	
			{
				processSnapshotTotalCount = value;
			}
		}

		public int? CrackOffset
		{
			get
			{
				return crackOffset;
			}
			set	
			{
				crackOffset = value;
			}
		}

		public int? NetworkTotalCount
		{
			get
			{
				return networkTotalCount;
			}
			set	
			{
				networkTotalCount = value;
			}
		}

		public int? PortSnapshotTotalCount
		{
			get
			{
				return portSnapshotTotalCount;
			}
			set	
			{
				portSnapshotTotalCount = value;
			}
		}

		public int? ProcessSnapshotOffset
		{
			get
			{
				return processSnapshotOffset;
			}
			set	
			{
				processSnapshotOffset = value;
			}
		}

		public int? ProcessTotalCount
		{
			get
			{
				return processTotalCount;
			}
			set	
			{
				processTotalCount = value;
			}
		}

		public int? LoginTotalCount
		{
			get
			{
				return loginTotalCount;
			}
			set	
			{
				loginTotalCount = value;
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public int? AccountSnapshotOffset
		{
			get
			{
				return accountSnapshotOffset;
			}
			set	
			{
				accountSnapshotOffset = value;
			}
		}

		public int? AccountSnapshotTotalCount
		{
			get
			{
				return accountSnapshotTotalCount;
			}
			set	
			{
				accountSnapshotTotalCount = value;
			}
		}

		public List<DescribeLogItems_LogsListItem> LogsList
		{
			get
			{
				return logsList;
			}
			set	
			{
				logsList = value;
			}
		}

		public class DescribeLogItems_LogsListItem
		{

			private string mLogTime;

			private string logSourceId;

			private string logSource;

			private List<DescribeLogItems_MContentsItem> mContents;

			public string MLogTime
			{
				get
				{
					return mLogTime;
				}
				set	
				{
					mLogTime = value;
				}
			}

			public string LogSourceId
			{
				get
				{
					return logSourceId;
				}
				set	
				{
					logSourceId = value;
				}
			}

			public string LogSource
			{
				get
				{
					return logSource;
				}
				set	
				{
					logSource = value;
				}
			}

			public List<DescribeLogItems_MContentsItem> MContents
			{
				get
				{
					return mContents;
				}
				set	
				{
					mContents = value;
				}
			}

			public class DescribeLogItems_MContentsItem
			{

				private string mKey;

				private string mValue;

				public string MKey
				{
					get
					{
						return mKey;
					}
					set	
					{
						mKey = value;
					}
				}

				public string MValue
				{
					get
					{
						return mValue;
					}
					set	
					{
						mValue = value;
					}
				}
			}
		}
	}
}
