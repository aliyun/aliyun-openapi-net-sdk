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
    public class UpdateDomainRecordRequest : RpcAcsRequest<UpdateDomainRecordResponse>
    {
        public UpdateDomainRecordRequest()
            : base("Alidns", "2015-01-09", "UpdateDomainRecord")
        {
        }

		private string _lang;

		private string _userClientIp;

		private string _recordId;

		private string _rR;

		private string _type;

		private string _value;

		private long? _ttl;

		private long? _priority;

		private string _line;

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

		public string RecordId
		{
			get
			{
				return _recordId;
			}
			set	
			{
				_recordId = value;
				DictionaryUtil.Add(QueryParameters, "RecordId", value);
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

		public long? TTL
		{
			get
			{
				return _ttl;
			}
			set	
			{
                _ttl = value;
				DictionaryUtil.Add(QueryParameters, "TTL", value.ToString());
			}
		}

		public long? Priority
		{
			get
			{
				return _priority;
			}
			set	
			{
				_priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value.ToString());
			}
		}

		public string Line
		{
			get
			{
				return _line;
			}
			set	
			{
				_line = value;
				DictionaryUtil.Add(QueryParameters, "Line", value);
			}
		}

        public override UpdateDomainRecordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDomainRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}