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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetFaceJobResponseUnmarshaller
    {
        public static GetFaceJobResponse Unmarshall(UnmarshallerContext context)
        {
			GetFaceJobResponse getFaceJobResponse = new GetFaceJobResponse();

			getFaceJobResponse.HttpResponse = context.HttpResponse;
			getFaceJobResponse.RequestId = context.StringValue("GetFaceJob.RequestId");
			getFaceJobResponse.JobId = context.StringValue("GetFaceJob.JobId");
			getFaceJobResponse.SetId = context.StringValue("GetFaceJob.SetId");
			getFaceJobResponse.SrcUri = context.StringValue("GetFaceJob.SrcUri");
			getFaceJobResponse.Status = context.StringValue("GetFaceJob.Status");
			getFaceJobResponse.Percent = context.IntegerValue("GetFaceJob.Percent");
			getFaceJobResponse.CreateTime = context.StringValue("GetFaceJob.CreateTime");
			getFaceJobResponse.FinishTime = context.StringValue("GetFaceJob.FinishTime");
        
			return getFaceJobResponse;
        }
    }
}