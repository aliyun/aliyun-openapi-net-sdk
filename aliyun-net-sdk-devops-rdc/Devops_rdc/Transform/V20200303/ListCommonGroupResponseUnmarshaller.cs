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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListCommonGroupResponseUnmarshaller
    {
        public static ListCommonGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCommonGroupResponse listCommonGroupResponse = new ListCommonGroupResponse();

			listCommonGroupResponse.HttpResponse = _ctx.HttpResponse;
			listCommonGroupResponse.Successful = _ctx.BooleanValue("ListCommonGroup.Successful");
			listCommonGroupResponse.ErrorCode = _ctx.StringValue("ListCommonGroup.ErrorCode");
			listCommonGroupResponse.ErrorMsg = _ctx.StringValue("ListCommonGroup.ErrorMsg");
			listCommonGroupResponse.RequestId = _ctx.StringValue("ListCommonGroup.RequestId");

			List<ListCommonGroupResponse.ListCommonGroup_CommonGroup> listCommonGroupResponse_object = new List<ListCommonGroupResponse.ListCommonGroup_CommonGroup>();
			for (int i = 0; i < _ctx.Length("ListCommonGroup.Object.Length"); i++) {
				ListCommonGroupResponse.ListCommonGroup_CommonGroup commonGroup = new ListCommonGroupResponse.ListCommonGroup_CommonGroup();
				commonGroup.Pinyin = _ctx.StringValue("ListCommonGroup.Object["+ i +"].Pinyin");
				commonGroup.IsRoot = _ctx.BooleanValue("ListCommonGroup.Object["+ i +"].IsRoot");
				commonGroup.Pos = _ctx.IntegerValue("ListCommonGroup.Object["+ i +"].Pos");
				commonGroup.ResourceCount = _ctx.IntegerValue("ListCommonGroup.Object["+ i +"].ResourceCount");
				commonGroup.Name = _ctx.StringValue("ListCommonGroup.Object["+ i +"].Name");
				commonGroup.CreatorId = _ctx.StringValue("ListCommonGroup.Object["+ i +"].CreatorId");
				commonGroup.SmartGroupId = _ctx.StringValue("ListCommonGroup.Object["+ i +"].SmartGroupId");
				commonGroup.ProjectId = _ctx.StringValue("ListCommonGroup.Object["+ i +"].ProjectId");
				commonGroup.Id = _ctx.StringValue("ListCommonGroup.Object["+ i +"].id");

				listCommonGroupResponse_object.Add(commonGroup);
			}
			listCommonGroupResponse._Object = listCommonGroupResponse_object;
        
			return listCommonGroupResponse;
        }
    }
}
