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

namespace Aliyun.Acs.quickbi_public.Model.V20200806
{
	public class QueryDatasetListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryDatasetList_Result result;

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

		public QueryDatasetList_Result Result
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

		public class QueryDatasetList_Result
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalNum;

			private int? totalPages;

			private List<QueryDatasetList_DataItem> data;

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
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

			public int? TotalNum
			{
				get
				{
					return totalNum;
				}
				set	
				{
					totalNum = value;
				}
			}

			public int? TotalPages
			{
				get
				{
					return totalPages;
				}
				set	
				{
					totalPages = value;
				}
			}

			public List<QueryDatasetList_DataItem> Data
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

			public class QueryDatasetList_DataItem
			{

				private string datasetId;

				private string datasetName;

				private string description;

				private string createTime;

				private string modifyTime;

				private string ownerId;

				private string ownerName;

				private bool? rowLevel;

				private string workspaceId;

				private string workspaceName;

				private QueryDatasetList_DataSource dataSource;

				private QueryDatasetList_Directory directory;

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

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public string ModifyTime
				{
					get
					{
						return modifyTime;
					}
					set	
					{
						modifyTime = value;
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

				public QueryDatasetList_DataSource DataSource
				{
					get
					{
						return dataSource;
					}
					set	
					{
						dataSource = value;
					}
				}

				public QueryDatasetList_Directory Directory
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

				public class QueryDatasetList_DataSource
				{

					private string dsId;

					private string dsName;

					private string dsType;

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
				}

				public class QueryDatasetList_Directory
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
}
