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
    public class CreateUserAuthRequest : RpcAcsRequest<CreateUserAuthResponse>
    {
        public CreateUserAuthRequest()
            : base("Yundun-ds", "2019-01-03", "CreateUserAuth", "sddp", "openAPI")
        {
        }

		private string accessKeySecret;

		private long? accountId;

		private string accessKey;

		private string lang;

		public string AccessKeySecret
		{
			get
			{
				return accessKeySecret;
			}
			set	
			{
				accessKeySecret = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeySecret", value);
			}
		}

		public long? AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(QueryParameters, "AccountId", value.ToString());
			}
		}

		public string AccessKey
		{
			get
			{
				return accessKey;
			}
			set	
			{
				accessKey = value;
				DictionaryUtil.Add(QueryParameters, "AccessKey", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateUserAuthResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateUserAuthResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
