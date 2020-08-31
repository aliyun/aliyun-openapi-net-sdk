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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class GetCatalogListResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<GetCatalogList_DataItem> data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<GetCatalogList_DataItem> Data
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

		public class GetCatalogList_DataItem
		{

			private string isvSubId;

			private long? parentCatalogId;

			private long? profileCount;

			private long? catalogId;

			private string catalogName;

			public string IsvSubId
			{
				get
				{
					return isvSubId;
				}
				set	
				{
					isvSubId = value;
				}
			}

			public long? ParentCatalogId
			{
				get
				{
					return parentCatalogId;
				}
				set	
				{
					parentCatalogId = value;
				}
			}

			public long? ProfileCount
			{
				get
				{
					return profileCount;
				}
				set	
				{
					profileCount = value;
				}
			}

			public long? CatalogId
			{
				get
				{
					return catalogId;
				}
				set	
				{
					catalogId = value;
				}
			}

			public string CatalogName
			{
				get
				{
					return catalogName;
				}
				set	
				{
					catalogName = value;
				}
			}
		}
	}
}
