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
using Aliyun.Acs.nlp_automl.Transform;
using Aliyun.Acs.nlp_automl.Transform.V20190701;

namespace Aliyun.Acs.nlp_automl.Model.V20190701
{
    public class AddMtIntervenePackageRequest : RpcAcsRequest<AddMtIntervenePackageResponse>
    {
        public AddMtIntervenePackageRequest()
            : base("nlp-automl", "2019-07-01", "AddMtIntervenePackage", "nlpautoml", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceLanguage;

		private string packageName;

		private string sourceType;

		private string targetLanguage;

		private int? projectId;

		public string SourceLanguage
		{
			get
			{
				return sourceLanguage;
			}
			set	
			{
				sourceLanguage = value;
				DictionaryUtil.Add(QueryParameters, "SourceLanguage", value);
			}
		}

		public string PackageName
		{
			get
			{
				return packageName;
			}
			set	
			{
				packageName = value;
				DictionaryUtil.Add(QueryParameters, "PackageName", value);
			}
		}

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public string TargetLanguage
		{
			get
			{
				return targetLanguage;
			}
			set	
			{
				targetLanguage = value;
				DictionaryUtil.Add(QueryParameters, "TargetLanguage", value);
			}
		}

		public int? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value.ToString());
			}
		}

        public override AddMtIntervenePackageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddMtIntervenePackageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
