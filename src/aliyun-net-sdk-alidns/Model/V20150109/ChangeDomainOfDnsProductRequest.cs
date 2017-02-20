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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class ChangeDomainOfDnsProductRequest : RpcAcsRequest<ChangeDomainOfDnsProductResponse>
    {
        public ChangeDomainOfDnsProductRequest()
            : base("Alidns", "2015-01-09", "ChangeDomainOfDnsProduct")
        {
        }

		private string _lang;

		private string _userClientIp;

		private string _instanceId;

		private string _newDomain;

		public string Lang
		{
			get
			{
				return _lang;
			}
			set	
			{
				_lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return _userClientIp;
			}
			set	
			{
				_userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return _instanceId;
			}
			set	
			{
				_instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string NewDomain
		{
			get
			{
				return _newDomain;
			}
			set	
			{
				_newDomain = value;
				DictionaryUtil.Add(QueryParameters, "NewDomain", value);
			}
		}

        public override ChangeDomainOfDnsProductResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ChangeDomainOfDnsProductResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}