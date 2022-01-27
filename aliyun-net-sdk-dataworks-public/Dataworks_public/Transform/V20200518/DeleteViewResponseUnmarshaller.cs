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
    public class DeleteViewResponseUnmarshaller
    {
        public static DeleteViewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteViewResponse deleteViewResponse = new DeleteViewResponse();

			deleteViewResponse.HttpResponse = _ctx.HttpResponse;
			deleteViewResponse.RequestId = _ctx.StringValue("DeleteView.RequestId");

			DeleteViewResponse.DeleteView_TaskInfo taskInfo = new DeleteViewResponse.DeleteView_TaskInfo();
			taskInfo.TaskId = _ctx.StringValue("DeleteView.TaskInfo.TaskId");
			taskInfo.Content = _ctx.StringValue("DeleteView.TaskInfo.Content");
			taskInfo.Status = _ctx.StringValue("DeleteView.TaskInfo.Status");
			taskInfo.NextTaskId = _ctx.StringValue("DeleteView.TaskInfo.NextTaskId");
			deleteViewResponse.TaskInfo = taskInfo;
        
			return deleteViewResponse;
        }
    }
}
