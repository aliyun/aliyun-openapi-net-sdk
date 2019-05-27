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
    public class GetDocIndexTaskResponseUnmarshaller
    {
        public static GetDocIndexTaskResponse Unmarshall(UnmarshallerContext context)
        {
			GetDocIndexTaskResponse getDocIndexTaskResponse = new GetDocIndexTaskResponse();

			getDocIndexTaskResponse.HttpResponse = context.HttpResponse;
			getDocIndexTaskResponse.RequestId = context.StringValue("GetDocIndexTask.RequestId");
			getDocIndexTaskResponse.Status = context.StringValue("GetDocIndexTask.Status");
			getDocIndexTaskResponse.TaskId = context.StringValue("GetDocIndexTask.TaskId");
			getDocIndexTaskResponse.CreateTime = context.StringValue("GetDocIndexTask.CreateTime");
			getDocIndexTaskResponse.FinishTime = context.StringValue("GetDocIndexTask.FinishTime");

			GetDocIndexTaskResponse.GetDocIndexTask_FailDetail failDetail = new GetDocIndexTaskResponse.GetDocIndexTask_FailDetail();
			failDetail.Code = context.StringValue("GetDocIndexTask.FailDetail.Code");
			getDocIndexTaskResponse.FailDetail = failDetail;
        
			return getDocIndexTaskResponse;
        }
    }
}
