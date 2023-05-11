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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class AddFaceUserGroupAndDeviceGroupRelationResponseUnmarshaller
    {
        public static AddFaceUserGroupAndDeviceGroupRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddFaceUserGroupAndDeviceGroupRelationResponse addFaceUserGroupAndDeviceGroupRelationResponse = new AddFaceUserGroupAndDeviceGroupRelationResponse();

			addFaceUserGroupAndDeviceGroupRelationResponse.HttpResponse = _ctx.HttpResponse;
			addFaceUserGroupAndDeviceGroupRelationResponse.Code = _ctx.StringValue("AddFaceUserGroupAndDeviceGroupRelation.Code");
			addFaceUserGroupAndDeviceGroupRelationResponse.RequestId = _ctx.StringValue("AddFaceUserGroupAndDeviceGroupRelation.RequestId");
			addFaceUserGroupAndDeviceGroupRelationResponse.ErrorMessage = _ctx.StringValue("AddFaceUserGroupAndDeviceGroupRelation.ErrorMessage");
			addFaceUserGroupAndDeviceGroupRelationResponse.Success = _ctx.BooleanValue("AddFaceUserGroupAndDeviceGroupRelation.Success");

			AddFaceUserGroupAndDeviceGroupRelationResponse.AddFaceUserGroupAndDeviceGroupRelation_Data data = new AddFaceUserGroupAndDeviceGroupRelationResponse.AddFaceUserGroupAndDeviceGroupRelation_Data();
			data.ControlId = _ctx.StringValue("AddFaceUserGroupAndDeviceGroupRelation.Data.ControlId");
			data.ModifiedTime = _ctx.StringValue("AddFaceUserGroupAndDeviceGroupRelation.Data.ModifiedTime");
			addFaceUserGroupAndDeviceGroupRelationResponse.Data = data;
        
			return addFaceUserGroupAndDeviceGroupRelationResponse;
        }
    }
}
