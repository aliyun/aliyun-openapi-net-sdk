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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class SubmitGatewayLocalConfigDeletingTaskResponseUnmarshaller
    {
        public static SubmitGatewayLocalConfigDeletingTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitGatewayLocalConfigDeletingTaskResponse submitGatewayLocalConfigDeletingTaskResponse = new SubmitGatewayLocalConfigDeletingTaskResponse();

			submitGatewayLocalConfigDeletingTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitGatewayLocalConfigDeletingTaskResponse.RequestId = _ctx.StringValue("SubmitGatewayLocalConfigDeletingTask.RequestId");
			submitGatewayLocalConfigDeletingTaskResponse.Success = _ctx.BooleanValue("SubmitGatewayLocalConfigDeletingTask.Success");
			submitGatewayLocalConfigDeletingTaskResponse.Code = _ctx.StringValue("SubmitGatewayLocalConfigDeletingTask.Code");
			submitGatewayLocalConfigDeletingTaskResponse.ErrorMessage = _ctx.StringValue("SubmitGatewayLocalConfigDeletingTask.ErrorMessage");
			submitGatewayLocalConfigDeletingTaskResponse.Data = _ctx.LongValue("SubmitGatewayLocalConfigDeletingTask.Data");
        
			return submitGatewayLocalConfigDeletingTaskResponse;
        }
    }
}
