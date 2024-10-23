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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class ListUserBasicInfosResponseUnmarshaller
    {
        public static ListUserBasicInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserBasicInfosResponse listUserBasicInfosResponse = new ListUserBasicInfosResponse();

			listUserBasicInfosResponse.HttpResponse = _ctx.HttpResponse;
			listUserBasicInfosResponse.RequestId = _ctx.StringValue("ListUserBasicInfos.RequestId");
			listUserBasicInfosResponse.IsTruncated = _ctx.BooleanValue("ListUserBasicInfos.IsTruncated");
			listUserBasicInfosResponse.Marker = _ctx.StringValue("ListUserBasicInfos.Marker");

			List<ListUserBasicInfosResponse.ListUserBasicInfos_UserBasicInfo> listUserBasicInfosResponse_userBasicInfos = new List<ListUserBasicInfosResponse.ListUserBasicInfos_UserBasicInfo>();
			for (int i = 0; i < _ctx.Length("ListUserBasicInfos.UserBasicInfos.Length"); i++) {
				ListUserBasicInfosResponse.ListUserBasicInfos_UserBasicInfo userBasicInfo = new ListUserBasicInfosResponse.ListUserBasicInfos_UserBasicInfo();
				userBasicInfo.UserPrincipalName = _ctx.StringValue("ListUserBasicInfos.UserBasicInfos["+ i +"].UserPrincipalName");
				userBasicInfo.DisplayName = _ctx.StringValue("ListUserBasicInfos.UserBasicInfos["+ i +"].DisplayName");
				userBasicInfo.UserId = _ctx.StringValue("ListUserBasicInfos.UserBasicInfos["+ i +"].UserId");
				userBasicInfo.Status = _ctx.StringValue("ListUserBasicInfos.UserBasicInfos["+ i +"].Status");

				listUserBasicInfosResponse_userBasicInfos.Add(userBasicInfo);
			}
			listUserBasicInfosResponse.UserBasicInfos = listUserBasicInfosResponse_userBasicInfos;
        
			return listUserBasicInfosResponse;
        }
    }
}
