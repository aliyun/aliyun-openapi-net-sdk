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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = context.HttpResponse;
			getInstanceResponse.ErrorCode = context.StringValue("GetInstance.ErrorCode");
			getInstanceResponse.ErrorMessage = context.StringValue("GetInstance.ErrorMessage");
			getInstanceResponse.HttpStatusCode = context.IntegerValue("GetInstance.HttpStatusCode");
			getInstanceResponse.RequestId = context.StringValue("GetInstance.RequestId");
			getInstanceResponse.Success = context.BooleanValue("GetInstance.Success");

			GetInstanceResponse.GetInstance_Data data = new GetInstanceResponse.GetInstance_Data();
			data.NodeId = context.LongValue("GetInstance.Data.NodeId");
			data.InstanceId = context.LongValue("GetInstance.Data.InstanceId");
			data.DagId = context.LongValue("GetInstance.Data.DagId");
			data.DagType = context.StringValue("GetInstance.Data.DagType");
			data.Status = context.StringValue("GetInstance.Data.Status");
			data.Bizdate = context.LongValue("GetInstance.Data.Bizdate");
			data.ParamValues = context.StringValue("GetInstance.Data.ParamValues");
			data.CycTime = context.LongValue("GetInstance.Data.CycTime");
			data.FinishTime = context.LongValue("GetInstance.Data.FinishTime");
			data.BeginWaitTimeTime = context.LongValue("GetInstance.Data.BeginWaitTimeTime");
			data.BeginWaitResTime = context.LongValue("GetInstance.Data.BeginWaitResTime");
			data.BeginRunningTime = context.LongValue("GetInstance.Data.BeginRunningTime");
			data.CreateTime = context.LongValue("GetInstance.Data.CreateTime");
			data.ModifyTime = context.LongValue("GetInstance.Data.ModifyTime");
			data.NodeName = context.StringValue("GetInstance.Data.NodeName");
			getInstanceResponse.Data = data;
        
			return getInstanceResponse;
        }
    }
}
