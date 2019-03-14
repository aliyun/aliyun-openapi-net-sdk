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
using Aliyun.Acs.MoPen.Model.V20180211;

namespace Aliyun.Acs.MoPen.Transform.V20180211
{
    public class MopenCreateGroupResponseUnmarshaller
    {
        public static MopenCreateGroupResponse Unmarshall(UnmarshallerContext context)
        {
			MopenCreateGroupResponse mopenCreateGroupResponse = new MopenCreateGroupResponse();

			mopenCreateGroupResponse.HttpResponse = context.HttpResponse;
			mopenCreateGroupResponse.Code = context.IntegerValue("MopenCreateGroup.Code");
			mopenCreateGroupResponse.Success = context.StringValue("MopenCreateGroup.Success");
			mopenCreateGroupResponse.Description = context.StringValue("MopenCreateGroup.Description");
			mopenCreateGroupResponse.Message = context.StringValue("MopenCreateGroup.Message");
			mopenCreateGroupResponse.ResqusetId = context.StringValue("MopenCreateGroup.ResqusetId");

			MopenCreateGroupResponse.MopenCreateGroup_Data data = new MopenCreateGroupResponse.MopenCreateGroup_Data();
			data.GroupId = context.StringValue("MopenCreateGroup.Data.GroupId");
			mopenCreateGroupResponse.Data = data;
        
			return mopenCreateGroupResponse;
        }
    }
}
