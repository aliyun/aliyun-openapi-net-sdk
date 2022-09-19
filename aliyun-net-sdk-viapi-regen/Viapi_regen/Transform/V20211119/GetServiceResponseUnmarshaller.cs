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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class GetServiceResponseUnmarshaller
    {
        public static GetServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceResponse getServiceResponse = new GetServiceResponse();

			getServiceResponse.HttpResponse = _ctx.HttpResponse;
			getServiceResponse.Message = _ctx.StringValue("GetService.Message");
			getServiceResponse.RequestId = _ctx.StringValue("GetService.RequestId");
			getServiceResponse.Code = _ctx.StringValue("GetService.Code");

			GetServiceResponse.GetService_Data data = new GetServiceResponse.GetService_Data();
			data.Id = _ctx.LongValue("GetService.Data.Id");
			data.GmtCreate = _ctx.LongValue("GetService.Data.GmtCreate");
			data.ServiceName = _ctx.StringValue("GetService.Data.ServiceName");
			data.ServiceDescription = _ctx.StringValue("GetService.Data.ServiceDescription");
			data.Status = _ctx.StringValue("GetService.Data.Status");
			data.ServiceId = _ctx.StringValue("GetService.Data.ServiceId");
			data.InputParams = _ctx.StringValue("GetService.Data.InputParams");
			data.OutputParams = _ctx.StringValue("GetService.Data.OutputParams");
			data.Errorcodes = _ctx.StringValue("GetService.Data.Errorcodes");
			data.InputExample = _ctx.StringValue("GetService.Data.InputExample");
			data.OutputExample = _ctx.StringValue("GetService.Data.OutputExample");

			GetServiceResponse.GetService_Data.GetService_DataReflowInfo dataReflowInfo = new GetServiceResponse.GetService_Data.GetService_DataReflowInfo();
			dataReflowInfo.DataReflowCount = _ctx.LongValue("GetService.Data.DataReflowInfo.DataReflowCount");
			dataReflowInfo.DataReflowRate = _ctx.LongValue("GetService.Data.DataReflowInfo.DataReflowRate");
			dataReflowInfo.DataReflowOssPath = _ctx.StringValue("GetService.Data.DataReflowInfo.DataReflowOssPath");
			dataReflowInfo.EnableDataReflowFlag = _ctx.BooleanValue("GetService.Data.DataReflowInfo.EnableDataReflowFlag");
			data.DataReflowInfo = dataReflowInfo;
			getServiceResponse.Data = data;
        
			return getServiceResponse;
        }
    }
}
