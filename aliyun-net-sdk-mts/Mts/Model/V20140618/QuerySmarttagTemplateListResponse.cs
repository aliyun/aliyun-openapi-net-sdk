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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QuerySmarttagTemplateListResponse : AcsResponse
	{

		private string requestId;

		private List<QuerySmarttagTemplateList_Template> templates;

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

		public List<QuerySmarttagTemplateList_Template> Templates
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

		public class QuerySmarttagTemplateList_Template
		{

			private string analyseTypes;

			private string industry;

			private bool? isDefault;

			private string templateName;

			private string templateId;

			private string faceCategoryIds;

			private string faceCustomParamsConfig;

			private string objectGroupIds;

			private string landmarkGroupIds;

			private string scene;

			private string labelType;

			private string labelVersion;

			private string knowledgeConfig;

			private string keywordConfig;

			public string AnalyseTypes
			{
				get
				{
					return analyseTypes;
				}
				set	
				{
					analyseTypes = value;
				}
			}

			public string Industry
			{
				get
				{
					return industry;
				}
				set	
				{
					industry = value;
				}
			}

			public bool? IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
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

			public string FaceCategoryIds
			{
				get
				{
					return faceCategoryIds;
				}
				set	
				{
					faceCategoryIds = value;
				}
			}

			public string FaceCustomParamsConfig
			{
				get
				{
					return faceCustomParamsConfig;
				}
				set	
				{
					faceCustomParamsConfig = value;
				}
			}

			public string ObjectGroupIds
			{
				get
				{
					return objectGroupIds;
				}
				set	
				{
					objectGroupIds = value;
				}
			}

			public string LandmarkGroupIds
			{
				get
				{
					return landmarkGroupIds;
				}
				set	
				{
					landmarkGroupIds = value;
				}
			}

			public string Scene
			{
				get
				{
					return scene;
				}
				set	
				{
					scene = value;
				}
			}

			public string LabelType
			{
				get
				{
					return labelType;
				}
				set	
				{
					labelType = value;
				}
			}

			public string LabelVersion
			{
				get
				{
					return labelVersion;
				}
				set	
				{
					labelVersion = value;
				}
			}

			public string KnowledgeConfig
			{
				get
				{
					return knowledgeConfig;
				}
				set	
				{
					knowledgeConfig = value;
				}
			}

			public string KeywordConfig
			{
				get
				{
					return keywordConfig;
				}
				set	
				{
					keywordConfig = value;
				}
			}
		}
	}
}
