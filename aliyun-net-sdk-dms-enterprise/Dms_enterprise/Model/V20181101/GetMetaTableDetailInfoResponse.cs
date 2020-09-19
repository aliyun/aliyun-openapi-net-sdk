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
	public class GetMetaTableDetailInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetMetaTableDetailInfo_DetailInfo detailInfo;

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

			private List<GetMetaTableDetailInfo_Column> columnList;

			private List<GetMetaTableDetailInfo_Index> indexList;

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

			public class GetMetaTableDetailInfo_Column
			{

				private string description;

				private string columnType;

				private string position;

				private int? dataLength;

				private bool? nullable;

				private string columnName;

				private bool? autoIncrement;

				private int? dataPrecision;

				private int? dataScale;

				private string columnId;

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

				public int? DataLength
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
			}

			public class GetMetaTableDetailInfo_Index
			{

				private string indexName;

				private string indexType;

				private bool? unique;

				private string indexId;

				private List<string> indexColumns;

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
		}
	}
}
