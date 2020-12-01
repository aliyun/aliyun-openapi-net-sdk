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
    public class ListSmartGroupResponseUnmarshaller
    {
        public static ListSmartGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSmartGroupResponse listSmartGroupResponse = new ListSmartGroupResponse();

			listSmartGroupResponse.HttpResponse = _ctx.HttpResponse;
			listSmartGroupResponse.Successful = _ctx.BooleanValue("ListSmartGroup.Successful");
			listSmartGroupResponse.ErrorCode = _ctx.StringValue("ListSmartGroup.ErrorCode");
			listSmartGroupResponse.ErrorMsg = _ctx.StringValue("ListSmartGroup.ErrorMsg");
			listSmartGroupResponse.RequestId = _ctx.StringValue("ListSmartGroup.RequestId");

			List<ListSmartGroupResponse.ListSmartGroup_SmartGroup> listSmartGroupResponse_object = new List<ListSmartGroupResponse.ListSmartGroup_SmartGroup>();
			for (int i = 0; i < _ctx.Length("ListSmartGroup.Object.Length"); i++) {
				ListSmartGroupResponse.ListSmartGroup_SmartGroup smartGroup = new ListSmartGroupResponse.ListSmartGroup_SmartGroup();
				smartGroup.Id = _ctx.StringValue("ListSmartGroup.Object["+ i +"].Id");
				smartGroup.Type = _ctx.StringValue("ListSmartGroup.Object["+ i +"].Type");

				listSmartGroupResponse_object.Add(smartGroup);
			}
			listSmartGroupResponse._Object = listSmartGroupResponse_object;
        
			return listSmartGroupResponse;
        }
    }
}
