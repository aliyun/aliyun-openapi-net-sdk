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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryDomainAdminDivisionResponse : AcsResponse
	{

		private string requestId;

		private List<QueryDomainAdminDivision_AdminDivision> adminDivisions;

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

		public List<QueryDomainAdminDivision_AdminDivision> AdminDivisions
		{
			get
			{
				return adminDivisions;
			}
			set	
			{
				adminDivisions = value;
			}
		}

		public class QueryDomainAdminDivision_AdminDivision
		{

			private string divisionName;

			private List<QueryDomainAdminDivision_ChildrenItem> children;

			public string DivisionName
			{
				get
				{
					return divisionName;
				}
				set	
				{
					divisionName = value;
				}
			}

			public List<QueryDomainAdminDivision_ChildrenItem> Children
			{
				get
				{
					return children;
				}
				set	
				{
					children = value;
				}
			}

			public class QueryDomainAdminDivision_ChildrenItem
			{

				private string childDivisionName;

				public string ChildDivisionName
				{
					get
					{
						return childDivisionName;
					}
					set	
					{
						childDivisionName = value;
					}
				}
			}
		}
	}
}
