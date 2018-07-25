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
    public class PutProjectResponseUnmarshaller
    {
        public static PutProjectResponse Unmarshall(UnmarshallerContext context)
        {
			PutProjectResponse putProjectResponse = new PutProjectResponse();

			putProjectResponse.HttpResponse = context.HttpResponse;
			putProjectResponse.RequestId = context.StringValue("PutProject.RequestId");
			putProjectResponse.Project = context.StringValue("PutProject.Project");
			putProjectResponse.CreateTime = context.StringValue("PutProject.CreateTime");
			putProjectResponse.ModifyTime = context.StringValue("PutProject.ModifyTime");
			putProjectResponse.ServiceRole = context.StringValue("PutProject.ServiceRole");
			putProjectResponse.CU = context.IntegerValue("PutProject.CU");
			putProjectResponse.Type = context.StringValue("PutProject.Type");

			List<PutProjectResponse.PutProject_EnginesItem> putProjectResponse_engines = new List<PutProjectResponse.PutProject_EnginesItem>();
			for (int i = 0; i < context.Length("PutProject.Engines.Length"); i++) {
				PutProjectResponse.PutProject_EnginesItem enginesItem = new PutProjectResponse.PutProject_EnginesItem();
				enginesItem.Name = context.StringValue("PutProject.Engines["+ i +"].Name");
				enginesItem.JobTtl = context.LongValue("PutProject.Engines["+ i +"].JobTtl");

				putProjectResponse_engines.Add(enginesItem);
			}
			putProjectResponse.Engines = putProjectResponse_engines;

			List<PutProjectResponse.PutProject_IndexersItem> putProjectResponse_indexers = new List<PutProjectResponse.PutProject_IndexersItem>();
			for (int i = 0; i < context.Length("PutProject.Indexers.Length"); i++) {
				PutProjectResponse.PutProject_IndexersItem indexersItem = new PutProjectResponse.PutProject_IndexersItem();
				indexersItem.Name = context.StringValue("PutProject.Indexers["+ i +"].Name");
				indexersItem.Status = context.StringValue("PutProject.Indexers["+ i +"].Status");

				putProjectResponse_indexers.Add(indexersItem);
			}
			putProjectResponse.Indexers = putProjectResponse_indexers;
        
			return putProjectResponse;
        }
    }
}