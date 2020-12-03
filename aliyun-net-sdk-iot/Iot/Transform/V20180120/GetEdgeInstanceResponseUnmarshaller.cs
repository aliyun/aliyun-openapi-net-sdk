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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GetEdgeInstanceResponseUnmarshaller
    {
        public static GetEdgeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEdgeInstanceResponse getEdgeInstanceResponse = new GetEdgeInstanceResponse();

			getEdgeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getEdgeInstanceResponse.RequestId = _ctx.StringValue("GetEdgeInstance.RequestId");
			getEdgeInstanceResponse.Success = _ctx.BooleanValue("GetEdgeInstance.Success");
			getEdgeInstanceResponse.Code = _ctx.StringValue("GetEdgeInstance.Code");
			getEdgeInstanceResponse.ErrorMessage = _ctx.StringValue("GetEdgeInstance.ErrorMessage");

			GetEdgeInstanceResponse.GetEdgeInstance_Data data = new GetEdgeInstanceResponse.GetEdgeInstance_Data();
			data.InstanceId = _ctx.StringValue("GetEdgeInstance.Data.InstanceId");
			data.Name = _ctx.StringValue("GetEdgeInstance.Data.Name");
			data.Tags = _ctx.StringValue("GetEdgeInstance.Data.Tags");
			data.Type = _ctx.StringValue("GetEdgeInstance.Data.Type");
			data.Spec = _ctx.IntegerValue("GetEdgeInstance.Data.Spec");
			data.BizEnable = _ctx.BooleanValue("GetEdgeInstance.Data.BizEnable");
			data.GmtCreate = _ctx.StringValue("GetEdgeInstance.Data.GmtCreate");
			data.GmtModified = _ctx.StringValue("GetEdgeInstance.Data.GmtModified");
			data.RoleArn = _ctx.StringValue("GetEdgeInstance.Data.RoleArn");
			data.RoleName = _ctx.StringValue("GetEdgeInstance.Data.RoleName");
			data.RoleAttachTime = _ctx.StringValue("GetEdgeInstance.Data.RoleAttachTime");
			data.LatestDeploymentStatus = _ctx.IntegerValue("GetEdgeInstance.Data.LatestDeploymentStatus");
			data.LatestDeploymentType = _ctx.StringValue("GetEdgeInstance.Data.LatestDeploymentType");
			data.GmtCreateTimestamp = _ctx.LongValue("GetEdgeInstance.Data.GmtCreateTimestamp");
			data.GmtModifiedTimestamp = _ctx.LongValue("GetEdgeInstance.Data.GmtModifiedTimestamp");
			data.RoleAttachTimestamp = _ctx.LongValue("GetEdgeInstance.Data.RoleAttachTimestamp");
			getEdgeInstanceResponse.Data = data;
        
			return getEdgeInstanceResponse;
        }
    }
}
