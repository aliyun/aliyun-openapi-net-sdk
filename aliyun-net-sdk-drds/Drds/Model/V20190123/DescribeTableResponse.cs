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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeTableResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeTable_Data data;

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

		public DescribeTable_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeTable_Data
		{

			private List<DescribeTable_ColumnInfo> list;

			public List<DescribeTable_ColumnInfo> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class DescribeTable_ColumnInfo
			{

				private string columnName;

				private string columnType;

				private string extra;

				private string index;

				private string isAllowNull;

				private string isPk;

				public string ColumnName
				{
					get
					{
						return columnName;
					}
					set	
					{
						columnName = value;
					}
				}

				public string ColumnType
				{
					get
					{
						return columnType;
					}
					set	
					{
						columnType = value;
					}
				}

				public string Extra
				{
					get
					{
						return extra;
					}
					set	
					{
						extra = value;
					}
				}

				public string Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string IsAllowNull
				{
					get
					{
						return isAllowNull;
					}
					set	
					{
						isAllowNull = value;
					}
				}

				public string IsPk
				{
					get
					{
						return isPk;
					}
					set	
					{
						isPk = value;
					}
				}
			}
		}
	}
}
