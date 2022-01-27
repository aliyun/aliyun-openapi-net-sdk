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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class DescribeWhitelistSettingResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? currentPage;

		private int? pageSize;

		private List<DescribeWhitelistSetting_Item> items;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeWhitelistSetting_Item> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeWhitelistSetting_Item
		{

			private long? id;

			private long? sceneId;

			private string validStartDate;

			private string validEndDate;

			private string certNo;

			private string certifyId;

			private string status;

			private string gmtCreate;

			private string gmtModified;

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

			public long? SceneId
			{
				get
				{
					return sceneId;
				}
				set	
				{
					sceneId = value;
				}
			}

			public string ValidStartDate
			{
				get
				{
					return validStartDate;
				}
				set	
				{
					validStartDate = value;
				}
			}

			public string ValidEndDate
			{
				get
				{
					return validEndDate;
				}
				set	
				{
					validEndDate = value;
				}
			}

			public string CertNo
			{
				get
				{
					return certNo;
				}
				set	
				{
					certNo = value;
				}
			}

			public string CertifyId
			{
				get
				{
					return certifyId;
				}
				set	
				{
					certifyId = value;
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

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}
		}
	}
}
