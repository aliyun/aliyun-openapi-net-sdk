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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class CreateTemplateRequest : RpcAcsRequest<CreateTemplateResponse>
    {
        public CreateTemplateRequest()
            : base("oos", "2019-06-01", "CreateTemplate", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string content;

		private Dictionary<object,object> tags;

		private string templateName;

		private string versionName;

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(QueryParameters, "Content", value);
			}
		}

		public Dictionary<object,object> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", JsonConvert.SerializeObject(value));
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

		public string VersionName
		{
			get
			{
				return versionName;
			}
			set	
			{
				versionName = value;
				DictionaryUtil.Add(QueryParameters, "VersionName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
