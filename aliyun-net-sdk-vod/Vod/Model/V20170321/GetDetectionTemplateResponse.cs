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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetDetectionTemplateResponse : AcsResponse
	{

		private string requestId;

		private GetDetectionTemplate_DetectionTemplate detectionTemplate;

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

		public GetDetectionTemplate_DetectionTemplate DetectionTemplate
		{
			get
			{
				return detectionTemplate;
			}
			set	
			{
				detectionTemplate = value;
			}
		}

		public class GetDetectionTemplate_DetectionTemplate
		{

			private string createTime;

			private long? userId;

			private string templateName;

			private string period;

			private string platform;

			private string templateId;

			private string modifyTime;

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

			public long? UserId
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

			public string Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
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

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}
		}
	}
}
