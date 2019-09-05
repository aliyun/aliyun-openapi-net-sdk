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
        public static GetInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = context.HttpResponse;
			getInstanceResponse.RequestId = context.StringValue("GetInstance.RequestId");

			GetInstanceResponse.GetInstance_Instance instance = new GetInstanceResponse.GetInstance_Instance();
			instance.Id = context.LongValue("GetInstance.Instance.Id");
			instance.ProjectName = context.StringValue("GetInstance.Instance.ProjectName");
			instance.JobName = context.StringValue("GetInstance.Instance.JobName");
			instance.ActualState = context.StringValue("GetInstance.Instance.ActualState");
			instance.ExpectState = context.StringValue("GetInstance.Instance.ExpectState");
			instance.JobType = context.StringValue("GetInstance.Instance.JobType");
			instance.ApiType = context.StringValue("GetInstance.Instance.ApiType");
			instance.Code = context.StringValue("GetInstance.Instance.Code");
			instance.Properties = context.StringValue("GetInstance.Instance.Properties");
			instance.Packages = context.StringValue("GetInstance.Instance.Packages");
			instance.Starter = context.StringValue("GetInstance.Instance.Starter");
			instance.StartTime = context.LongValue("GetInstance.Instance.StartTime");
			instance.LastErrorTime = context.LongValue("GetInstance.Instance.LastErrorTime");
			instance.LastErrorMessage = context.StringValue("GetInstance.Instance.LastErrorMessage");
			instance.LastOperator = context.StringValue("GetInstance.Instance.LastOperator");
			instance.LastOperateTime = context.LongValue("GetInstance.Instance.LastOperateTime");
			instance.PlanJson = context.StringValue("GetInstance.Instance.PlanJson");
			instance.EngineVersion = context.StringValue("GetInstance.Instance.EngineVersion");
			instance.EngineJobHandler = context.StringValue("GetInstance.Instance.EngineJobHandler");
			instance.InputDelay = context.LongValue("GetInstance.Instance.InputDelay");
			instance.ClusterId = context.StringValue("GetInstance.Instance.ClusterId");
			instance.QueueName = context.StringValue("GetInstance.Instance.QueueName");
			instance.EndTime = context.LongValue("GetInstance.Instance.EndTime");
			getInstanceResponse.Instance = instance;
        
			return getInstanceResponse;
        }
    }
}
