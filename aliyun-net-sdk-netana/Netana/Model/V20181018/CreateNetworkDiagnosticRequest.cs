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
using Aliyun.Acs.Netana.Transform;
using Aliyun.Acs.Netana.Transform.V20181018;

namespace Aliyun.Acs.Netana.Model.V20181018
{
    public class CreateNetworkDiagnosticRequest : RpcAcsRequest<CreateNetworkDiagnosticResponse>
    {
        public CreateNetworkDiagnosticRequest()
            : base("Netana", "2018-10-18", "CreateNetworkDiagnostic", "Netana", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string requestParams;

		private string userRequestId;

		private string type;

		private string requestApiName;

		private string productType;

		private string errorCode;

		private string resourceOwnerAccount;

		private string instanceId;

		private string responseParams;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string RequestParams
		{
			get
			{
				return requestParams;
			}
			set	
			{
				requestParams = value;
				DictionaryUtil.Add(QueryParameters, "RequestParams", value);
			}
		}

		public string UserRequestId
		{
			get
			{
				return userRequestId;
			}
			set	
			{
				userRequestId = value;
				DictionaryUtil.Add(QueryParameters, "UserRequestId", value);
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
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string RequestApiName
		{
			get
			{
				return requestApiName;
			}
			set	
			{
				requestApiName = value;
				DictionaryUtil.Add(QueryParameters, "RequestApiName", value);
			}
		}

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
				DictionaryUtil.Add(QueryParameters, "ErrorCode", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string ResponseParams
		{
			get
			{
				return responseParams;
			}
			set	
			{
				responseParams = value;
				DictionaryUtil.Add(QueryParameters, "ResponseParams", value);
			}
		}

        public override CreateNetworkDiagnosticResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateNetworkDiagnosticResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
