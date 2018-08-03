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
    public class CreateFaceJobResponseUnmarshaller
    {
        public static CreateFaceJobResponse Unmarshall(UnmarshallerContext context)
        {
			CreateFaceJobResponse createFaceJobResponse = new CreateFaceJobResponse();

			createFaceJobResponse.HttpResponse = context.HttpResponse;
			createFaceJobResponse.RequestId = context.StringValue("CreateFaceJob.RequestId");
			createFaceJobResponse.JobId = context.StringValue("CreateFaceJob.JobId");
			createFaceJobResponse.SetId = context.StringValue("CreateFaceJob.SetId");
			createFaceJobResponse.SrcUri = context.StringValue("CreateFaceJob.SrcUri");
			createFaceJobResponse.Percent = context.IntegerValue("CreateFaceJob.Percent");
			createFaceJobResponse.CreateTime = context.StringValue("CreateFaceJob.CreateTime");
			createFaceJobResponse.FinishTime = context.StringValue("CreateFaceJob.FinishTime");
			createFaceJobResponse.Status = context.StringValue("CreateFaceJob.Status");
        
			return createFaceJobResponse;
        }
    }
}