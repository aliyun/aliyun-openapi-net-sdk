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
using Aliyun.Acs.TeslaStream.Model.V20180115;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaStream.Transform.V20180115
{
    public class GetJobTopologyResponseUnmarshaller
    {
        public static GetJobTopologyResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobTopologyResponse getJobTopologyResponse = new GetJobTopologyResponse();

			getJobTopologyResponse.HttpResponse = context.HttpResponse;
			getJobTopologyResponse.Code = context.IntegerValue("GetJobTopology.Code");
			getJobTopologyResponse.Message = context.StringValue("GetJobTopology.Message");
			getJobTopologyResponse.RequestId = context.StringValue("GetJobTopology.RequestId");

			List<GetJobTopologyResponse.GetJobTopology_Job> getJobTopologyResponse_data = new List<GetJobTopologyResponse.GetJobTopology_Job>();
			for (int i = 0; i < context.Length("GetJobTopology.Data.Length"); i++) {
				GetJobTopologyResponse.GetJobTopology_Job job = new GetJobTopologyResponse.GetJobTopology_Job();
				job.Text = context.StringValue("GetJobTopology.Data["+ i +"].Text");
				job.Type = context.StringValue("GetJobTopology.Data["+ i +"].Type");
				job.PluginRelation = context.StringValue("GetJobTopology.Data["+ i +"].PluginRelation");

				List<string> job_parents = new List<string>();
				for (int j = 0; j < context.Length("GetJobTopology.Data["+ i +"].Parents.Length"); j++) {
					job_parents.Add(context.StringValue("GetJobTopology.Data["+ i +"].Parents["+ j +"]"));
				}
				job.Parents = job_parents;

				List<string> job_childrens = new List<string>();
				for (int j = 0; j < context.Length("GetJobTopology.Data["+ i +"].Childrens.Length"); j++) {
					job_childrens.Add(context.StringValue("GetJobTopology.Data["+ i +"].Childrens["+ j +"]"));
				}
				job.Childrens = job_childrens;

				getJobTopologyResponse_data.Add(job);
			}
			getJobTopologyResponse.Data = getJobTopologyResponse_data;
        
			return getJobTopologyResponse;
        }
    }
}