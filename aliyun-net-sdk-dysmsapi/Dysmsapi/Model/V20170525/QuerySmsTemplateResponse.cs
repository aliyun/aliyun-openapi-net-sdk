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

namespace Aliyun.Acs.Dysmsapi.Model.V20170525
{
	public class QuerySmsTemplateResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private int? templateStatus;

		private string reason;

		private string templateCode;

		private int? templateType;

		private string templateName;

		private string templateContent;

		private string createDate;

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

		public int? TemplateStatus
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

		public string Reason
		{
			get
			{
				return reason;
			}
			set	
			{
				reason = value;
			}
		}

		public string TemplateCode
		{
			get
			{
				return templateCode;
			}
			set	
			{
				templateCode = value;
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

		public string TemplateContent
		{
			get
			{
				return templateContent;
			}
			set	
			{
				templateContent = value;
			}
		}

		public string CreateDate
		{
			get
			{
				return createDate;
			}
			set	
			{
				createDate = value;
			}
		}
	}
}
