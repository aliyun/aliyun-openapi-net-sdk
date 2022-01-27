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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetMetaTableDetailInfoResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetMetaTableDetailInfo_DetailInfo detailInfo;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "DetailInfo")]
		public GetMetaTableDetailInfo_DetailInfo DetailInfo
		{
			get
			{
				return detailInfo;
			}
			set	
			{
				detailInfo = value;
			}
		}

		public class GetMetaTableDetailInfo_DetailInfo
		{

			private List<GetMetaTableDetailInfo_Index> indexList;

			private List<GetMetaTableDetailInfo_Column> columnList;

			[JsonProperty(PropertyName = "IndexList")]
			public List<GetMetaTableDetailInfo_Index> IndexList
			{
				get
				{
					return indexList;
				}
				set	
				{
					indexList = value;
				}
			}

			[JsonProperty(PropertyName = "ColumnList")]
			public List<GetMetaTableDetailInfo_Column> ColumnList
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

			public class GetMetaTableDetailInfo_Index
			{

				private string indexName;

				private bool? unique;

				private string indexType;

				private string indexId;

				private List<string> indexColumns;

				[JsonProperty(PropertyName = "IndexName")]
				public string IndexName
				{
					get
					{
						return indexName;
					}
					set	
					{
						indexName = value;
					}
				}

				[JsonProperty(PropertyName = "Unique")]
				public bool? Unique
				{
					get
					{
						return unique;
					}
					set	
					{
						unique = value;
					}
				}

				[JsonProperty(PropertyName = "IndexType")]
				public string IndexType
				{
					get
					{
						return indexType;
					}
					set	
					{
						indexType = value;
					}
				}

				[JsonProperty(PropertyName = "IndexId")]
				public string IndexId
				{
					get
					{
						return indexId;
					}
					set	
					{
						indexId = value;
					}
				}

				[JsonProperty(PropertyName = "IndexColumns")]
				public List<string> IndexColumns
				{
					get
					{
						return indexColumns;
					}
					set	
					{
						indexColumns = value;
					}
				}
			}

			public class GetMetaTableDetailInfo_Column
			{

				private string columnName;

				private string description;

				private int? dataScale;

				private int? dataPrecision;

				private string columnType;

				private bool? autoIncrement;

				private string position;

				private bool? nullable;

				private string columnId;

				private long? dataLength;

				[JsonProperty(PropertyName = "ColumnName")]
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

				[JsonProperty(PropertyName = "Description")]
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

				[JsonProperty(PropertyName = "DataScale")]
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

				[JsonProperty(PropertyName = "DataPrecision")]
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

				[JsonProperty(PropertyName = "ColumnType")]
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

				[JsonProperty(PropertyName = "AutoIncrement")]
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

				[JsonProperty(PropertyName = "Position")]
				public string Position
				{
					get
					{
						return position;
					}
					set	
					{
						position = value;
					}
				}

				[JsonProperty(PropertyName = "Nullable")]
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

				[JsonProperty(PropertyName = "ColumnId")]
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

				[JsonProperty(PropertyName = "DataLength")]
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
			}
		}
	}
}
