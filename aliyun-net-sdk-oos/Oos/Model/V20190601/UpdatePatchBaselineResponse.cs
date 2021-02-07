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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class UpdatePatchBaselineResponse : AcsResponse
	{

		private string requestId;

		private UpdatePatchBaseline_PatchBaseline patchBaseline;

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

		public UpdatePatchBaseline_PatchBaseline PatchBaseline
		{
			get
			{
				return patchBaseline;
			}
			set	
			{
				patchBaseline = value;
			}
		}

		public class UpdatePatchBaseline_PatchBaseline
		{

			private string id;

			private string name;

			private string createdDate;

			private string createdBy;

			private string updatedDate;

			private string updatedBy;

			private string description;

			private string shareType;

			private string operationSystem;

			private string approvalRules;

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

			public string CreatedDate
			{
				get
				{
					return createdDate;
				}
				set	
				{
					createdDate = value;
				}
			}

			public string CreatedBy
			{
				get
				{
					return createdBy;
				}
				set	
				{
					createdBy = value;
				}
			}

			public string UpdatedDate
			{
				get
				{
					return updatedDate;
				}
				set	
				{
					updatedDate = value;
				}
			}

			public string UpdatedBy
			{
				get
				{
					return updatedBy;
				}
				set	
				{
					updatedBy = value;
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

			public string ShareType
			{
				get
				{
					return shareType;
				}
				set	
				{
					shareType = value;
				}
			}

			public string OperationSystem
			{
				get
				{
					return operationSystem;
				}
				set	
				{
					operationSystem = value;
				}
			}

			public string ApprovalRules
			{
				get
				{
					return approvalRules;
				}
				set	
				{
					approvalRules = value;
				}
			}
		}
	}
}
