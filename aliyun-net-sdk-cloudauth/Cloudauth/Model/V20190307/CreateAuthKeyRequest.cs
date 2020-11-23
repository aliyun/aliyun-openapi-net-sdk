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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20190307;

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
    public class CreateAuthKeyRequest : RpcAcsRequest<CreateAuthKeyResponse>
    {
        public CreateAuthKeyRequest()
            : base("Cloudauth", "2019-03-07", "CreateAuthKey", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string userDeviceId;

		private bool? test;

		private string bizType;

		private int? authYears;

		public string UserDeviceId
		{
			get
			{
				return userDeviceId;
			}
			set	
			{
				userDeviceId = value;
				DictionaryUtil.Add(QueryParameters, "UserDeviceId", value);
			}
		}

		public bool? Test
		{
			get
			{
				return test;
			}
			set	
			{
				test = value;
				DictionaryUtil.Add(QueryParameters, "Test", value.ToString());
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public int? AuthYears
		{
			get
			{
				return authYears;
			}
			set	
			{
				authYears = value;
				DictionaryUtil.Add(QueryParameters, "AuthYears", value.ToString());
			}
		}

        public override CreateAuthKeyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAuthKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
