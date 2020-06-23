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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveSingleTaskForSaveArtExtensionRequest : RpcAcsRequest<SaveSingleTaskForSaveArtExtensionResponse>
    {
        public SaveSingleTaskForSaveArtExtensionRequest()
            : base("Domain", "2018-01-29", "SaveSingleTaskForSaveArtExtension", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string subject;

		private string title;

		private string dateOrPeriod;

		private string reference;

		private string features;

		private string inscriptionsAndMarkings;

		private string objectType;

		private string lang;

		private string domainName;

		private string maker;

		private string materialsAndTechniques;

		private string dimensions;

		public string Subject
		{
			get
			{
				return subject;
			}
			set	
			{
				subject = value;
				DictionaryUtil.Add(QueryParameters, "Subject", value);
			}
		}

		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public string DateOrPeriod
		{
			get
			{
				return dateOrPeriod;
			}
			set	
			{
				dateOrPeriod = value;
				DictionaryUtil.Add(QueryParameters, "DateOrPeriod", value);
			}
		}

		public string Reference
		{
			get
			{
				return reference;
			}
			set	
			{
				reference = value;
				DictionaryUtil.Add(QueryParameters, "Reference", value);
			}
		}

		public string Features
		{
			get
			{
				return features;
			}
			set	
			{
				features = value;
				DictionaryUtil.Add(QueryParameters, "Features", value);
			}
		}

		public string InscriptionsAndMarkings
		{
			get
			{
				return inscriptionsAndMarkings;
			}
			set	
			{
				inscriptionsAndMarkings = value;
				DictionaryUtil.Add(QueryParameters, "InscriptionsAndMarkings", value);
			}
		}

		public string ObjectType
		{
			get
			{
				return objectType;
			}
			set	
			{
				objectType = value;
				DictionaryUtil.Add(QueryParameters, "ObjectType", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string Maker
		{
			get
			{
				return maker;
			}
			set	
			{
				maker = value;
				DictionaryUtil.Add(QueryParameters, "Maker", value);
			}
		}

		public string MaterialsAndTechniques
		{
			get
			{
				return materialsAndTechniques;
			}
			set	
			{
				materialsAndTechniques = value;
				DictionaryUtil.Add(QueryParameters, "MaterialsAndTechniques", value);
			}
		}

		public string Dimensions
		{
			get
			{
				return dimensions;
			}
			set	
			{
				dimensions = value;
				DictionaryUtil.Add(QueryParameters, "Dimensions", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveSingleTaskForSaveArtExtensionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveSingleTaskForSaveArtExtensionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
