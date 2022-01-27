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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceResponse.RequestId = _ctx.StringValue("GetInstance.RequestId");

			GetInstanceResponse.GetInstance_Instance instance = new GetInstanceResponse.GetInstance_Instance();
			instance.Id = _ctx.LongValue("GetInstance.Instance.Id");
			instance.ProjectName = _ctx.StringValue("GetInstance.Instance.ProjectName");
			instance.JobName = _ctx.StringValue("GetInstance.Instance.JobName");
			instance.ActualState = _ctx.StringValue("GetInstance.Instance.ActualState");
			instance.ExpectState = _ctx.StringValue("GetInstance.Instance.ExpectState");
			instance.JobType = _ctx.StringValue("GetInstance.Instance.JobType");
			instance.ApiType = _ctx.StringValue("GetInstance.Instance.ApiType");
			instance.Code = _ctx.StringValue("GetInstance.Instance.Code");
			instance.Properties = _ctx.StringValue("GetInstance.Instance.Properties");
			instance.Packages = _ctx.StringValue("GetInstance.Instance.Packages");
			instance.Starter = _ctx.StringValue("GetInstance.Instance.Starter");
			instance.StartTime = _ctx.LongValue("GetInstance.Instance.StartTime");
			instance.LastErrorTime = _ctx.LongValue("GetInstance.Instance.LastErrorTime");
			instance.LastErrorMessage = _ctx.StringValue("GetInstance.Instance.LastErrorMessage");
			instance.LastOperator = _ctx.StringValue("GetInstance.Instance.LastOperator");
			instance.LastOperateTime = _ctx.LongValue("GetInstance.Instance.LastOperateTime");
			instance.PlanJson = _ctx.StringValue("GetInstance.Instance.PlanJson");
			instance.EngineVersion = _ctx.StringValue("GetInstance.Instance.EngineVersion");
			instance.EngineJobHandler = _ctx.StringValue("GetInstance.Instance.EngineJobHandler");
			instance.InputDelay = _ctx.LongValue("GetInstance.Instance.InputDelay");
			instance.ClusterId = _ctx.StringValue("GetInstance.Instance.ClusterId");
			instance.QueueName = _ctx.StringValue("GetInstance.Instance.QueueName");
			instance.EndTime = _ctx.LongValue("GetInstance.Instance.EndTime");
			instance.AutoScaleParams = _ctx.StringValue("GetInstance.Instance.AutoScaleParams");
			instance.Priority = _ctx.IntegerValue("GetInstance.Instance.Priority");
			getInstanceResponse.Instance = instance;
        
			return getInstanceResponse;
        }
    }
}
