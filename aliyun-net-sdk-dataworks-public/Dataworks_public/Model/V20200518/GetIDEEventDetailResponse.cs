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
	public class GetIDEEventDetailResponse : AcsResponse
	{

		private string requestId;

		private GetIDEEventDetail_EventDetail eventDetail;

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

		public GetIDEEventDetail_EventDetail EventDetail
		{
			get
			{
				return eventDetail;
			}
			set	
			{
				eventDetail = value;
			}
		}

		public class GetIDEEventDetail_EventDetail
		{

			private GetIDEEventDetail_FileExecutionCommand fileExecutionCommand;

			private GetIDEEventDetail_DeletedFile deletedFile;

			private GetIDEEventDetail_CommittedFile committedFile;

			private GetIDEEventDetail_TableModel tableModel;

			public GetIDEEventDetail_FileExecutionCommand FileExecutionCommand
			{
				get
				{
					return fileExecutionCommand;
				}
				set	
				{
					fileExecutionCommand = value;
				}
			}

			public GetIDEEventDetail_DeletedFile DeletedFile
			{
				get
				{
					return deletedFile;
				}
				set	
				{
					deletedFile = value;
				}
			}

			public GetIDEEventDetail_CommittedFile CommittedFile
			{
				get
				{
					return committedFile;
				}
				set	
				{
					committedFile = value;
				}
			}

			public GetIDEEventDetail_TableModel TableModel
			{
				get
				{
					return tableModel;
				}
				set	
				{
					tableModel = value;
				}
			}

			public class GetIDEEventDetail_FileExecutionCommand
			{

				private long? fileId;

				private string dataSourceName;

				private string content;

				private long? fileType;

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

				public string DataSourceName
				{
					get
					{
						return dataSourceName;
					}
					set	
					{
						dataSourceName = value;
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

				public long? FileType
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
			}

			public class GetIDEEventDetail_DeletedFile
			{

				private string owner;

				private long? fileType;

				private long? currentVersion;

				private long? businessId;

				private string fileName;

				private string dataSourceName;

				private string useType;

				private string folderId;

				private long? parentFileId;

				private string content;

				private long? nodeId;

				private long? fileId;

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

				public long? FileType
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

				public long? CurrentVersion
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

				public string DataSourceName
				{
					get
					{
						return dataSourceName;
					}
					set	
					{
						dataSourceName = value;
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

				public string FolderId
				{
					get
					{
						return folderId;
					}
					set	
					{
						folderId = value;
					}
				}

				public long? ParentFileId
				{
					get
					{
						return parentFileId;
					}
					set	
					{
						parentFileId = value;
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
			}

			public class GetIDEEventDetail_CommittedFile
			{

				private long? fileId;

				private string content;

				private string committor;

				private long? fileType;

				private string changeType;

				private string fileName;

				private long? nodeId;

				private string comment;

				private string useType;

				private GetIDEEventDetail_FilePropertyContent filePropertyContent;

				private GetIDEEventDetail_NodeConfiguration nodeConfiguration;

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

				public string Committor
				{
					get
					{
						return committor;
					}
					set	
					{
						committor = value;
					}
				}

				public long? FileType
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

				public string ChangeType
				{
					get
					{
						return changeType;
					}
					set	
					{
						changeType = value;
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

				public GetIDEEventDetail_FilePropertyContent FilePropertyContent
				{
					get
					{
						return filePropertyContent;
					}
					set	
					{
						filePropertyContent = value;
					}
				}

				public GetIDEEventDetail_NodeConfiguration NodeConfiguration
				{
					get
					{
						return nodeConfiguration;
					}
					set	
					{
						nodeConfiguration = value;
					}
				}

				public class GetIDEEventDetail_FilePropertyContent
				{

					private string dataSourceName;

					private long? parentFileId;

					private long? businessId;

					private long? currentVersion;

					private string owner;

					private string folderId;

					public string DataSourceName
					{
						get
						{
							return dataSourceName;
						}
						set	
						{
							dataSourceName = value;
						}
					}

					public long? ParentFileId
					{
						get
						{
							return parentFileId;
						}
						set	
						{
							parentFileId = value;
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

					public long? CurrentVersion
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

					public string FolderId
					{
						get
						{
							return folderId;
						}
						set	
						{
							folderId = value;
						}
					}
				}

				public class GetIDEEventDetail_NodeConfiguration
				{

					private string rerunMode;

					private string schedulerType;

					private string paraValue;

					private string cycleType;

					private string dependentNodeIdList;

					private long? resourceGroupId;

					private long? autoRerunTimes;

					private long? autoRerunIntervalMillis;

					private string cronExpress;

					private string dependentType;

					private List<GetIDEEventDetail_Input> inputList;

					private List<GetIDEEventDetail_Output> outputList;

					public string RerunMode
					{
						get
						{
							return rerunMode;
						}
						set	
						{
							rerunMode = value;
						}
					}

					public string SchedulerType
					{
						get
						{
							return schedulerType;
						}
						set	
						{
							schedulerType = value;
						}
					}

					public string ParaValue
					{
						get
						{
							return paraValue;
						}
						set	
						{
							paraValue = value;
						}
					}

					public string CycleType
					{
						get
						{
							return cycleType;
						}
						set	
						{
							cycleType = value;
						}
					}

					public string DependentNodeIdList
					{
						get
						{
							return dependentNodeIdList;
						}
						set	
						{
							dependentNodeIdList = value;
						}
					}

					public long? ResourceGroupId
					{
						get
						{
							return resourceGroupId;
						}
						set	
						{
							resourceGroupId = value;
						}
					}

					public long? AutoRerunTimes
					{
						get
						{
							return autoRerunTimes;
						}
						set	
						{
							autoRerunTimes = value;
						}
					}

					public long? AutoRerunIntervalMillis
					{
						get
						{
							return autoRerunIntervalMillis;
						}
						set	
						{
							autoRerunIntervalMillis = value;
						}
					}

					public string CronExpress
					{
						get
						{
							return cronExpress;
						}
						set	
						{
							cronExpress = value;
						}
					}

					public string DependentType
					{
						get
						{
							return dependentType;
						}
						set	
						{
							dependentType = value;
						}
					}

					public List<GetIDEEventDetail_Input> InputList
					{
						get
						{
							return inputList;
						}
						set	
						{
							inputList = value;
						}
					}

					public List<GetIDEEventDetail_Output> OutputList
					{
						get
						{
							return outputList;
						}
						set	
						{
							outputList = value;
						}
					}

					public class GetIDEEventDetail_Input
					{

						private string input;

						private string parseType;

						public string Input
						{
							get
							{
								return input;
							}
							set	
							{
								input = value;
							}
						}

						public string ParseType
						{
							get
							{
								return parseType;
							}
							set	
							{
								parseType = value;
							}
						}
					}

					public class GetIDEEventDetail_Output
					{

						private string refTableName;

						private string output;

						public string RefTableName
						{
							get
							{
								return refTableName;
							}
							set	
							{
								refTableName = value;
							}
						}

						public string Output
						{
							get
							{
								return output;
							}
							set	
							{
								output = value;
							}
						}
					}
				}
			}

			public class GetIDEEventDetail_TableModel
			{

				private string env;

				private long? lifeCycle;

				private string tableName;

				private string dataSourceName;

				private string comment;

				private string location;

				private List<GetIDEEventDetail_Column> columns;

				public string Env
				{
					get
					{
						return env;
					}
					set	
					{
						env = value;
					}
				}

				public long? LifeCycle
				{
					get
					{
						return lifeCycle;
					}
					set	
					{
						lifeCycle = value;
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

				public string DataSourceName
				{
					get
					{
						return dataSourceName;
					}
					set	
					{
						dataSourceName = value;
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

				public string Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public List<GetIDEEventDetail_Column> Columns
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

				public class GetIDEEventDetail_Column
				{

					private string columnName;

					private string columnType;

					private bool? isPartitionColumn;

					private string comment;

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

					public bool? IsPartitionColumn
					{
						get
						{
							return isPartitionColumn;
						}
						set	
						{
							isPartitionColumn = value;
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
	}
}
