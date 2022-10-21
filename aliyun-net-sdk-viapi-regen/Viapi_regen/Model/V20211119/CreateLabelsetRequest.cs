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
using Aliyun.Acs.viapi_regen.Transform;
using Aliyun.Acs.viapi_regen.Transform.V20211119;

namespace Aliyun.Acs.viapi_regen.Model.V20211119
{
    public class CreateLabelsetRequest : RpcAcsRequest<CreateLabelsetResponse>
    {
        public CreateLabelsetRequest()
            : base("viapi-regen", "2021-11-19", "CreateLabelset", "selflearning", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.viapi_regen.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.viapi_regen.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private string type;

		private long? preLabelId;

		private string tagUserList;

		private string userOssUrl;

		private string objectKey;

		private string name;

		private long? datasetId;

		private string tagSettings;

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

		public long? PreLabelId
		{
			get
			{
				return preLabelId;
			}
			set	
			{
				preLabelId = value;
				DictionaryUtil.Add(BodyParameters, "PreLabelId", value.ToString());
			}
		}

		public string TagUserList
		{
			get
			{
				return tagUserList;
			}
			set	
			{
				tagUserList = value;
				DictionaryUtil.Add(BodyParameters, "TagUserList", value);
			}
		}

		public string UserOssUrl
		{
			get
			{
				return userOssUrl;
			}
			set	
			{
				userOssUrl = value;
				DictionaryUtil.Add(BodyParameters, "UserOssUrl", value);
			}
		}

		public string ObjectKey
		{
			get
			{
				return objectKey;
			}
			set	
			{
				objectKey = value;
				DictionaryUtil.Add(BodyParameters, "ObjectKey", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public long? DatasetId
		{
			get
			{
				return datasetId;
			}
			set	
			{
				datasetId = value;
				DictionaryUtil.Add(BodyParameters, "DatasetId", value.ToString());
			}
		}

		public string TagSettings
		{
			get
			{
				return tagSettings;
			}
			set	
			{
				tagSettings = value;
				DictionaryUtil.Add(BodyParameters, "TagSettings", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateLabelsetResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLabelsetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
