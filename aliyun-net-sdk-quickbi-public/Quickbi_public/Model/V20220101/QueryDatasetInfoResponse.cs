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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryDatasetInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryDatasetInfo_Result result;

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

		public QueryDatasetInfo_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryDatasetInfo_Result
		{

			private bool? custimzeSql;

			private string datasetId;

			private string datasetName;

			private string dsId;

			private string dsName;

			private string dsType;

			private string gmtCreate;

			private string gmtModify;

			private bool? openOfflineAcceleration;

			private string ownerId;

			private string ownerName;

			private bool? rowLevel;

			private string workspaceId;

			private string workspaceName;

			private List<QueryDatasetInfo_CubeTableListItem> cubeTableList;

			private List<QueryDatasetInfo_DimensionListItem> dimensionList;

			private List<QueryDatasetInfo_MeasureListItem> measureList;

			private QueryDatasetInfo_Directory directory;

			public bool? CustimzeSql
			{
				get
				{
					return custimzeSql;
				}
				set	
				{
					custimzeSql = value;
				}
			}

			public string DatasetId
			{
				get
				{
					return datasetId;
				}
				set	
				{
					datasetId = value;
				}
			}

			public string DatasetName
			{
				get
				{
					return datasetName;
				}
				set	
				{
					datasetName = value;
				}
			}

			public string DsId
			{
				get
				{
					return dsId;
				}
				set	
				{
					dsId = value;
				}
			}

			public string DsName
			{
				get
				{
					return dsName;
				}
				set	
				{
					dsName = value;
				}
			}

			public string DsType
			{
				get
				{
					return dsType;
				}
				set	
				{
					dsType = value;
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

			public string GmtModify
			{
				get
				{
					return gmtModify;
				}
				set	
				{
					gmtModify = value;
				}
			}

			public bool? OpenOfflineAcceleration
			{
				get
				{
					return openOfflineAcceleration;
				}
				set	
				{
					openOfflineAcceleration = value;
				}
			}

			public string OwnerId
			{
				get
				{
					return ownerId;
				}
				set	
				{
					ownerId = value;
				}
			}

			public string OwnerName
			{
				get
				{
					return ownerName;
				}
				set	
				{
					ownerName = value;
				}
			}

			public bool? RowLevel
			{
				get
				{
					return rowLevel;
				}
				set	
				{
					rowLevel = value;
				}
			}

			public string WorkspaceId
			{
				get
				{
					return workspaceId;
				}
				set	
				{
					workspaceId = value;
				}
			}

			public string WorkspaceName
			{
				get
				{
					return workspaceName;
				}
				set	
				{
					workspaceName = value;
				}
			}

			public List<QueryDatasetInfo_CubeTableListItem> CubeTableList
			{
				get
				{
					return cubeTableList;
				}
				set	
				{
					cubeTableList = value;
				}
			}

			public List<QueryDatasetInfo_DimensionListItem> DimensionList
			{
				get
				{
					return dimensionList;
				}
				set	
				{
					dimensionList = value;
				}
			}

			public List<QueryDatasetInfo_MeasureListItem> MeasureList
			{
				get
				{
					return measureList;
				}
				set	
				{
					measureList = value;
				}
			}

			public QueryDatasetInfo_Directory Directory
			{
				get
				{
					return directory;
				}
				set	
				{
					directory = value;
				}
			}

			public class QueryDatasetInfo_CubeTableListItem
			{

				private string caption;

				private bool? customsql;

				private string datasourceId;

				private string dsType;

				private bool? factTable;

				private string sql;

				private string tableName;

				private string uniqueId;

				public string Caption
				{
					get
					{
						return caption;
					}
					set	
					{
						caption = value;
					}
				}

				public bool? Customsql
				{
					get
					{
						return customsql;
					}
					set	
					{
						customsql = value;
					}
				}

				public string DatasourceId
				{
					get
					{
						return datasourceId;
					}
					set	
					{
						datasourceId = value;
					}
				}

				public string DsType
				{
					get
					{
						return dsType;
					}
					set	
					{
						dsType = value;
					}
				}

				public bool? FactTable
				{
					get
					{
						return factTable;
					}
					set	
					{
						factTable = value;
					}
				}

				public string Sql
				{
					get
					{
						return sql;
					}
					set	
					{
						sql = value;
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

				public string UniqueId
				{
					get
					{
						return uniqueId;
					}
					set	
					{
						uniqueId = value;
					}
				}
			}

			public class QueryDatasetInfo_DimensionListItem
			{

				private string caption;

				private string dataType;

				private string dimensionType;

				private string expression;

				private string factColumn;

				private string fieldDescription;

				private string granularity;

				private string refUid;

				private string tableUniqueId;

				private string uid;

				private string expressionV2;

				public string Caption
				{
					get
					{
						return caption;
					}
					set	
					{
						caption = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

				public string DimensionType
				{
					get
					{
						return dimensionType;
					}
					set	
					{
						dimensionType = value;
					}
				}

				public string Expression
				{
					get
					{
						return expression;
					}
					set	
					{
						expression = value;
					}
				}

				public string FactColumn
				{
					get
					{
						return factColumn;
					}
					set	
					{
						factColumn = value;
					}
				}

				public string FieldDescription
				{
					get
					{
						return fieldDescription;
					}
					set	
					{
						fieldDescription = value;
					}
				}

				public string Granularity
				{
					get
					{
						return granularity;
					}
					set	
					{
						granularity = value;
					}
				}

				public string RefUid
				{
					get
					{
						return refUid;
					}
					set	
					{
						refUid = value;
					}
				}

				public string TableUniqueId
				{
					get
					{
						return tableUniqueId;
					}
					set	
					{
						tableUniqueId = value;
					}
				}

				public string Uid
				{
					get
					{
						return uid;
					}
					set	
					{
						uid = value;
					}
				}

				public string ExpressionV2
				{
					get
					{
						return expressionV2;
					}
					set	
					{
						expressionV2 = value;
					}
				}
			}

			public class QueryDatasetInfo_MeasureListItem
			{

				private string caption;

				private string dataType;

				private string expression;

				private string factColumn;

				private string fieldDescription;

				private string measureType;

				private string tableUniqueId;

				private string uid;

				private string expressionV2;

				public string Caption
				{
					get
					{
						return caption;
					}
					set	
					{
						caption = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

				public string Expression
				{
					get
					{
						return expression;
					}
					set	
					{
						expression = value;
					}
				}

				public string FactColumn
				{
					get
					{
						return factColumn;
					}
					set	
					{
						factColumn = value;
					}
				}

				public string FieldDescription
				{
					get
					{
						return fieldDescription;
					}
					set	
					{
						fieldDescription = value;
					}
				}

				public string MeasureType
				{
					get
					{
						return measureType;
					}
					set	
					{
						measureType = value;
					}
				}

				public string TableUniqueId
				{
					get
					{
						return tableUniqueId;
					}
					set	
					{
						tableUniqueId = value;
					}
				}

				public string Uid
				{
					get
					{
						return uid;
					}
					set	
					{
						uid = value;
					}
				}

				public string ExpressionV2
				{
					get
					{
						return expressionV2;
					}
					set	
					{
						expressionV2 = value;
					}
				}
			}

			public class QueryDatasetInfo_Directory
			{

				private string id;

				private string name;

				private string pathId;

				private string pathName;

				public string Id
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

				public string PathId
				{
					get
					{
						return pathId;
					}
					set	
					{
						pathId = value;
					}
				}

				public string PathName
				{
					get
					{
						return pathName;
					}
					set	
					{
						pathName = value;
					}
				}
			}
		}
	}
}
