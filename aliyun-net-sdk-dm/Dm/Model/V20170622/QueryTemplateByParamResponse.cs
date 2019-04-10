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

namespace Aliyun.Acs.Dm.Model.V20170622
{
	public class QueryTemplateByParamResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<QueryTemplateByParam_Template> data;

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

		public List<QueryTemplateByParam_Template> Data
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

		public class QueryTemplateByParam_Template
		{

			private string templateId;

			private string templateName;

			private string templateComment;

			private string templateStatus;

			private string createTime;

			private long? utcCreatetime;

			private int? templateType;

			private int? smsTemplateCode;

			private int? smsrejectinfo;

			private int? smsStatus;

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

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

			public string TemplateComment
			{
				get
				{
					return templateComment;
				}
				set	
				{
					templateComment = value;
				}
			}

			public string TemplateStatus
			{
				get
				{
					return templateStatus;
				}
				set	
				{
					templateStatus = value;
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

			public long? UtcCreatetime
			{
				get
				{
					return utcCreatetime;
				}
				set	
				{
					utcCreatetime = value;
				}
			}

			public int? TemplateType
			{
				get
				{
					return templateType;
				}
				set	
				{
					templateType = value;
				}
			}

			public int? SmsTemplateCode
			{
				get
				{
					return smsTemplateCode;
				}
				set	
				{
					smsTemplateCode = value;
				}
			}

			public int? Smsrejectinfo
			{
				get
				{
					return smsrejectinfo;
				}
				set	
				{
					smsrejectinfo = value;
				}
			}

			public int? SmsStatus
			{
				get
				{
					return smsStatus;
				}
				set	
				{
					smsStatus = value;
				}
			}
		}
	}
}
