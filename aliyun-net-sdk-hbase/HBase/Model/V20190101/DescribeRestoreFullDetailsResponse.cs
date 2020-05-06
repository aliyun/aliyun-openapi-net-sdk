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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class DescribeRestoreFullDetailsResponse : AcsResponse
	{

		private string requestId;

		private DescribeRestoreFullDetails_RestoreFull restoreFull;

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

		public DescribeRestoreFullDetails_RestoreFull RestoreFull
		{
			get
			{
				return restoreFull;
			}
			set	
			{
				restoreFull = value;
			}
		}

		public class DescribeRestoreFullDetails_RestoreFull
		{

			private int? succeed;

			private int? fail;

			private string dataSize;

			private string speed;

			private long? total;

			private int? pageNumber;

			private int? pageSize;

			private List<DescribeRestoreFullDetails_RestoreFullDetail> restoreFullDetails;

			public int? Succeed
			{
				get
				{
					return succeed;
				}
				set	
				{
					succeed = value;
				}
			}

			public int? Fail
			{
				get
				{
					return fail;
				}
				set	
				{
					fail = value;
				}
			}

			public string DataSize
			{
				get
				{
					return dataSize;
				}
				set	
				{
					dataSize = value;
				}
			}

			public string Speed
			{
				get
				{
					return speed;
				}
				set	
				{
					speed = value;
				}
			}

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
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

			public List<DescribeRestoreFullDetails_RestoreFullDetail> RestoreFullDetails
			{
				get
				{
					return restoreFullDetails;
				}
				set	
				{
					restoreFullDetails = value;
				}
			}

			public class DescribeRestoreFullDetails_RestoreFullDetail
			{

				private string table;

				private string state;

				private string startTime;

				private string endTime;

				private string process;

				private string dataSize;

				private string speed;

				private string message;

				public string Table
				{
					get
					{
						return table;
					}
					set	
					{
						table = value;
					}
				}

				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
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

				public string Process
				{
					get
					{
						return process;
					}
					set	
					{
						process = value;
					}
				}

				public string DataSize
				{
					get
					{
						return dataSize;
					}
					set	
					{
						dataSize = value;
					}
				}

				public string Speed
				{
					get
					{
						return speed;
					}
					set	
					{
						speed = value;
					}
				}

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
			}
		}
	}
}
