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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetDevopsProjectInfoResponse : AcsResponse
	{

		private bool? successful;

		private string errorCode;

		private string errorMsg;

		private string requestId;

		private GetDevopsProjectInfo__Object _object;

		public bool? Successful
		{
			get
			{
				return successful;
			}
			set	
			{
				successful = value;
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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public GetDevopsProjectInfo__Object _Object
		{
			get
			{
				return _object;
			}
			set	
			{
				_object = value;
			}
		}

		public class GetDevopsProjectInfo__Object
		{

			private string rootCollectionId;

			private string endDate;

			private bool? isArchived;

			private string modifierId;

			private string sourceId;

			private string description;

			private string py;

			private string defaultRoleId;

			private string customfields;

			private bool? isDeleted;

			private string uniqueIdPrefix;

			private int? nextTaskUniqueId;

			private string creatorId;

			private string logo;

			private string defaultCollectionId;

			private bool? isSuspended;

			private string visibility;

			private string normalType;

			private string created;

			private string organizationId;

			private string sortMethod;

			private string pinyin;

			private string sourceType;

			private bool? isTemplate;

			private string name;

			private string id;

			private string category;

			private string updated;

			private string startDate;

			public string RootCollectionId
			{
				get
				{
					return rootCollectionId;
				}
				set	
				{
					rootCollectionId = value;
				}
			}

			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			public bool? IsArchived
			{
				get
				{
					return isArchived;
				}
				set	
				{
					isArchived = value;
				}
			}

			public string ModifierId
			{
				get
				{
					return modifierId;
				}
				set	
				{
					modifierId = value;
				}
			}

			public string SourceId
			{
				get
				{
					return sourceId;
				}
				set	
				{
					sourceId = value;
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

			public string Py
			{
				get
				{
					return py;
				}
				set	
				{
					py = value;
				}
			}

			public string DefaultRoleId
			{
				get
				{
					return defaultRoleId;
				}
				set	
				{
					defaultRoleId = value;
				}
			}

			public string Customfields
			{
				get
				{
					return customfields;
				}
				set	
				{
					customfields = value;
				}
			}

			public bool? IsDeleted
			{
				get
				{
					return isDeleted;
				}
				set	
				{
					isDeleted = value;
				}
			}

			public string UniqueIdPrefix
			{
				get
				{
					return uniqueIdPrefix;
				}
				set	
				{
					uniqueIdPrefix = value;
				}
			}

			public int? NextTaskUniqueId
			{
				get
				{
					return nextTaskUniqueId;
				}
				set	
				{
					nextTaskUniqueId = value;
				}
			}

			public string CreatorId
			{
				get
				{
					return creatorId;
				}
				set	
				{
					creatorId = value;
				}
			}

			public string Logo
			{
				get
				{
					return logo;
				}
				set	
				{
					logo = value;
				}
			}

			public string DefaultCollectionId
			{
				get
				{
					return defaultCollectionId;
				}
				set	
				{
					defaultCollectionId = value;
				}
			}

			public bool? IsSuspended
			{
				get
				{
					return isSuspended;
				}
				set	
				{
					isSuspended = value;
				}
			}

			public string Visibility
			{
				get
				{
					return visibility;
				}
				set	
				{
					visibility = value;
				}
			}

			public string NormalType
			{
				get
				{
					return normalType;
				}
				set	
				{
					normalType = value;
				}
			}

			public string Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
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

			public string SortMethod
			{
				get
				{
					return sortMethod;
				}
				set	
				{
					sortMethod = value;
				}
			}

			public string Pinyin
			{
				get
				{
					return pinyin;
				}
				set	
				{
					pinyin = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public bool? IsTemplate
			{
				get
				{
					return isTemplate;
				}
				set	
				{
					isTemplate = value;
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

			public string Id
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

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string Updated
			{
				get
				{
					return updated;
				}
				set	
				{
					updated = value;
				}
			}

			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
				}
			}
		}
	}
}
