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

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
	public class CreatesSlotTemplateResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private string requestId;

		private CreatesSlotTemplate_Model model;

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

		public CreatesSlotTemplate_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class CreatesSlotTemplate_Model
		{

			private long? createTime;

			private long? modifyTime;

			private string tenantId;

			private string adSlotTemplateId;

			private string adSlotTemplateName;

			private string adSlotTemplateTitle;

			private string adSlotTemplatePic;

			private string adSlotTemplatePreview;

			private string adSlotTemplateDescription;

			private string adSlotType;

			private string templateConfig;

			private string extInfo;

			private long? version;

			public long? CreateTime
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

			public long? ModifyTime
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

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string AdSlotTemplateId
			{
				get
				{
					return adSlotTemplateId;
				}
				set	
				{
					adSlotTemplateId = value;
				}
			}

			public string AdSlotTemplateName
			{
				get
				{
					return adSlotTemplateName;
				}
				set	
				{
					adSlotTemplateName = value;
				}
			}

			public string AdSlotTemplateTitle
			{
				get
				{
					return adSlotTemplateTitle;
				}
				set	
				{
					adSlotTemplateTitle = value;
				}
			}

			public string AdSlotTemplatePic
			{
				get
				{
					return adSlotTemplatePic;
				}
				set	
				{
					adSlotTemplatePic = value;
				}
			}

			public string AdSlotTemplatePreview
			{
				get
				{
					return adSlotTemplatePreview;
				}
				set	
				{
					adSlotTemplatePreview = value;
				}
			}

			public string AdSlotTemplateDescription
			{
				get
				{
					return adSlotTemplateDescription;
				}
				set	
				{
					adSlotTemplateDescription = value;
				}
			}

			public string AdSlotType
			{
				get
				{
					return adSlotType;
				}
				set	
				{
					adSlotType = value;
				}
			}

			public string TemplateConfig
			{
				get
				{
					return templateConfig;
				}
				set	
				{
					templateConfig = value;
				}
			}

			public string ExtInfo
			{
				get
				{
					return extInfo;
				}
				set	
				{
					extInfo = value;
				}
			}

			public long? Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}
		}
	}
}
