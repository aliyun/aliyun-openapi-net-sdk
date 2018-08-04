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
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitImageQualityJobResponseUnmarshaller
    {
        public static SubmitImageQualityJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitImageQualityJobResponse submitImageQualityJobResponse = new SubmitImageQualityJobResponse();

			submitImageQualityJobResponse.HttpResponse = context.HttpResponse;
			submitImageQualityJobResponse.RequestId = context.StringValue("SubmitImageQualityJob.RequestId");

			SubmitImageQualityJobResponse.SubmitImageQualityJob_ImageQualityJob imageQualityJob = new SubmitImageQualityJobResponse.SubmitImageQualityJob_ImageQualityJob();
			imageQualityJob.JobId = context.StringValue("SubmitImageQualityJob.ImageQualityJob.JobId");
			imageQualityJob.UserData = context.StringValue("SubmitImageQualityJob.ImageQualityJob.UserData");
			imageQualityJob.PipelineId = context.StringValue("SubmitImageQualityJob.ImageQualityJob.PipelineId");
			imageQualityJob.State = context.StringValue("SubmitImageQualityJob.ImageQualityJob.State");
			imageQualityJob.CreationTime = context.StringValue("SubmitImageQualityJob.ImageQualityJob.CreationTime");

			SubmitImageQualityJobResponse.SubmitImageQualityJob_ImageQualityJob.SubmitImageQualityJob_Input input = new SubmitImageQualityJobResponse.SubmitImageQualityJob_ImageQualityJob.SubmitImageQualityJob_Input();
			input.Bucket = context.StringValue("SubmitImageQualityJob.ImageQualityJob.Input.Bucket");
			input.Location = context.StringValue("SubmitImageQualityJob.ImageQualityJob.Input.Location");
			input._Object = context.StringValue("SubmitImageQualityJob.ImageQualityJob.Input.Object");
			input.Url = context.StringValue("SubmitImageQualityJob.ImageQualityJob.Input.Url");
			imageQualityJob.Input = input;

			SubmitImageQualityJobResponse.SubmitImageQualityJob_ImageQualityJob.SubmitImageQualityJob_Result result = new SubmitImageQualityJobResponse.SubmitImageQualityJob_ImageQualityJob.SubmitImageQualityJob_Result();
			result.Code = context.StringValue("SubmitImageQualityJob.ImageQualityJob.Result.Code");
			result.Message = context.StringValue("SubmitImageQualityJob.ImageQualityJob.Result.Message");
			result.Score = context.StringValue("SubmitImageQualityJob.ImageQualityJob.Result.Score");
			imageQualityJob.Result = result;
			submitImageQualityJobResponse.ImageQualityJob = imageQualityJob;
        
			return submitImageQualityJobResponse;
        }
    }
}