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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class GetMailTaskListRequest : RpcAcsRequest<GetMailTaskListResponse>
    {
        public GetMailTaskListRequest()
            : base("quickbi-public", "2022-01-01", "GetMailTaskList", "2.2.0", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? paused;

		private string userNick;

		private int? pageNum;

		private int? pageSize;

		public bool? Paused
		{
			get
			{
				return paused;
			}
			set	
			{
				paused = value;
				DictionaryUtil.Add(QueryParameters, "Paused", value.ToString());
			}
		}

		public string UserNick
		{
			get
			{
				return userNick;
			}
			set	
			{
				userNick = value;
				DictionaryUtil.Add(QueryParameters, "UserNick", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetMailTaskListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetMailTaskListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
