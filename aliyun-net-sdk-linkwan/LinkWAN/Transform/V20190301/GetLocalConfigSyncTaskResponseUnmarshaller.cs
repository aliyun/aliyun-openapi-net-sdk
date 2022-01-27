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
    public class GetLocalConfigSyncTaskResponseUnmarshaller
    {
        public static GetLocalConfigSyncTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLocalConfigSyncTaskResponse getLocalConfigSyncTaskResponse = new GetLocalConfigSyncTaskResponse();

			getLocalConfigSyncTaskResponse.HttpResponse = _ctx.HttpResponse;
			getLocalConfigSyncTaskResponse.RequestId = _ctx.StringValue("GetLocalConfigSyncTask.RequestId");
			getLocalConfigSyncTaskResponse.Success = _ctx.BooleanValue("GetLocalConfigSyncTask.Success");
			getLocalConfigSyncTaskResponse.Code = _ctx.StringValue("GetLocalConfigSyncTask.Code");
			getLocalConfigSyncTaskResponse.ErrorMessage = _ctx.StringValue("GetLocalConfigSyncTask.ErrorMessage");

			GetLocalConfigSyncTaskResponse.GetLocalConfigSyncTask_Data data = new GetLocalConfigSyncTaskResponse.GetLocalConfigSyncTask_Data();
			data.Id = _ctx.LongValue("GetLocalConfigSyncTask.Data.Id");
			data.CreateMillis = _ctx.LongValue("GetLocalConfigSyncTask.Data.CreateMillis");
			data.ModifiedMillis = _ctx.LongValue("GetLocalConfigSyncTask.Data.ModifiedMillis");
			data.DevType = _ctx.StringValue("GetLocalConfigSyncTask.Data.DevType");
			data.TaskTYpe = _ctx.StringValue("GetLocalConfigSyncTask.Data.TaskTYpe");
			data.Eui = _ctx.StringValue("GetLocalConfigSyncTask.Data.Eui");
			data.State = _ctx.StringValue("GetLocalConfigSyncTask.Data.State");
			data.D2dAddr = _ctx.StringValue("GetLocalConfigSyncTask.Data.D2dAddr");
			data.D2dKey = _ctx.StringValue("GetLocalConfigSyncTask.Data.D2dKey");
			data.Freq = _ctx.IntegerValue("GetLocalConfigSyncTask.Data.Freq");
			data.Datr = _ctx.IntegerValue("GetLocalConfigSyncTask.Data.Datr");
			data.ProcessingMillis = _ctx.LongValue("GetLocalConfigSyncTask.Data.ProcessingMillis");
			getLocalConfigSyncTaskResponse.Data = data;
        
			return getLocalConfigSyncTaskResponse;
        }
    }
}
