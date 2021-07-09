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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetDevopsProjectInfoResponse : AcsResponse
	{

		private string errorMsg;

		private string requestId;

		private bool? successful;

		private string errorCode;

		private GetDevopsProjectInfo__Object _object;

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

			private string sortMethod;

			private string uniqueIdPrefix;

			private string normalType;

			private string modifierId;

			private string sourceType;

			private bool? isTemplate;

			private string description;

			private string defaultRoleId;

			private string rootCollectionId;

			private bool? isDeleted;

			private string updated;

			private string name;

			private bool? isArchived;

			private string endDate;

			private string logo;

			private string startDate;

			private string pinyin;

			private string creatorId;

			private string sourceId;

			private string defaultCollectionId;

			private bool? isSuspended;

			private string organizationId;

			private string visibility;

			private string py;

			private string category;

			private int? nextTaskUniqueId;

			private string customfields;

			private string created;

			private string id;

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
		}
	}
}
