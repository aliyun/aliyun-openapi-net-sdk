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
using Aliyun.Acs.cloudesl;
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class AddCompanyTemplateRequest : RpcAcsRequest<AddCompanyTemplateResponse>
    {
        public AddCompanyTemplateRequest()
            : base("cloudesl", "2020-02-01", "AddCompanyTemplate")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string extraParams;

		private string eslSize;

		private bool? ifPromotion;

		private string deviceType;

		private string scene;

		private string templateVersion;

		private string templateType;

		private string vendor;

		private bool? ifDefault;

		private string templateName;

		private bool? ifSourceCode;

		private bool? ifMember;

		private int? layout;

		private bool? ifOutOfInventory;

		public string ExtraParams
		{
			get
			{
				return extraParams;
			}
			set	
			{
				extraParams = value;
				DictionaryUtil.Add(BodyParameters, "ExtraParams", value);
			}
		}

		public string EslSize
		{
			get
			{
				return eslSize;
			}
			set	
			{
				eslSize = value;
				DictionaryUtil.Add(BodyParameters, "EslSize", value);
			}
		}

		public bool? IfPromotion
		{
			get
			{
				return ifPromotion;
			}
			set	
			{
				ifPromotion = value;
				DictionaryUtil.Add(BodyParameters, "IfPromotion", value.ToString());
			}
		}

		public string DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
				DictionaryUtil.Add(BodyParameters, "DeviceType", value);
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
				DictionaryUtil.Add(BodyParameters, "Scene", value);
			}
		}

		public string TemplateVersion
		{
			get
			{
				return templateVersion;
			}
			set	
			{
				templateVersion = value;
				DictionaryUtil.Add(BodyParameters, "TemplateVersion", value);
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
				DictionaryUtil.Add(BodyParameters, "TemplateType", value);
			}
		}

		public string Vendor
		{
			get
			{
				return vendor;
			}
			set	
			{
				vendor = value;
				DictionaryUtil.Add(BodyParameters, "Vendor", value);
			}
		}

		public bool? IfDefault
		{
			get
			{
				return ifDefault;
			}
			set	
			{
				ifDefault = value;
				DictionaryUtil.Add(BodyParameters, "IfDefault", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "TemplateName", value);
			}
		}

		public bool? IfSourceCode
		{
			get
			{
				return ifSourceCode;
			}
			set	
			{
				ifSourceCode = value;
				DictionaryUtil.Add(BodyParameters, "IfSourceCode", value.ToString());
			}
		}

		public bool? IfMember
		{
			get
			{
				return ifMember;
			}
			set	
			{
				ifMember = value;
				DictionaryUtil.Add(BodyParameters, "IfMember", value.ToString());
			}
		}

		public int? Layout
		{
			get
			{
				return layout;
			}
			set	
			{
				layout = value;
				DictionaryUtil.Add(BodyParameters, "Layout", value.ToString());
			}
		}

		public bool? IfOutOfInventory
		{
			get
			{
				return ifOutOfInventory;
			}
			set	
			{
				ifOutOfInventory = value;
				DictionaryUtil.Add(BodyParameters, "IfOutOfInventory", value.ToString());
			}
		}

        public override AddCompanyTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCompanyTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
