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
        public static GetEdgeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetEdgeInstanceResponse getEdgeInstanceResponse = new GetEdgeInstanceResponse();

			getEdgeInstanceResponse.HttpResponse = context.HttpResponse;
			getEdgeInstanceResponse.RequestId = context.StringValue("GetEdgeInstance.RequestId");
			getEdgeInstanceResponse.Success = context.BooleanValue("GetEdgeInstance.Success");
			getEdgeInstanceResponse.Code = context.StringValue("GetEdgeInstance.Code");
			getEdgeInstanceResponse.ErrorMessage = context.StringValue("GetEdgeInstance.ErrorMessage");

			GetEdgeInstanceResponse.GetEdgeInstance_Data data = new GetEdgeInstanceResponse.GetEdgeInstance_Data();
			data.InstanceId = context.StringValue("GetEdgeInstance.Data.InstanceId");
			data.Name = context.StringValue("GetEdgeInstance.Data.Name");
			data.Tags = context.StringValue("GetEdgeInstance.Data.Tags");
			data.Type = context.StringValue("GetEdgeInstance.Data.Type");
			data.Spec = context.IntegerValue("GetEdgeInstance.Data.Spec");
			data.BizEnable = context.BooleanValue("GetEdgeInstance.Data.BizEnable");
			data.GmtCreate = context.StringValue("GetEdgeInstance.Data.GmtCreate");
			data.GmtModified = context.StringValue("GetEdgeInstance.Data.GmtModified");
			data.RoleArn = context.StringValue("GetEdgeInstance.Data.RoleArn");
			data.RoleName = context.StringValue("GetEdgeInstance.Data.RoleName");
			data.RoleAttachTime = context.StringValue("GetEdgeInstance.Data.RoleAttachTime");
			data.LatestDeploymentStatus = context.IntegerValue("GetEdgeInstance.Data.LatestDeploymentStatus");
			data.LatestDeploymentType = context.StringValue("GetEdgeInstance.Data.LatestDeploymentType");
			data.GmtCreateTimestamp = context.LongValue("GetEdgeInstance.Data.GmtCreateTimestamp");
			data.GmtModifiedTimestamp = context.LongValue("GetEdgeInstance.Data.GmtModifiedTimestamp");
			data.RoleAttachTimestamp = context.LongValue("GetEdgeInstance.Data.RoleAttachTimestamp");
			getEdgeInstanceResponse.Data = data;
        
			return getEdgeInstanceResponse;
        }
    }
}
