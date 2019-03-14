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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeClusterOpLogResponse : AcsResponse
	{

		private string requestId;

		private string pageNumber;

		private string pageSize;

		private string total;

		private List<DescribeClusterOpLog_ChangeLog> changeLogList;

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

		public string PageNumber
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

		public string PageSize
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

		public string Total
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

		public List<DescribeClusterOpLog_ChangeLog> ChangeLogList
		{
			get
			{
				return changeLogList;
			}
			set	
			{
				changeLogList = value;
			}
		}

		public class DescribeClusterOpLog_ChangeLog
		{

			private long? id;

			private string gmtCreate;

			private string gmtModified;

			private string targetKey;

			private string status;

			private string changeType;

			private string message;

			private string targetType;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string TargetKey
			{
				get
				{
					return targetKey;
				}
				set	
				{
					targetKey = value;
				}
			}

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

			public string ChangeType
			{
				get
				{
					return changeType;
				}
				set	
				{
					changeType = value;
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

			public string TargetType
			{
				get
				{
					return targetType;
				}
				set	
				{
					targetType = value;
				}
			}
		}
	}
}
