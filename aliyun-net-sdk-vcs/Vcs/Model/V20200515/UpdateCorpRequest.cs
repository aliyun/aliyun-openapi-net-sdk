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
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class UpdateCorpRequest : RpcAcsRequest<UpdateCorpResponse>
    {
        public UpdateCorpRequest()
            : base("Vcs", "2020-05-15", "UpdateCorp")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string isvSubId;

		private string corpId;

		private string parentCorpId;

		private string description;

		private string iconPath;

		private string appName;

		private string corpName;

		public string IsvSubId
		{
			get
			{
				return isvSubId;
			}
			set	
			{
				isvSubId = value;
				DictionaryUtil.Add(BodyParameters, "IsvSubId", value);
			}
		}

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string ParentCorpId
		{
			get
			{
				return parentCorpId;
			}
			set	
			{
				parentCorpId = value;
				DictionaryUtil.Add(BodyParameters, "ParentCorpId", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string IconPath
		{
			get
			{
				return iconPath;
			}
			set	
			{
				iconPath = value;
				DictionaryUtil.Add(BodyParameters, "IconPath", value);
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

		public string CorpName
		{
			get
			{
				return corpName;
			}
			set	
			{
				corpName = value;
				DictionaryUtil.Add(BodyParameters, "CorpName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateCorpResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateCorpResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
