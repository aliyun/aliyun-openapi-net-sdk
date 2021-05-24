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

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribeJobDiffStatusResponse : AcsResponse
	{

		private string dynamicCode;

		private string dynamicMessage;

		private string errCode;

		private string errMessage;

		private int? httpStatusCode;

		private string requestId;

		private bool? success;

		private long? total;

		private List<DescribeJobDiffStatus_DiffInfosItem> diffInfos;

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

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

		public List<DescribeJobDiffStatus_DiffInfosItem> DiffInfos
		{
			get
			{
				return diffInfos;
			}
			set	
			{
				diffInfos = value;
			}
		}

		public class DescribeJobDiffStatus_DiffInfosItem
		{

			private string scheduleJobId;

			private string dbName;

			private string tableName;

			private string pkName;

			private string pkValue;

			private string diff;

			public string ScheduleJobId
			{
				get
				{
					return scheduleJobId;
				}
				set	
				{
					scheduleJobId = value;
				}
			}

			public string DbName
			{
				get
				{
					return dbName;
				}
				set	
				{
					dbName = value;
				}
			}

			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
				}
			}

			public string PkName
			{
				get
				{
					return pkName;
				}
				set	
				{
					pkName = value;
				}
			}

			public string PkValue
			{
				get
				{
					return pkValue;
				}
				set	
				{
					pkValue = value;
				}
			}

			public string Diff
			{
				get
				{
					return diff;
				}
				set	
				{
					diff = value;
				}
			}
		}
	}
}
