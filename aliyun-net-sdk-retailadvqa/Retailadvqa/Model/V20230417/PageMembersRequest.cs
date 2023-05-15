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
using Aliyun.Acs.retailadvqa;
using Aliyun.Acs.retailadvqa.Transform;
using Aliyun.Acs.retailadvqa.Transform.V20230417;

namespace Aliyun.Acs.retailadvqa.Model.V20230417
{
    public class PageMembersRequest : RpcAcsRequest<PageMembersResponse>
    {
        public PageMembersRequest()
            : base("retailadvqa", "2023-04-17", "PageMembers")
        {
			Method = MethodType.POST;
        }

		private string body;

		public string Body
		{
			get
			{
				return body;
			}
			set	
			{
				body = value;
				DictionaryUtil.Add(QueryParameters, "body", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PageMembersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PageMembersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
