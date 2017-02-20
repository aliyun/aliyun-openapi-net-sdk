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
    public class CheckDomainRecordRequest : RpcAcsRequest<CheckDomainRecordResponse>
    {
        public CheckDomainRecordRequest()
            : base("Alidns", "2015-01-09", "CheckDomainRecord")
        {
        }

		private string _lang;

		private string _userClientIp;

		private string _domainName;

		private string _rR;

		private string _type;

		private string _value;

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

		public string DomainName
		{
			get
			{
				return _domainName;
			}
			set	
			{
				_domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string RR
		{
			get
			{
				return _rR;
			}
			set	
			{
				_rR = value;
				DictionaryUtil.Add(QueryParameters, "RR", value);
			}
		}

		public string Type
		{
			get
			{
				return _type;
			}
			set	
			{
				_type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string Value
		{
			get
			{
				return _value;
			}
			set	
			{
				_value = value;
				DictionaryUtil.Add(QueryParameters, "Value", value);
			}
		}

        public override CheckDomainRecordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckDomainRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}