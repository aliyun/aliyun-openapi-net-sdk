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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateModelRequest : RpcAcsRequest<CreateModelResponse>
    {
        public CreateModelRequest()
            : base("CloudAPI", "2016-07-14", "CreateModel", "apigateway", "openAPI")
        {
        }

		private string schema;

		private string securityToken;

		private string modelName;

		private string groupId;

		private string action;

		private string description;

		private string accessKeyId;

		public string Schema
		{
			get
			{
				return schema;
			}
			set	
			{
				schema = value;
				DictionaryUtil.Add(QueryParameters, "Schema", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string ModelName
		{
			get
			{
				return modelName;
			}
			set	
			{
				modelName = value;
				DictionaryUtil.Add(QueryParameters, "ModelName", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override CreateModelResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateModelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}