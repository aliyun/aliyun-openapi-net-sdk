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
    public class DeleteRecordPlanDeviceResponseUnmarshaller
    {
        public static DeleteRecordPlanDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRecordPlanDeviceResponse deleteRecordPlanDeviceResponse = new DeleteRecordPlanDeviceResponse();

			deleteRecordPlanDeviceResponse.HttpResponse = _ctx.HttpResponse;
			deleteRecordPlanDeviceResponse.Code = _ctx.StringValue("DeleteRecordPlanDevice.Code");
			deleteRecordPlanDeviceResponse.RequestId = _ctx.StringValue("DeleteRecordPlanDevice.RequestId");
			deleteRecordPlanDeviceResponse.ErrorMessage = _ctx.StringValue("DeleteRecordPlanDevice.ErrorMessage");
			deleteRecordPlanDeviceResponse.Success = _ctx.BooleanValue("DeleteRecordPlanDevice.Success");
        
			return deleteRecordPlanDeviceResponse;
        }
    }
}
