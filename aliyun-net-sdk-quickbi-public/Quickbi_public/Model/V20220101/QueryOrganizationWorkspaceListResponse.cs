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
	public class QueryOrganizationWorkspaceListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryOrganizationWorkspaceList_Result result;

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

		public QueryOrganizationWorkspaceList_Result Result
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

		public class QueryOrganizationWorkspaceList_Result
		{

			private int? totalNum;

			private int? pageNum;

			private int? pageSize;

			private int? totalPages;

			private List<QueryOrganizationWorkspaceList_DataItem> data;

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

			public List<QueryOrganizationWorkspaceList_DataItem> Data
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

			public class QueryOrganizationWorkspaceList_DataItem
			{

				private string workspaceDescription;

				private string realOwnerAccountName;

				private string owner;

				private string modifyUser;

				private string createTime;

				private string ownerAccountName;

				private string workspaceId;

				private string createUser;

				private string organizationId;

				private string modifyUserAccountName;

				private string modifiedTime;

				private bool? allowShareOperation;

				private string workspaceName;

				private bool? allowPublishOperation;

				private string createUserAccountName;

				private QueryOrganizationWorkspaceList_WorkspaceExportConfig workspaceExportConfig;

				public string WorkspaceDescription
				{
					get
					{
						return workspaceDescription;
					}
					set	
					{
						workspaceDescription = value;
					}
				}

				public string RealOwnerAccountName
				{
					get
					{
						return realOwnerAccountName;
					}
					set	
					{
						realOwnerAccountName = value;
					}
				}

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public string ModifyUser
				{
					get
					{
						return modifyUser;
					}
					set	
					{
						modifyUser = value;
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

				public string OwnerAccountName
				{
					get
					{
						return ownerAccountName;
					}
					set	
					{
						ownerAccountName = value;
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

				public string CreateUser
				{
					get
					{
						return createUser;
					}
					set	
					{
						createUser = value;
					}
				}

				public string OrganizationId
				{
					get
					{
						return organizationId;
					}
					set	
					{
						organizationId = value;
					}
				}

				public string ModifyUserAccountName
				{
					get
					{
						return modifyUserAccountName;
					}
					set	
					{
						modifyUserAccountName = value;
					}
				}

				public string ModifiedTime
				{
					get
					{
						return modifiedTime;
					}
					set	
					{
						modifiedTime = value;
					}
				}

				public bool? AllowShareOperation
				{
					get
					{
						return allowShareOperation;
					}
					set	
					{
						allowShareOperation = value;
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

				public bool? AllowPublishOperation
				{
					get
					{
						return allowPublishOperation;
					}
					set	
					{
						allowPublishOperation = value;
					}
				}

				public string CreateUserAccountName
				{
					get
					{
						return createUserAccountName;
					}
					set	
					{
						createUserAccountName = value;
					}
				}

				public QueryOrganizationWorkspaceList_WorkspaceExportConfig WorkspaceExportConfig
				{
					get
					{
						return workspaceExportConfig;
					}
					set	
					{
						workspaceExportConfig = value;
					}
				}

				public class QueryOrganizationWorkspaceList_WorkspaceExportConfig
				{

					private bool? defaultExportType;

					private bool? pdfExport;

					private bool? imageExport;

					private bool? exportToServer;

					private bool? exportToLocal;

					private bool? exportMainSwitch;

					private bool? allowExcelImageFile;

					private bool? dataExport;

					private bool? exportToPublicWork;

					public bool? DefaultExportType
					{
						get
						{
							return defaultExportType;
						}
						set	
						{
							defaultExportType = value;
						}
					}

					public bool? PdfExport
					{
						get
						{
							return pdfExport;
						}
						set	
						{
							pdfExport = value;
						}
					}

					public bool? ImageExport
					{
						get
						{
							return imageExport;
						}
						set	
						{
							imageExport = value;
						}
					}

					public bool? ExportToServer
					{
						get
						{
							return exportToServer;
						}
						set	
						{
							exportToServer = value;
						}
					}

					public bool? ExportToLocal
					{
						get
						{
							return exportToLocal;
						}
						set	
						{
							exportToLocal = value;
						}
					}

					public bool? ExportMainSwitch
					{
						get
						{
							return exportMainSwitch;
						}
						set	
						{
							exportMainSwitch = value;
						}
					}

					public bool? AllowExcelImageFile
					{
						get
						{
							return allowExcelImageFile;
						}
						set	
						{
							allowExcelImageFile = value;
						}
					}

					public bool? DataExport
					{
						get
						{
							return dataExport;
						}
						set	
						{
							dataExport = value;
						}
					}

					public bool? ExportToPublicWork
					{
						get
						{
							return exportToPublicWork;
						}
						set	
						{
							exportToPublicWork = value;
						}
					}
				}
			}
		}
	}
}
