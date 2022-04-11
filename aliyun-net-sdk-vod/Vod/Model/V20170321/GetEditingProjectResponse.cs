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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetEditingProjectResponse : AcsResponse
	{

		private string requestId;

		private GetEditingProject_Project project;

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

		public GetEditingProject_Project Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
			}
		}

		public class GetEditingProject_Project
		{

			private string storageLocation;

			private string status;

			private string creationTime;

			private string modifiedTime;

			private string fEExtend;

			private string description;

			private string coverURL;

			private string projectId;

			private string timeline;

			private string title;

			private string regionId;

			public string StorageLocation
			{
				get
				{
					return storageLocation;
				}
				set	
				{
					storageLocation = value;
				}
			}

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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
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

			public string FEExtend
			{
				get
				{
					return fEExtend;
				}
				set	
				{
					fEExtend = value;
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

			public string CoverURL
			{
				get
				{
					return coverURL;
				}
				set	
				{
					coverURL = value;
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

			public string Timeline
			{
				get
				{
					return timeline;
				}
				set	
				{
					timeline = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}
		}
	}
}
