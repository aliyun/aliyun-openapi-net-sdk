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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class UpdateSmarttagTemplateRequest : RpcAcsRequest<UpdateSmarttagTemplateResponse>
    {
        public UpdateSmarttagTemplateRequest()
            : base("Mts", "2014-06-18", "UpdateSmarttagTemplate", "mts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Mts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Mts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string knowledgeConfig;

		private string industry;

		private string labelVersion;

		private string scene;

		private string templateConfig;

		private string faceCustomParamsConfig;

		private string templateName;

		private bool? isDefault;

		private string faceCategoryIds;

		private string keywordConfig;

		private string landmarkGroupIds;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string objectGroupIds;

		private long? ownerId;

		private string templateId;

		private string analyseTypes;

		private string labelType;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "KnowledgeConfig", value);
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
				DictionaryUtil.Add(QueryParameters, "Industry", value);
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
				DictionaryUtil.Add(QueryParameters, "LabelVersion", value);
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
				DictionaryUtil.Add(QueryParameters, "Scene", value);
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
				DictionaryUtil.Add(QueryParameters, "TemplateConfig", value);
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
				DictionaryUtil.Add(QueryParameters, "FaceCustomParamsConfig", value);
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
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
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
				DictionaryUtil.Add(QueryParameters, "IsDefault", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "FaceCategoryIds", value);
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
				DictionaryUtil.Add(QueryParameters, "KeywordConfig", value);
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
				DictionaryUtil.Add(QueryParameters, "LandmarkGroupIds", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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
				DictionaryUtil.Add(QueryParameters, "ObjectGroupIds", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "TemplateId", value);
			}
		}

		public string AnalyseTypes
		{
			get
			{
				return analyseTypes;
			}
			set	
			{
				analyseTypes = value;
				DictionaryUtil.Add(QueryParameters, "AnalyseTypes", value);
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
				DictionaryUtil.Add(QueryParameters, "LabelType", value);
			}
		}

        public override UpdateSmarttagTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSmarttagTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
