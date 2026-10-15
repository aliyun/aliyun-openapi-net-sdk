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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class ListAuthConfigByResourceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<ListAuthConfigByResource_Data> result;

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

		public List<ListAuthConfigByResource_Data> Result
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

		public class ListAuthConfigByResource_Data
		{

			private string gmtCreate;

			private int? scope;

			private string expireDate;

			private string resourceId;

			private string authorizedId;

			private string authorizedName;

			private string resourceType;

			private List<string> authorities;

			public string GmtCreate
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

			public int? Scope
			{
				get
				{
					return scope;
				}
				set	
				{
					scope = value;
				}
			}

			public string ExpireDate
			{
				get
				{
					return expireDate;
				}
				set	
				{
					expireDate = value;
				}
			}

			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			public string AuthorizedId
			{
				get
				{
					return authorizedId;
				}
				set	
				{
					authorizedId = value;
				}
			}

			public string AuthorizedName
			{
				get
				{
					return authorizedName;
				}
				set	
				{
					authorizedName = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public List<string> Authorities
			{
				get
				{
					return authorities;
				}
				set	
				{
					authorities = value;
				}
			}
		}
	}
}
