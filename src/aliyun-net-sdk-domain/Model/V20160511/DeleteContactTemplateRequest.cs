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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain.Transform.V20160511;

namespace Aliyun.Acs.Domain.Model.V20160511
{
    public class DeleteContactTemplateRequest : RpcAcsRequest<DeleteContactTemplateResponse>
    {
        public DeleteContactTemplateRequest()
            : base("Domain", "2016-05-11", "DeleteContactTemplate")
        {
        }

		private string _userClientIp;

		private string _lang;

		private long? _contactTemplateId;

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

		public long? ContactTemplateId
		{
			get
			{
				return _contactTemplateId;
			}
			set	
			{
				_contactTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "ContactTemplateId", value.ToString());
			}
		}

        public override DeleteContactTemplateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DeleteContactTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}