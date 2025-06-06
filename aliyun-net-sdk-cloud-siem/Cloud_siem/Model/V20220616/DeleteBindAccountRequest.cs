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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class DeleteBindAccountRequest : RpcAcsRequest<DeleteBindAccountResponse>
    {
        public DeleteBindAccountRequest()
            : base("cloud-siem", "2022-06-16", "DeleteBindAccount", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string cloudCode;

		private long? roleFor;

		private string accountId;

		private int? roleType;

		private long? bindId;

		private string accessId;

		public string CloudCode
		{
			get
			{
				return cloudCode;
			}
			set	
			{
				cloudCode = value;
				DictionaryUtil.Add(BodyParameters, "CloudCode", value);
			}
		}

		public long? RoleFor
		{
			get
			{
				return roleFor;
			}
			set	
			{
				roleFor = value;
				DictionaryUtil.Add(BodyParameters, "RoleFor", value.ToString());
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(BodyParameters, "AccountId", value);
			}
		}

		public int? RoleType
		{
			get
			{
				return roleType;
			}
			set	
			{
				roleType = value;
				DictionaryUtil.Add(BodyParameters, "RoleType", value.ToString());
			}
		}

		public long? BindId
		{
			get
			{
				return bindId;
			}
			set	
			{
				bindId = value;
				DictionaryUtil.Add(BodyParameters, "BindId", value.ToString());
			}
		}

		public string AccessId
		{
			get
			{
				return accessId;
			}
			set	
			{
				accessId = value;
				DictionaryUtil.Add(BodyParameters, "AccessId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteBindAccountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteBindAccountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
