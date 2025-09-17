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
using Aliyun.Acs.marketplaceIntl;
using Aliyun.Acs.marketplaceIntl.Transform;
using Aliyun.Acs.marketplaceIntl.Transform.V20221230;

namespace Aliyun.Acs.marketplaceIntl.Model.V20221230
{
    public class NoticeInstanceUserRequest : RpcAcsRequest<NoticeInstanceUserResponse>
    {
        public NoticeInstanceUserRequest()
            : base("marketplaceIntl", "2022-12-30", "NoticeInstanceUser")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string noticeParam;

		private long? instanceId;

		private long? noticeType;

		public string NoticeParam
		{
			get
			{
				return noticeParam;
			}
			set	
			{
				noticeParam = value;
				DictionaryUtil.Add(BodyParameters, "NoticeParam", value);
			}
		}

		public long? InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value.ToString());
			}
		}

		public long? NoticeType
		{
			get
			{
				return noticeType;
			}
			set	
			{
				noticeType = value;
				DictionaryUtil.Add(BodyParameters, "NoticeType", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override NoticeInstanceUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return NoticeInstanceUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
