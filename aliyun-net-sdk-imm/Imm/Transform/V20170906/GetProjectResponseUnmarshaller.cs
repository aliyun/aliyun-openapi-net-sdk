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
    public class GetProjectResponseUnmarshaller
    {
        public static GetProjectResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectResponse getProjectResponse = new GetProjectResponse();

			getProjectResponse.HttpResponse = context.HttpResponse;
			getProjectResponse.RequestId = context.StringValue("GetProject.RequestId");
			getProjectResponse.Project = context.StringValue("GetProject.Project");
			getProjectResponse.ServiceRole = context.StringValue("GetProject.ServiceRole");
			getProjectResponse.Endpoint = context.StringValue("GetProject.Endpoint");
			getProjectResponse.CreateTime = context.StringValue("GetProject.CreateTime");
			getProjectResponse.ModifyTime = context.StringValue("GetProject.ModifyTime");
			getProjectResponse.Type = context.StringValue("GetProject.Type");
			getProjectResponse.CU = context.IntegerValue("GetProject.CU");

			List<GetProjectResponse.GetProject_IndexersItem> getProjectResponse_indexers = new List<GetProjectResponse.GetProject_IndexersItem>();
			for (int i = 0; i < context.Length("GetProject.Indexers.Length"); i++) {
				GetProjectResponse.GetProject_IndexersItem indexersItem = new GetProjectResponse.GetProject_IndexersItem();
				indexersItem.Name = context.StringValue("GetProject.Indexers["+ i +"].Name");
				indexersItem.Status = context.StringValue("GetProject.Indexers["+ i +"].Status");

				getProjectResponse_indexers.Add(indexersItem);
			}
			getProjectResponse.Indexers = getProjectResponse_indexers;

			List<GetProjectResponse.GetProject_EnginesItem> getProjectResponse_engines = new List<GetProjectResponse.GetProject_EnginesItem>();
			for (int i = 0; i < context.Length("GetProject.Engines.Length"); i++) {
				GetProjectResponse.GetProject_EnginesItem enginesItem = new GetProjectResponse.GetProject_EnginesItem();
				enginesItem.Name = context.StringValue("GetProject.Engines["+ i +"].Name");
				enginesItem.JobTtl = context.LongValue("GetProject.Engines["+ i +"].JobTtl");

				getProjectResponse_engines.Add(enginesItem);
			}
			getProjectResponse.Engines = getProjectResponse_engines;
        
			return getProjectResponse;
        }
    }
}