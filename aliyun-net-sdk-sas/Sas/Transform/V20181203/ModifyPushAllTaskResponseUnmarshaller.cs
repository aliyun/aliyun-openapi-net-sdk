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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class ModifyPushAllTaskResponseUnmarshaller
    {
        public static ModifyPushAllTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyPushAllTaskResponse modifyPushAllTaskResponse = new ModifyPushAllTaskResponse();

			modifyPushAllTaskResponse.HttpResponse = _ctx.HttpResponse;
			modifyPushAllTaskResponse.RequestId = _ctx.StringValue("ModifyPushAllTask.RequestId");

			ModifyPushAllTaskResponse.ModifyPushAllTask_PushTaskRsp pushTaskRsp = new ModifyPushAllTaskResponse.ModifyPushAllTask_PushTaskRsp();

			List<ModifyPushAllTaskResponse.ModifyPushAllTask_PushTaskRsp.ModifyPushAllTask_PushTaskResult> pushTaskRsp_pushTaskResultList = new List<ModifyPushAllTaskResponse.ModifyPushAllTask_PushTaskRsp.ModifyPushAllTask_PushTaskResult>();
			for (int i = 0; i < _ctx.Length("ModifyPushAllTask.PushTaskRsp.PushTaskResultList.Length"); i++) {
				ModifyPushAllTaskResponse.ModifyPushAllTask_PushTaskRsp.ModifyPushAllTask_PushTaskResult pushTaskResult = new ModifyPushAllTaskResponse.ModifyPushAllTask_PushTaskRsp.ModifyPushAllTask_PushTaskResult();
				pushTaskResult.InstanceId = _ctx.StringValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].InstanceId");
				pushTaskResult.OsVersion = _ctx.StringValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].OsVersion");
				pushTaskResult.InstanceName = _ctx.StringValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].InstanceName");
				pushTaskResult.Success = _ctx.BooleanValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].Success");
				pushTaskResult.GroupId = _ctx.LongValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].GroupId");
				pushTaskResult.Ip = _ctx.StringValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].Ip");
				pushTaskResult.Online = _ctx.BooleanValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].Online");
				pushTaskResult.Message = _ctx.StringValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].Message");
				pushTaskResult.Region = _ctx.StringValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].Region");
				pushTaskResult.Uuid = _ctx.StringValue("ModifyPushAllTask.PushTaskRsp.PushTaskResultList["+ i +"].Uuid");

				pushTaskRsp_pushTaskResultList.Add(pushTaskResult);
			}
			pushTaskRsp.PushTaskResultList = pushTaskRsp_pushTaskResultList;
			modifyPushAllTaskResponse.PushTaskRsp = pushTaskRsp;
        
			return modifyPushAllTaskResponse;
        }
    }
}
