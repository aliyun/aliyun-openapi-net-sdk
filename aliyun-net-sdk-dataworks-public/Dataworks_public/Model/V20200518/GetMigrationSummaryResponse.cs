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
	public class GetMigrationSummaryResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetMigrationSummary_Data data;

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

		public GetMigrationSummary_Data Data
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

		public class GetMigrationSummary_Data
		{

			private long? migrationId;

			private string name;

			private long? gmtCreate;

			private long? gmtModified;

			private string createUser;

			private string opUser;

			private string status;

			private long? projectId;

			private string downloadUrl;

			public long? MigrationId
			{
				get
				{
					return migrationId;
				}
				set	
				{
					migrationId = value;
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

			public long? GmtCreate
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

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
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

			public string OpUser
			{
				get
				{
					return opUser;
				}
				set	
				{
					opUser = value;
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

			public long? ProjectId
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

			public string DownloadUrl
			{
				get
				{
					return downloadUrl;
				}
				set	
				{
					downloadUrl = value;
				}
			}
		}
	}
}
