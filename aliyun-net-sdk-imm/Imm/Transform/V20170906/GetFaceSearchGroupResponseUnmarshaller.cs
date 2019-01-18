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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetFaceSearchGroupResponseUnmarshaller
    {
        public static GetFaceSearchGroupResponse Unmarshall(UnmarshallerContext context)
        {
			GetFaceSearchGroupResponse getFaceSearchGroupResponse = new GetFaceSearchGroupResponse();

			getFaceSearchGroupResponse.HttpResponse = context.HttpResponse;
			getFaceSearchGroupResponse.RequestId = context.StringValue("GetFaceSearchGroup.RequestId");
			getFaceSearchGroupResponse.GroupName = context.StringValue("GetFaceSearchGroup.GroupName");
			getFaceSearchGroupResponse.Count = context.IntegerValue("GetFaceSearchGroup.Count");
			getFaceSearchGroupResponse.Status = context.StringValue("GetFaceSearchGroup.Status");
			getFaceSearchGroupResponse.CreateTime = context.StringValue("GetFaceSearchGroup.CreateTime");
			getFaceSearchGroupResponse.ModifyTime = context.StringValue("GetFaceSearchGroup.ModifyTime");
			getFaceSearchGroupResponse.GroupId = context.StringValue("GetFaceSearchGroup.GroupId");
        
			return getFaceSearchGroupResponse;
        }
    }
}