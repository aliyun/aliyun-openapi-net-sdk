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
using Aliyun.Acs.Yundun_ds.Transform;
using Aliyun.Acs.Yundun_ds.Transform.V20190103;

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
    public class ValidateConnectorRequest : RpcAcsRequest<ValidateConnectorResponse>
    {
        public ValidateConnectorRequest()
            : base("Yundun-ds", "2019-01-03", "ValidateConnector", "sddp", "openAPI")
        {
        }

		private string parentId;

		private string password;

		private string lang;

		private string serviceRegionId;

		private int? resourceType;

		private string connector;

		private string userName;

		public string ParentId
		{
			get
			{
				return parentId;
			}
			set	
			{
				parentId = value;
				DictionaryUtil.Add(QueryParameters, "ParentId", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string ServiceRegionId
		{
			get
			{
				return serviceRegionId;
			}
			set	
			{
				serviceRegionId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceRegionId", value);
			}
		}

		public int? ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value.ToString());
			}
		}

		public string Connector
		{
			get
			{
				return connector;
			}
			set	
			{
				connector = value;
				DictionaryUtil.Add(QueryParameters, "Connector", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ValidateConnectorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ValidateConnectorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
