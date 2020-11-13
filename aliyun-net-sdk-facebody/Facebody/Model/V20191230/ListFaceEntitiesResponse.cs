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

namespace Aliyun.Acs.facebody.Model.V20191230
{
	public class ListFaceEntitiesResponse : AcsResponse
	{

		private string requestId;

		private ListFaceEntities_Data data;

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

		public ListFaceEntities_Data Data
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

		public class ListFaceEntities_Data
		{

			private string token;

			private int? totalCount;

			private List<ListFaceEntities_Entity> entities;

			public string Token
			{
				get
				{
					return token;
				}
				set	
				{
					token = value;
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

			public List<ListFaceEntities_Entity> Entities
			{
				get
				{
					return entities;
				}
				set	
				{
					entities = value;
				}
			}

			public class ListFaceEntities_Entity
			{

				private string dbName;

				private string entityId;

				private int? faceCount;

				private string labels;

				private long? createdAt;

				private long? updatedAt;

				public string DbName
				{
					get
					{
						return dbName;
					}
					set	
					{
						dbName = value;
					}
				}

				public string EntityId
				{
					get
					{
						return entityId;
					}
					set	
					{
						entityId = value;
					}
				}

				public int? FaceCount
				{
					get
					{
						return faceCount;
					}
					set	
					{
						faceCount = value;
					}
				}

				public string Labels
				{
					get
					{
						return labels;
					}
					set	
					{
						labels = value;
					}
				}

				public long? CreatedAt
				{
					get
					{
						return createdAt;
					}
					set	
					{
						createdAt = value;
					}
				}

				public long? UpdatedAt
				{
					get
					{
						return updatedAt;
					}
					set	
					{
						updatedAt = value;
					}
				}
			}
		}
	}
}
