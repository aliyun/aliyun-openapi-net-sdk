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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class PageListAppInstanceGroupUserResponseUnmarshaller
    {
        public static PageListAppInstanceGroupUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PageListAppInstanceGroupUserResponse pageListAppInstanceGroupUserResponse = new PageListAppInstanceGroupUserResponse();

			pageListAppInstanceGroupUserResponse.HttpResponse = _ctx.HttpResponse;
			pageListAppInstanceGroupUserResponse.RequestId = _ctx.StringValue("PageListAppInstanceGroupUser.RequestId");

			List<string> pageListAppInstanceGroupUserResponse_users = new List<string>();
			for (int i = 0; i < _ctx.Length("PageListAppInstanceGroupUser.Users.Length"); i++) {
				pageListAppInstanceGroupUserResponse_users.Add(_ctx.StringValue("PageListAppInstanceGroupUser.Users["+ i +"]"));
			}
			pageListAppInstanceGroupUserResponse.Users = pageListAppInstanceGroupUserResponse_users;
        
			return pageListAppInstanceGroupUserResponse;
        }
    }
}
