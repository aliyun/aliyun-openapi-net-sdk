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
    public class ValidateJobResponseUnmarshaller
    {
        public static ValidateJobResponse Unmarshall(UnmarshallerContext context)
        {
			ValidateJobResponse validateJobResponse = new ValidateJobResponse();

			validateJobResponse.HttpResponse = context.HttpResponse;
			validateJobResponse.RequestId = context.StringValue("ValidateJob.RequestId");

			ValidateJobResponse.ValidateJob_JobInOut jobInOut = new ValidateJobResponse.ValidateJob_JobInOut();

			List<ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Input> jobInOut_inputs = new List<ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Input>();
			for (int i = 0; i < context.Length("ValidateJob.JobInOut.Inputs.Length"); i++) {
				ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Input input = new ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Input();
				input.Type = context.StringValue("ValidateJob.JobInOut.Inputs["+ i +"].Type");
				input.Workspace = context.StringValue("ValidateJob.JobInOut.Inputs["+ i +"].Workspace");
				input.Name = context.StringValue("ValidateJob.JobInOut.Inputs["+ i +"].Name");
				input.Properties = context.StringValue("ValidateJob.JobInOut.Inputs["+ i +"].Properties");
				input.Alias = context.StringValue("ValidateJob.JobInOut.Inputs["+ i +"].Alias");

				jobInOut_inputs.Add(input);
			}
			jobInOut.Inputs = jobInOut_inputs;

			List<ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Output> jobInOut_outputs = new List<ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Output>();
			for (int i = 0; i < context.Length("ValidateJob.JobInOut.Outputs.Length"); i++) {
				ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Output output = new ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Output();
				output.Type = context.StringValue("ValidateJob.JobInOut.Outputs["+ i +"].Type");
				output.Workspace = context.StringValue("ValidateJob.JobInOut.Outputs["+ i +"].Workspace");
				output.Name = context.StringValue("ValidateJob.JobInOut.Outputs["+ i +"].Name");
				output.Properties = context.StringValue("ValidateJob.JobInOut.Outputs["+ i +"].Properties");
				output.Alias = context.StringValue("ValidateJob.JobInOut.Outputs["+ i +"].Alias");

				jobInOut_outputs.Add(output);
			}
			jobInOut.Outputs = jobInOut_outputs;

			List<ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Dim> jobInOut_dims = new List<ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Dim>();
			for (int i = 0; i < context.Length("ValidateJob.JobInOut.Dims.Length"); i++) {
				ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Dim dim = new ValidateJobResponse.ValidateJob_JobInOut.ValidateJob_Dim();
				dim.Type = context.StringValue("ValidateJob.JobInOut.Dims["+ i +"].Type");
				dim.Workspace = context.StringValue("ValidateJob.JobInOut.Dims["+ i +"].Workspace");
				dim.Name = context.StringValue("ValidateJob.JobInOut.Dims["+ i +"].Name");
				dim.Properties = context.StringValue("ValidateJob.JobInOut.Dims["+ i +"].Properties");
				dim.Alias = context.StringValue("ValidateJob.JobInOut.Dims["+ i +"].Alias");

				jobInOut_dims.Add(dim);
			}
			jobInOut.Dims = jobInOut_dims;
			validateJobResponse.JobInOut = jobInOut;
        
			return validateJobResponse;
        }
    }
}
