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

namespace Aliyun.Acs.quickbi_public.Model.V20200809
{
	public class ListCollectionsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<ListCollections_Data> result;

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

		public List<ListCollections_Data> Result
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

		public class ListCollections_Data
		{

			private int? favoriteId;

			private string ownerId;

			private string worksId;

			private string worksName;

			private string worksType;

			private string workspaceId;

			private string workspaceName;

			public int? FavoriteId
			{
				get
				{
					return favoriteId;
				}
				set	
				{
					favoriteId = value;
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

			public string WorksId
			{
				get
				{
					return worksId;
				}
				set	
				{
					worksId = value;
				}
			}

			public string WorksName
			{
				get
				{
					return worksName;
				}
				set	
				{
					worksName = value;
				}
			}

			public string WorksType
			{
				get
				{
					return worksType;
				}
				set	
				{
					worksType = value;
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
		}
	}
}
