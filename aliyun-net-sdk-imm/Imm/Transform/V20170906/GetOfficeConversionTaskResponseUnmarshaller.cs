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
        public static GetOfficeConversionTaskResponse Unmarshall(UnmarshallerContext context)
        {
			GetOfficeConversionTaskResponse getOfficeConversionTaskResponse = new GetOfficeConversionTaskResponse();

			getOfficeConversionTaskResponse.HttpResponse = context.HttpResponse;
			getOfficeConversionTaskResponse.RequestId = context.StringValue("GetOfficeConversionTask.RequestId");
			getOfficeConversionTaskResponse.TgtType = context.StringValue("GetOfficeConversionTask.TgtType");
			getOfficeConversionTaskResponse.Status = context.StringValue("GetOfficeConversionTask.Status");
			getOfficeConversionTaskResponse.Percent = context.IntegerValue("GetOfficeConversionTask.Percent");
			getOfficeConversionTaskResponse.PageCount = context.IntegerValue("GetOfficeConversionTask.PageCount");
			getOfficeConversionTaskResponse.TaskId = context.StringValue("GetOfficeConversionTask.TaskId");
			getOfficeConversionTaskResponse.TgtUri = context.StringValue("GetOfficeConversionTask.TgtUri");
			getOfficeConversionTaskResponse.ImageSpec = context.StringValue("GetOfficeConversionTask.ImageSpec");
			getOfficeConversionTaskResponse.NotifyTopicName = context.StringValue("GetOfficeConversionTask.NotifyTopicName");
			getOfficeConversionTaskResponse.NotifyEndpoint = context.StringValue("GetOfficeConversionTask.NotifyEndpoint");
			getOfficeConversionTaskResponse.ExternalID = context.StringValue("GetOfficeConversionTask.ExternalID");
			getOfficeConversionTaskResponse.CreateTime = context.StringValue("GetOfficeConversionTask.CreateTime");
			getOfficeConversionTaskResponse.FinishTime = context.StringValue("GetOfficeConversionTask.FinishTime");
			getOfficeConversionTaskResponse.SrcUri = context.StringValue("GetOfficeConversionTask.SrcUri");

			GetOfficeConversionTaskResponse.GetOfficeConversionTask_FailDetail failDetail = new GetOfficeConversionTaskResponse.GetOfficeConversionTask_FailDetail();
			failDetail.Code = context.StringValue("GetOfficeConversionTask.FailDetail.Code");
			getOfficeConversionTaskResponse.FailDetail = failDetail;
        
			return getOfficeConversionTaskResponse;
        }
    }
}
