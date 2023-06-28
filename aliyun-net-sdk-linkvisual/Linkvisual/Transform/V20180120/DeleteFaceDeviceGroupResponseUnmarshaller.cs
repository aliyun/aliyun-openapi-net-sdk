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
    public class DeleteFaceDeviceGroupResponseUnmarshaller
    {
        public static DeleteFaceDeviceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteFaceDeviceGroupResponse deleteFaceDeviceGroupResponse = new DeleteFaceDeviceGroupResponse();

			deleteFaceDeviceGroupResponse.HttpResponse = _ctx.HttpResponse;
			deleteFaceDeviceGroupResponse.Code = _ctx.StringValue("DeleteFaceDeviceGroup.Code");
			deleteFaceDeviceGroupResponse.ErrorMessage = _ctx.StringValue("DeleteFaceDeviceGroup.ErrorMessage");
			deleteFaceDeviceGroupResponse.RequestId = _ctx.StringValue("DeleteFaceDeviceGroup.RequestId");
			deleteFaceDeviceGroupResponse.Success = _ctx.BooleanValue("DeleteFaceDeviceGroup.Success");
        
			return deleteFaceDeviceGroupResponse;
        }
    }
}
