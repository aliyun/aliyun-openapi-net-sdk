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
	public class DescTemplateResponse : AcsResponse
	{

		private string requestId;

		private string templateName;

		private string templateSubject;

		private string templateNickName;

		private string templateStatus;

		private string templateType;

		private string createTime;

		private string templateText;

		private string smsContent;

		private string smsType;

		private string remark;

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

		public string TemplateSubject
		{
			get
			{
				return templateSubject;
			}
			set	
			{
				templateSubject = value;
			}
		}

		public string TemplateNickName
		{
			get
			{
				return templateNickName;
			}
			set	
			{
				templateNickName = value;
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

		public string TemplateType
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

		public string TemplateText
		{
			get
			{
				return templateText;
			}
			set	
			{
				templateText = value;
			}
		}

		public string SmsContent
		{
			get
			{
				return smsContent;
			}
			set	
			{
				smsContent = value;
			}
		}

		public string SmsType
		{
			get
			{
				return smsType;
			}
			set	
			{
				smsType = value;
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
			}
		}
	}
}
