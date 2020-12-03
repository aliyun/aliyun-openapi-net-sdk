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
	public class ListMetaDBResponse : AcsResponse
	{

		private string requestId;

		private ListMetaDB_DatabaseInfo databaseInfo;

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

		public ListMetaDB_DatabaseInfo DatabaseInfo
		{
			get
			{
				return databaseInfo;
			}
			set	
			{
				databaseInfo = value;
			}
		}

		public class ListMetaDB_DatabaseInfo
		{

			private long? totalCount;

			private List<ListMetaDB_DbListItem> dbList;

			public long? TotalCount
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

			public List<ListMetaDB_DbListItem> DbList
			{
				get
				{
					return dbList;
				}
				set	
				{
					dbList = value;
				}
			}

			public class ListMetaDB_DbListItem
			{

				private string name;

				private string type;

				private string ownerId;

				private string location;

				private long? createTimeStamp;

				private long? modifiedTimeStamp;

				private string uUID;

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

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
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

				public long? CreateTimeStamp
				{
					get
					{
						return createTimeStamp;
					}
					set	
					{
						createTimeStamp = value;
					}
				}

				public long? ModifiedTimeStamp
				{
					get
					{
						return modifiedTimeStamp;
					}
					set	
					{
						modifiedTimeStamp = value;
					}
				}

				public string UUID
				{
					get
					{
						return uUID;
					}
					set	
					{
						uUID = value;
					}
				}
			}
		}
	}
}
