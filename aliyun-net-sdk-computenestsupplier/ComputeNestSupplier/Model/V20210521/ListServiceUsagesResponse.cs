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

namespace Aliyun.Acs.ComputeNestSupplier.Model.V20210521
{
	public class ListServiceUsagesResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private int? totalCount;

		private List<ListServiceUsages_Policy> serviceUsages;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
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

		public List<ListServiceUsages_Policy> ServiceUsages
		{
			get
			{
				return serviceUsages;
			}
			set	
			{
				serviceUsages = value;
			}
		}

		public class ListServiceUsages_Policy
		{

			private long? userAliUid;

			private string serviceId;

			private string serviceName;

			private string supplierName;

			private string status;

			private string comments;

			private string createTime;

			private string updateTime;

			private ListServiceUsages_UserInformation userInformation;

			public long? UserAliUid
			{
				get
				{
					return userAliUid;
				}
				set	
				{
					userAliUid = value;
				}
			}

			public string ServiceId
			{
				get
				{
					return serviceId;
				}
				set	
				{
					serviceId = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string SupplierName
			{
				get
				{
					return supplierName;
				}
				set	
				{
					supplierName = value;
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

			public string Comments
			{
				get
				{
					return comments;
				}
				set	
				{
					comments = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public ListServiceUsages_UserInformation UserInformation
			{
				get
				{
					return userInformation;
				}
				set	
				{
					userInformation = value;
				}
			}

			public class ListServiceUsages_UserInformation
			{

				private string name;

				private string emailAddress;

				private string company;

				private string country;

				private string telephone;

				private string title;

				private string industry;

				private string source;

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

				public string EmailAddress
				{
					get
					{
						return emailAddress;
					}
					set	
					{
						emailAddress = value;
					}
				}

				public string Company
				{
					get
					{
						return company;
					}
					set	
					{
						company = value;
					}
				}

				public string Country
				{
					get
					{
						return country;
					}
					set	
					{
						country = value;
					}
				}

				public string Telephone
				{
					get
					{
						return telephone;
					}
					set	
					{
						telephone = value;
					}
				}

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

				public string Industry
				{
					get
					{
						return industry;
					}
					set	
					{
						industry = value;
					}
				}

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}
			}
		}
	}
}
