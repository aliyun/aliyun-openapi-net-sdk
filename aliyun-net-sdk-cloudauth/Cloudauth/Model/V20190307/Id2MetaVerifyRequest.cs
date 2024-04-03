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
    public class Id2MetaVerifyRequest : RpcAcsRequest<Id2MetaVerifyResponse>
    {
        public Id2MetaVerifyRequest()
            : base("Cloudauth", "2019-03-07", "Id2MetaVerify", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string paramType;

		private string identifyNum;

		private string userName;

		public string ParamType
		{
			get
			{
				return paramType;
			}
			set	
			{
				paramType = value;
				DictionaryUtil.Add(QueryParameters, "ParamType", value);
			}
		}

		public string IdentifyNum
		{
			get
			{
				return identifyNum;
			}
			set	
			{
				identifyNum = value;
				DictionaryUtil.Add(QueryParameters, "IdentifyNum", value);
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

        public override Id2MetaVerifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return Id2MetaVerifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
