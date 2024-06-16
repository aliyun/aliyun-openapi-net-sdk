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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeInstanceLinkedWhitelistTemplateResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private DescribeInstanceLinkedWhitelistTemplate_Data data;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "HttpStatusCode")]
		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public DescribeInstanceLinkedWhitelistTemplate_Data Data
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

		public class DescribeInstanceLinkedWhitelistTemplate_Data
		{

			private string insName;

			private List<DescribeInstanceLinkedWhitelistTemplate_Template> templates;

			[JsonProperty(PropertyName = "InsName")]
			public string InsName
			{
				get
				{
					return insName;
				}
				set	
				{
					insName = value;
				}
			}

			[JsonProperty(PropertyName = "Templates")]
			public List<DescribeInstanceLinkedWhitelistTemplate_Template> Templates
			{
				get
				{
					return templates;
				}
				set	
				{
					templates = value;
				}
			}

			public class DescribeInstanceLinkedWhitelistTemplate_Template
			{

				private int? id;

				private int? userId;

				private int? templateId;

				private string templateName;

				private string ips;

				[JsonProperty(PropertyName = "Id")]
				public int? Id
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

				[JsonProperty(PropertyName = "UserId")]
				public int? UserId
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

				[JsonProperty(PropertyName = "TemplateId")]
				public int? TemplateId
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

				[JsonProperty(PropertyName = "TemplateName")]
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

				[JsonProperty(PropertyName = "Ips")]
				public string Ips
				{
					get
					{
						return ips;
					}
					set	
					{
						ips = value;
					}
				}
			}
		}
	}
}
