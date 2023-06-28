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
using Aliyun.Acs.lto;
using Aliyun.Acs.lto.Transform;
using Aliyun.Acs.lto.Transform.V20210707;

namespace Aliyun.Acs.lto.Model.V20210707
{
    public class AddMemberRequest : RpcAcsRequest<AddMemberResponse>
    {
        public AddMemberRequest()
            : base("lto", "2021-07-07", "AddMember")
        {
			Method = MethodType.POST;
        }

		private string remark;

		private string uid;

		private string telephony;

		private string name;

		private int? authorizedDeviceCount;

		private string contactor;

		private long? authorizedCount;

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value);
			}
		}

		public string Telephony
		{
			get
			{
				return telephony;
			}
			set	
			{
				telephony = value;
				DictionaryUtil.Add(QueryParameters, "Telephony", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public int? AuthorizedDeviceCount
		{
			get
			{
				return authorizedDeviceCount;
			}
			set	
			{
				authorizedDeviceCount = value;
				DictionaryUtil.Add(QueryParameters, "AuthorizedDeviceCount", value.ToString());
			}
		}

		public string Contactor
		{
			get
			{
				return contactor;
			}
			set	
			{
				contactor = value;
				DictionaryUtil.Add(QueryParameters, "Contactor", value);
			}
		}

		public long? AuthorizedCount
		{
			get
			{
				return authorizedCount;
			}
			set	
			{
				authorizedCount = value;
				DictionaryUtil.Add(QueryParameters, "AuthorizedCount", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddMemberResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddMemberResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
