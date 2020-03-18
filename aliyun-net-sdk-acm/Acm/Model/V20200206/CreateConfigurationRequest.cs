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
using Aliyun.Acs.acm.Transform;
using Aliyun.Acs.acm.Transform.V20200206;

namespace Aliyun.Acs.acm.Model.V20200206
{
    public class CreateConfigurationRequest : RoaAcsRequest<CreateConfigurationResponse>
    {
        public CreateConfigurationRequest()
            : base("acm", "2020-02-06", "CreateConfiguration", "acms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/diamond-ops/pop/configuration";
			Method = MethodType.POST;
        }

		private string dataId;

		private string appName;

		private string namespaceId;

		private string type;

		private string content;

		private string group;

		private string desc;

		private string tags;

		public string DataId
		{
			get
			{
				return dataId;
			}
			set	
			{
				dataId = value;
				DictionaryUtil.Add(BodyParameters, "DataId", value);
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(BodyParameters, "AppName", value);
			}
		}

		public string NamespaceId
		{
			get
			{
				return namespaceId;
			}
			set	
			{
				namespaceId = value;
				DictionaryUtil.Add(BodyParameters, "NamespaceId", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(BodyParameters, "Content", value);
			}
		}

		public string Group
		{
			get
			{
				return group;
			}
			set	
			{
				group = value;
				DictionaryUtil.Add(BodyParameters, "Group", value);
			}
		}

		public string Desc
		{
			get
			{
				return desc;
			}
			set	
			{
				desc = value;
				DictionaryUtil.Add(BodyParameters, "Desc", value);
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(BodyParameters, "Tags", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateConfigurationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateConfigurationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
