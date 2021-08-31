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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class InsertSwimmingLaneGroupResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private InsertSwimmingLaneGroup_Data data;

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

		public InsertSwimmingLaneGroup_Data Data
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

		public class InsertSwimmingLaneGroup_Data
		{

			private long? id;

			private string name;

			private string namespaceId;

			private List<InsertSwimmingLaneGroup_Application> applicationList;

			private InsertSwimmingLaneGroup_EntryApplication entryApplication;

			public long? Id
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

			public string NamespaceId
			{
				get
				{
					return namespaceId;
				}
				set	
				{
					namespaceId = value;
				}
			}

			public List<InsertSwimmingLaneGroup_Application> ApplicationList
			{
				get
				{
					return applicationList;
				}
				set	
				{
					applicationList = value;
				}
			}

			public InsertSwimmingLaneGroup_EntryApplication EntryApplication
			{
				get
				{
					return entryApplication;
				}
				set	
				{
					entryApplication = value;
				}
			}

			public class InsertSwimmingLaneGroup_Application
			{

				private string appName;

				private string appId;

				public string AppName
				{
					get
					{
						return appName;
					}
					set	
					{
						appName = value;
					}
				}

				public string AppId
				{
					get
					{
						return appId;
					}
					set	
					{
						appId = value;
					}
				}
			}

			public class InsertSwimmingLaneGroup_EntryApplication
			{

				private string appName;

				private string appId;

				public string AppName
				{
					get
					{
						return appName;
					}
					set	
					{
						appName = value;
					}
				}

				public string AppId
				{
					get
					{
						return appId;
					}
					set	
					{
						appId = value;
					}
				}
			}
		}
	}
}
