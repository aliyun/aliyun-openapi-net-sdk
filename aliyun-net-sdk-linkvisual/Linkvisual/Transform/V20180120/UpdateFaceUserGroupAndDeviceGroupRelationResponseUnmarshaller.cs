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
    public class UpdateFaceUserGroupAndDeviceGroupRelationResponseUnmarshaller
    {
        public static UpdateFaceUserGroupAndDeviceGroupRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateFaceUserGroupAndDeviceGroupRelationResponse updateFaceUserGroupAndDeviceGroupRelationResponse = new UpdateFaceUserGroupAndDeviceGroupRelationResponse();

			updateFaceUserGroupAndDeviceGroupRelationResponse.HttpResponse = _ctx.HttpResponse;
			updateFaceUserGroupAndDeviceGroupRelationResponse.Code = _ctx.StringValue("UpdateFaceUserGroupAndDeviceGroupRelation.Code");
			updateFaceUserGroupAndDeviceGroupRelationResponse.RequestId = _ctx.StringValue("UpdateFaceUserGroupAndDeviceGroupRelation.RequestId");
			updateFaceUserGroupAndDeviceGroupRelationResponse.ErrorMessage = _ctx.StringValue("UpdateFaceUserGroupAndDeviceGroupRelation.ErrorMessage");
			updateFaceUserGroupAndDeviceGroupRelationResponse.Success = _ctx.BooleanValue("UpdateFaceUserGroupAndDeviceGroupRelation.Success");

			UpdateFaceUserGroupAndDeviceGroupRelationResponse.UpdateFaceUserGroupAndDeviceGroupRelation_Data data = new UpdateFaceUserGroupAndDeviceGroupRelationResponse.UpdateFaceUserGroupAndDeviceGroupRelation_Data();
			data.ControlId = _ctx.StringValue("UpdateFaceUserGroupAndDeviceGroupRelation.Data.ControlId");
			data.ModifiedTime = _ctx.StringValue("UpdateFaceUserGroupAndDeviceGroupRelation.Data.ModifiedTime");
			updateFaceUserGroupAndDeviceGroupRelationResponse.Data = data;
        
			return updateFaceUserGroupAndDeviceGroupRelationResponse;
        }
    }
}
