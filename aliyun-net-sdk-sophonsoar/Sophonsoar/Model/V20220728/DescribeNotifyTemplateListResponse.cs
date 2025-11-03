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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeNotifyTemplateListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeNotifyTemplateList_DataItem> data;

		private DescribeNotifyTemplateList_Page page;

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

		public List<DescribeNotifyTemplateList_DataItem> Data
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

		public DescribeNotifyTemplateList_Page Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		public class DescribeNotifyTemplateList_DataItem
		{

			private string templateName;

			private string eventId;

			private string subject;

			private string content;

			private string _params;

			public string TemplateName
			{
				get
				{
					return templateName;
				}
				set	
				{
					templateName = value;
				}
			}

			public string EventId
			{
				get
				{
					return eventId;
				}
				set	
				{
					eventId = value;
				}
			}

			public string Subject
			{
				get
				{
					return subject;
				}
				set	
				{
					subject = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}
		}

		public class DescribeNotifyTemplateList_Page
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

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

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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
		}
	}
}
