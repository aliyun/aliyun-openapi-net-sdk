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
    public class PublicCreateImageScanTaskResponseUnmarshaller
    {
        public static PublicCreateImageScanTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PublicCreateImageScanTaskResponse publicCreateImageScanTaskResponse = new PublicCreateImageScanTaskResponse();

			publicCreateImageScanTaskResponse.HttpResponse = _ctx.HttpResponse;
			publicCreateImageScanTaskResponse.RequestId = _ctx.StringValue("PublicCreateImageScanTask.RequestId");

			PublicCreateImageScanTaskResponse.PublicCreateImageScanTask_Data data = new PublicCreateImageScanTaskResponse.PublicCreateImageScanTask_Data();
			data.TaskId = _ctx.StringValue("PublicCreateImageScanTask.Data.TaskId");
			data.TotalCount = _ctx.IntegerValue("PublicCreateImageScanTask.Data.TotalCount");
			data.FinishCount = _ctx.IntegerValue("PublicCreateImageScanTask.Data.FinishCount");
			data.CollectTime = _ctx.LongValue("PublicCreateImageScanTask.Data.CollectTime");
			data.ExecTime = _ctx.LongValue("PublicCreateImageScanTask.Data.ExecTime");
			data.Status = _ctx.StringValue("PublicCreateImageScanTask.Data.Status");
			data.Progress = _ctx.IntegerValue("PublicCreateImageScanTask.Data.Progress");
			data.Result = _ctx.StringValue("PublicCreateImageScanTask.Data.Result");
			data.CanCreate = _ctx.BooleanValue("PublicCreateImageScanTask.Data.CanCreate");
			publicCreateImageScanTaskResponse.Data = data;
        
			return publicCreateImageScanTaskResponse;
        }
    }
}
