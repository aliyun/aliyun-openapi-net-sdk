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
        public static ListInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstanceResponse listInstanceResponse = new ListInstanceResponse();

			listInstanceResponse.HttpResponse = context.HttpResponse;
			listInstanceResponse.RequestId = context.StringValue("ListInstance.RequestId");
			listInstanceResponse.PageIndex = context.IntegerValue("ListInstance.PageIndex");
			listInstanceResponse.PageSize = context.IntegerValue("ListInstance.PageSize");
			listInstanceResponse.TotalPage = context.IntegerValue("ListInstance.TotalPage");
			listInstanceResponse.TotalCount = context.LongValue("ListInstance.TotalCount");

			List<ListInstanceResponse.ListInstance_Instance> listInstanceResponse_instances = new List<ListInstanceResponse.ListInstance_Instance>();
			for (int i = 0; i < context.Length("ListInstance.Instances.Length"); i++) {
				ListInstanceResponse.ListInstance_Instance instance = new ListInstanceResponse.ListInstance_Instance();
				instance.Id = context.LongValue("ListInstance.Instances["+ i +"].Id");
				instance.ProjectName = context.StringValue("ListInstance.Instances["+ i +"].ProjectName");
				instance.JobName = context.StringValue("ListInstance.Instances["+ i +"].JobName");
				instance.ActualState = context.StringValue("ListInstance.Instances["+ i +"].ActualState");
				instance.ExpectState = context.StringValue("ListInstance.Instances["+ i +"].ExpectState");
				instance.JobType = context.StringValue("ListInstance.Instances["+ i +"].JobType");
				instance.ApiType = context.StringValue("ListInstance.Instances["+ i +"].ApiType");
				instance.Code = context.StringValue("ListInstance.Instances["+ i +"].Code");
				instance.Properties = context.StringValue("ListInstance.Instances["+ i +"].Properties");
				instance.Packages = context.StringValue("ListInstance.Instances["+ i +"].Packages");
				instance.Starter = context.StringValue("ListInstance.Instances["+ i +"].Starter");
				instance.StartTime = context.LongValue("ListInstance.Instances["+ i +"].StartTime");
				instance.LastErrorTime = context.LongValue("ListInstance.Instances["+ i +"].LastErrorTime");
				instance.LastErrorMessage = context.StringValue("ListInstance.Instances["+ i +"].LastErrorMessage");
				instance.LastOperator = context.StringValue("ListInstance.Instances["+ i +"].LastOperator");
				instance.LastOperateTime = context.LongValue("ListInstance.Instances["+ i +"].LastOperateTime");
				instance.PlanJson = context.StringValue("ListInstance.Instances["+ i +"].PlanJson");
				instance.EngineVersion = context.StringValue("ListInstance.Instances["+ i +"].EngineVersion");
				instance.EngineJobHandler = context.StringValue("ListInstance.Instances["+ i +"].EngineJobHandler");
				instance.InputDelay = context.LongValue("ListInstance.Instances["+ i +"].InputDelay");
				instance.ClusterId = context.StringValue("ListInstance.Instances["+ i +"].ClusterId");
				instance.QueueName = context.StringValue("ListInstance.Instances["+ i +"].QueueName");
				instance.EndTime = context.LongValue("ListInstance.Instances["+ i +"].EndTime");

				listInstanceResponse_instances.Add(instance);
			}
			listInstanceResponse.Instances = listInstanceResponse_instances;
        
			return listInstanceResponse;
        }
    }
}
