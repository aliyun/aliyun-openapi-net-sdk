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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListColumnsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private List<ListColumns_Column> columnList;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public List<ListColumns_Column> ColumnList
		{
			get
			{
				return columnList;
			}
			set	
			{
				columnList = value;
			}
		}

		public class ListColumns_Column
		{

			private string columnId;

			private string columnName;

			private string columnType;

			private bool? nullable;

			private string defaultValue;

			private bool? autoIncrement;

			private string description;

			private string securityLevel;

			private string functionType;

			private long? dataLength;

			private bool? sensitive;

			private int? dataPrecision;

			private int? dataScale;

			public string ColumnId
			{
				get
				{
					return columnId;
				}
				set	
				{
					columnId = value;
				}
			}

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

			public bool? Nullable
			{
				get
				{
					return nullable;
				}
				set	
				{
					nullable = value;
				}
			}

			public string DefaultValue
			{
				get
				{
					return defaultValue;
				}
				set	
				{
					defaultValue = value;
				}
			}

			public bool? AutoIncrement
			{
				get
				{
					return autoIncrement;
				}
				set	
				{
					autoIncrement = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string SecurityLevel
			{
				get
				{
					return securityLevel;
				}
				set	
				{
					securityLevel = value;
				}
			}

			public string FunctionType
			{
				get
				{
					return functionType;
				}
				set	
				{
					functionType = value;
				}
			}

			public long? DataLength
			{
				get
				{
					return dataLength;
				}
				set	
				{
					dataLength = value;
				}
			}

			public bool? Sensitive
			{
				get
				{
					return sensitive;
				}
				set	
				{
					sensitive = value;
				}
			}

			public int? DataPrecision
			{
				get
				{
					return dataPrecision;
				}
				set	
				{
					dataPrecision = value;
				}
			}

			public int? DataScale
			{
				get
				{
					return dataScale;
				}
				set	
				{
					dataScale = value;
				}
			}
		}
	}
}
