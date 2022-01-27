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

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class ListRemediationTemplatesResponse : AcsResponse
	{

		private string requestId;

		private List<ListRemediationTemplates_RemediationTemplate> remediationTemplates;

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

		public List<ListRemediationTemplates_RemediationTemplate> RemediationTemplates
		{
			get
			{
				return remediationTemplates;
			}
			set	
			{
				remediationTemplates = value;
			}
		}

		public class ListRemediationTemplates_RemediationTemplate
		{

			private string compulsoryParameters;

			private string remediationType;

			private string templateIdentifier;

			private string templateName;

			private string templateDefinition;

			public string CompulsoryParameters
			{
				get
				{
					return compulsoryParameters;
				}
				set	
				{
					compulsoryParameters = value;
				}
			}

			public string RemediationType
			{
				get
				{
					return remediationType;
				}
				set	
				{
					remediationType = value;
				}
			}

			public string TemplateIdentifier
			{
				get
				{
					return templateIdentifier;
				}
				set	
				{
					templateIdentifier = value;
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

			public string TemplateDefinition
			{
				get
				{
					return templateDefinition;
				}
				set	
				{
					templateDefinition = value;
				}
			}
		}
	}
}
