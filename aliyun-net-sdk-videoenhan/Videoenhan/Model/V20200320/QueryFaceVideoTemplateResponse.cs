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

namespace Aliyun.Acs.videoenhan.Model.V20200320
{
	public class QueryFaceVideoTemplateResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private QueryFaceVideoTemplate_Data data;

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

		public QueryFaceVideoTemplate_Data Data
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

		public class QueryFaceVideoTemplate_Data
		{

			private List<QueryFaceVideoTemplate_ElementsItem> elements;

			public List<QueryFaceVideoTemplate_ElementsItem> Elements
			{
				get
				{
					return elements;
				}
				set	
				{
					elements = value;
				}
			}

			public class QueryFaceVideoTemplate_ElementsItem
			{

				private string templateURL;

				private string userId;

				private string createTime;

				private string updateTime;

				private string templateId;

				public string TemplateURL
				{
					get
					{
						return templateURL;
					}
					set	
					{
						templateURL = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
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
			}
		}
	}
}
