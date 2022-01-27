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
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20190910;

namespace Aliyun.Acs.ROS.Model.V20190910
{
    public class SetTemplatePermissionRequest : RpcAcsRequest<SetTemplatePermissionResponse>
    {
        public SetTemplatePermissionRequest()
            : base("ROS", "2019-09-10", "SetTemplatePermission", "ros", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string templateVersion;

		private string templateId;

		private string versionOption;

		private string shareOption;

		private List<string> accountIdss = new List<string>(){ };

		public string TemplateVersion
		{
			get
			{
				return templateVersion;
			}
			set	
			{
				templateVersion = value;
				DictionaryUtil.Add(QueryParameters, "TemplateVersion", value);
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

		public string VersionOption
		{
			get
			{
				return versionOption;
			}
			set	
			{
				versionOption = value;
				DictionaryUtil.Add(QueryParameters, "VersionOption", value);
			}
		}

		public string ShareOption
		{
			get
			{
				return shareOption;
			}
			set	
			{
				shareOption = value;
				DictionaryUtil.Add(QueryParameters, "ShareOption", value);
			}
		}

		public List<string> AccountIdss
		{
			get
			{
				return accountIdss;
			}

			set
			{
				accountIdss = value;
				for (int i = 0; i < accountIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AccountIds." + (i + 1) , accountIdss[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetTemplatePermissionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetTemplatePermissionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
