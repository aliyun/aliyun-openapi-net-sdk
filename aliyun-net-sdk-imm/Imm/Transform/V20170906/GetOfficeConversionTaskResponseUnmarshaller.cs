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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetOfficeConversionTaskResponseUnmarshaller
    {
        public static GetOfficeConversionTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOfficeConversionTaskResponse getOfficeConversionTaskResponse = new GetOfficeConversionTaskResponse();

			getOfficeConversionTaskResponse.HttpResponse = _ctx.HttpResponse;
			getOfficeConversionTaskResponse.RequestId = _ctx.StringValue("GetOfficeConversionTask.RequestId");
			getOfficeConversionTaskResponse.TgtType = _ctx.StringValue("GetOfficeConversionTask.TgtType");
			getOfficeConversionTaskResponse.Status = _ctx.StringValue("GetOfficeConversionTask.Status");
			getOfficeConversionTaskResponse.Percent = _ctx.IntegerValue("GetOfficeConversionTask.Percent");
			getOfficeConversionTaskResponse.PageCount = _ctx.IntegerValue("GetOfficeConversionTask.PageCount");
			getOfficeConversionTaskResponse.TaskId = _ctx.StringValue("GetOfficeConversionTask.TaskId");
			getOfficeConversionTaskResponse.TgtUri = _ctx.StringValue("GetOfficeConversionTask.TgtUri");
			getOfficeConversionTaskResponse.ImageSpec = _ctx.StringValue("GetOfficeConversionTask.ImageSpec");
			getOfficeConversionTaskResponse.NotifyTopicName = _ctx.StringValue("GetOfficeConversionTask.NotifyTopicName");
			getOfficeConversionTaskResponse.NotifyEndpoint = _ctx.StringValue("GetOfficeConversionTask.NotifyEndpoint");
			getOfficeConversionTaskResponse.ExternalID = _ctx.StringValue("GetOfficeConversionTask.ExternalID");
			getOfficeConversionTaskResponse.CreateTime = _ctx.StringValue("GetOfficeConversionTask.CreateTime");
			getOfficeConversionTaskResponse.FinishTime = _ctx.StringValue("GetOfficeConversionTask.FinishTime");
			getOfficeConversionTaskResponse.SrcUri = _ctx.StringValue("GetOfficeConversionTask.SrcUri");

			GetOfficeConversionTaskResponse.GetOfficeConversionTask_FailDetail failDetail = new GetOfficeConversionTaskResponse.GetOfficeConversionTask_FailDetail();
			failDetail.Code = _ctx.StringValue("GetOfficeConversionTask.FailDetail.Code");
			getOfficeConversionTaskResponse.FailDetail = failDetail;
        
			return getOfficeConversionTaskResponse;
        }
    }
}
