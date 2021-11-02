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
    public class ListInstanceResponseUnmarshaller
    {
        public static ListInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceResponse listInstanceResponse = new ListInstanceResponse();

			listInstanceResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceResponse.RequestId = _ctx.StringValue("ListInstance.RequestId");
			listInstanceResponse.PageIndex = _ctx.IntegerValue("ListInstance.PageIndex");
			listInstanceResponse.PageSize = _ctx.IntegerValue("ListInstance.PageSize");
			listInstanceResponse.TotalPage = _ctx.IntegerValue("ListInstance.TotalPage");
			listInstanceResponse.TotalCount = _ctx.LongValue("ListInstance.TotalCount");

			List<ListInstanceResponse.ListInstance_Instance> listInstanceResponse_instances = new List<ListInstanceResponse.ListInstance_Instance>();
			for (int i = 0; i < _ctx.Length("ListInstance.Instances.Length"); i++) {
				ListInstanceResponse.ListInstance_Instance instance = new ListInstanceResponse.ListInstance_Instance();
				instance.Id = _ctx.LongValue("ListInstance.Instances["+ i +"].Id");
				instance.ProjectName = _ctx.StringValue("ListInstance.Instances["+ i +"].ProjectName");
				instance.JobName = _ctx.StringValue("ListInstance.Instances["+ i +"].JobName");
				instance.ActualState = _ctx.StringValue("ListInstance.Instances["+ i +"].ActualState");
				instance.ExpectState = _ctx.StringValue("ListInstance.Instances["+ i +"].ExpectState");
				instance.JobType = _ctx.StringValue("ListInstance.Instances["+ i +"].JobType");
				instance.ApiType = _ctx.StringValue("ListInstance.Instances["+ i +"].ApiType");
				instance.Code = _ctx.StringValue("ListInstance.Instances["+ i +"].Code");
				instance.Properties = _ctx.StringValue("ListInstance.Instances["+ i +"].Properties");
				instance.Packages = _ctx.StringValue("ListInstance.Instances["+ i +"].Packages");
				instance.Starter = _ctx.StringValue("ListInstance.Instances["+ i +"].Starter");
				instance.StartTime = _ctx.LongValue("ListInstance.Instances["+ i +"].StartTime");
				instance.LastErrorTime = _ctx.LongValue("ListInstance.Instances["+ i +"].LastErrorTime");
				instance.LastErrorMessage = _ctx.StringValue("ListInstance.Instances["+ i +"].LastErrorMessage");
				instance.LastOperator = _ctx.StringValue("ListInstance.Instances["+ i +"].LastOperator");
				instance.LastOperateTime = _ctx.LongValue("ListInstance.Instances["+ i +"].LastOperateTime");
				instance.PlanJson = _ctx.StringValue("ListInstance.Instances["+ i +"].PlanJson");
				instance.EngineVersion = _ctx.StringValue("ListInstance.Instances["+ i +"].EngineVersion");
				instance.EngineJobHandler = _ctx.StringValue("ListInstance.Instances["+ i +"].EngineJobHandler");
				instance.InputDelay = _ctx.LongValue("ListInstance.Instances["+ i +"].InputDelay");
				instance.ClusterId = _ctx.StringValue("ListInstance.Instances["+ i +"].ClusterId");
				instance.QueueName = _ctx.StringValue("ListInstance.Instances["+ i +"].QueueName");
				instance.EndTime = _ctx.LongValue("ListInstance.Instances["+ i +"].EndTime");
				instance.Priority = _ctx.IntegerValue("ListInstance.Instances["+ i +"].Priority");

				listInstanceResponse_instances.Add(instance);
			}
			listInstanceResponse.Instances = listInstanceResponse_instances;
        
			return listInstanceResponse;
        }
    }
}
