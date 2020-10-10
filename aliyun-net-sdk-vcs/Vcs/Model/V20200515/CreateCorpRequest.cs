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
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class CreateCorpRequest : RpcAcsRequest<CreateCorpResponse>
    {
        public CreateCorpRequest()
            : base("Vcs", "2020-05-15", "CreateCorp")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string algorithmType;

		private string isvSubId;

		private string parentCorpId;

		private string description;

		private string iconPath;

		private string appName;

		private string corpName;

		public string AlgorithmType
		{
			get
			{
				return algorithmType;
			}
			set	
			{
				algorithmType = value;
				DictionaryUtil.Add(BodyParameters, "AlgorithmType", value);
			}
		}

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

        public override CreateCorpResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCorpResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
