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

namespace Aliyun.Acs.dataworks_public.Model.V20180601
{
	public class QueryDataImportProcessStatusResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private int? code;

		private QueryDataImportProcessStatus_Data data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public QueryDataImportProcessStatus_Data Data
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

		public class QueryDataImportProcessStatus_Data
		{

			private string status;

			private string message;

			private List<QueryDataImportProcessStatus_ProjectListItem> projectList;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

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

			public List<QueryDataImportProcessStatus_ProjectListItem> ProjectList
			{
				get
				{
					return projectList;
				}
				set	
				{
					projectList = value;
				}
			}

			public class QueryDataImportProcessStatus_ProjectListItem
			{

				private string projectName;

				private string projectId;

				private string projectIdentifier;

				public string ProjectName
				{
					get
					{
						return projectName;
					}
					set	
					{
						projectName = value;
					}
				}

				public string ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public string ProjectIdentifier
				{
					get
					{
						return projectIdentifier;
					}
					set	
					{
						projectIdentifier = value;
					}
				}
			}
		}
	}
}
