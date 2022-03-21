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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListFilesResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string errorMessage;

		private string requestId;

		private string errorCode;

		private bool? success;

		private ListFiles_Data data;

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

		public ListFiles_Data Data
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

		public class ListFiles_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListFiles_File> files;

			public int? PageNumber
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

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<ListFiles_File> Files
			{
				get
				{
					return files;
				}
				set	
				{
					files = value;
				}
			}

			public class ListFiles_File
			{

				private int? commitStatus;

				private bool? autoParsing;

				private string owner;

				private long? createTime;

				private int? fileType;

				private int? currentVersion;

				private long? bizId;

				private string lastEditUser;

				private string fileName;

				private string connectionName;

				private string useType;

				private string fileFolderId;

				private long? fileId;

				private long? parentId;

				private string createUser;

				private bool? isMaxCompute;

				private long? businessId;

				private string fileDescription;

				private long? lastEditTime;

				private string content;

				private long? nodeId;

				public int? CommitStatus
				{
					get
					{
						return commitStatus;
					}
					set	
					{
						commitStatus = value;
					}
				}

				public bool? AutoParsing
				{
					get
					{
						return autoParsing;
					}
					set	
					{
						autoParsing = value;
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

				public long? CreateTime
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

				public int? FileType
				{
					get
					{
						return fileType;
					}
					set	
					{
						fileType = value;
					}
				}

				public int? CurrentVersion
				{
					get
					{
						return currentVersion;
					}
					set	
					{
						currentVersion = value;
					}
				}

				public long? BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
					}
				}

				public string LastEditUser
				{
					get
					{
						return lastEditUser;
					}
					set	
					{
						lastEditUser = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}

				public string ConnectionName
				{
					get
					{
						return connectionName;
					}
					set	
					{
						connectionName = value;
					}
				}

				public string UseType
				{
					get
					{
						return useType;
					}
					set	
					{
						useType = value;
					}
				}

				public string FileFolderId
				{
					get
					{
						return fileFolderId;
					}
					set	
					{
						fileFolderId = value;
					}
				}

				public long? FileId
				{
					get
					{
						return fileId;
					}
					set	
					{
						fileId = value;
					}
				}

				public long? ParentId
				{
					get
					{
						return parentId;
					}
					set	
					{
						parentId = value;
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

				public bool? IsMaxCompute
				{
					get
					{
						return isMaxCompute;
					}
					set	
					{
						isMaxCompute = value;
					}
				}

				public long? BusinessId
				{
					get
					{
						return businessId;
					}
					set	
					{
						businessId = value;
					}
				}

				public string FileDescription
				{
					get
					{
						return fileDescription;
					}
					set	
					{
						fileDescription = value;
					}
				}

				public long? LastEditTime
				{
					get
					{
						return lastEditTime;
					}
					set	
					{
						lastEditTime = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public long? NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}
			}
		}
	}
}
