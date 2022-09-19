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
    public class EnableDataReflowResponseUnmarshaller
    {
        public static EnableDataReflowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EnableDataReflowResponse enableDataReflowResponse = new EnableDataReflowResponse();

			enableDataReflowResponse.HttpResponse = _ctx.HttpResponse;
			enableDataReflowResponse.Message = _ctx.StringValue("EnableDataReflow.Message");
			enableDataReflowResponse.RequestId = _ctx.StringValue("EnableDataReflow.RequestId");
			enableDataReflowResponse.Code = _ctx.StringValue("EnableDataReflow.Code");

			EnableDataReflowResponse.EnableDataReflow_Data data = new EnableDataReflowResponse.EnableDataReflow_Data();
			data.ServiceId = _ctx.LongValue("EnableDataReflow.Data.ServiceId");
			data.EnableDataReflowFlag = _ctx.BooleanValue("EnableDataReflow.Data.EnableDataReflowFlag");
			data.DataReflowRate = _ctx.LongValue("EnableDataReflow.Data.DataReflowRate");
			data.DataReflowOssPath = _ctx.StringValue("EnableDataReflow.Data.DataReflowOssPath");
			enableDataReflowResponse.Data = data;
        
			return enableDataReflowResponse;
        }
    }
}
