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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class DescribeAdbMySqlColumnsResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private bool? success;

		private string schema;

		private string tableName;

		private int? columnCount;

		private List<DescribeAdbMySqlColumns_Column> columns;

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

		public string Schema
		{
			get
			{
				return schema;
			}
			set	
			{
				schema = value;
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

		public int? ColumnCount
		{
			get
			{
				return columnCount;
			}
			set	
			{
				columnCount = value;
			}
		}

		public List<DescribeAdbMySqlColumns_Column> Columns
		{
			get
			{
				return columns;
			}
			set	
			{
				columns = value;
			}
		}

		public class DescribeAdbMySqlColumns_Column
		{

			private string type;

			private string name;

			private string comment;

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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}
		}
	}
}
