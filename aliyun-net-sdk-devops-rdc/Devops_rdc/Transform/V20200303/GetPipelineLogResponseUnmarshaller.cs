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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class GetPipelineLogResponseUnmarshaller
    {
        public static GetPipelineLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPipelineLogResponse getPipelineLogResponse = new GetPipelineLogResponse();

			getPipelineLogResponse.HttpResponse = _ctx.HttpResponse;
			getPipelineLogResponse.RequestId = _ctx.StringValue("GetPipelineLog.RequestId");
			getPipelineLogResponse.ErrorMessage = _ctx.StringValue("GetPipelineLog.ErrorMessage");
			getPipelineLogResponse.Success = _ctx.BooleanValue("GetPipelineLog.Success");
			getPipelineLogResponse.ErrorCode = _ctx.StringValue("GetPipelineLog.ErrorCode");

			List<GetPipelineLogResponse.GetPipelineLog_Job> getPipelineLogResponse_object = new List<GetPipelineLogResponse.GetPipelineLog_Job>();
			for (int i = 0; i < _ctx.Length("GetPipelineLog.Object.Length"); i++) {
				GetPipelineLogResponse.GetPipelineLog_Job job = new GetPipelineLogResponse.GetPipelineLog_Job();
				job.ActionName = _ctx.StringValue("GetPipelineLog.Object["+ i +"].ActionName");
				job.StartTime = _ctx.StringValue("GetPipelineLog.Object["+ i +"].StartTime");
				job.JobId = _ctx.LongValue("GetPipelineLog.Object["+ i +"].JobId");

				List<GetPipelineLogResponse.GetPipelineLog_Job.GetPipelineLog_BuildProcessNode> job_buildProcessNodes = new List<GetPipelineLogResponse.GetPipelineLog_Job.GetPipelineLog_BuildProcessNode>();
				for (int j = 0; j < _ctx.Length("GetPipelineLog.Object["+ i +"].BuildProcessNodes.Length"); j++) {
					GetPipelineLogResponse.GetPipelineLog_Job.GetPipelineLog_BuildProcessNode buildProcessNode = new GetPipelineLogResponse.GetPipelineLog_Job.GetPipelineLog_BuildProcessNode();
					buildProcessNode.Status = _ctx.StringValue("GetPipelineLog.Object["+ i +"].BuildProcessNodes["+ j +"].Status");
					buildProcessNode.NodeIndex = _ctx.IntegerValue("GetPipelineLog.Object["+ i +"].BuildProcessNodes["+ j +"].NodeIndex");
					buildProcessNode.NodeName = _ctx.StringValue("GetPipelineLog.Object["+ i +"].BuildProcessNodes["+ j +"].NodeName");

					job_buildProcessNodes.Add(buildProcessNode);
				}
				job.BuildProcessNodes = job_buildProcessNodes;

				getPipelineLogResponse_object.Add(job);
			}
			getPipelineLogResponse._Object = getPipelineLogResponse_object;
        
			return getPipelineLogResponse;
        }
    }
}
