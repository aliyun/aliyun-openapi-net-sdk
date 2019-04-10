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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class QueryTaskByParamResponseUnmarshaller
    {
        public static QueryTaskByParamResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTaskByParamResponse queryTaskByParamResponse = new QueryTaskByParamResponse();

			queryTaskByParamResponse.HttpResponse = context.HttpResponse;
			queryTaskByParamResponse.RequestId = context.StringValue("QueryTaskByParam.RequestId");
			queryTaskByParamResponse.TotalCount = context.IntegerValue("QueryTaskByParam.TotalCount");
			queryTaskByParamResponse.PageNumber = context.IntegerValue("QueryTaskByParam.PageNumber");
			queryTaskByParamResponse.PageSize = context.IntegerValue("QueryTaskByParam.PageSize");

			List<QueryTaskByParamResponse.QueryTaskByParam_Task> queryTaskByParamResponse_data = new List<QueryTaskByParamResponse.QueryTaskByParam_Task>();
			for (int i = 0; i < context.Length("QueryTaskByParam.Data.Length"); i++) {
				QueryTaskByParamResponse.QueryTaskByParam_Task task = new QueryTaskByParamResponse.QueryTaskByParam_Task();
				task.TaskId = context.StringValue("QueryTaskByParam.Data["+ i +"].TaskId");
				task.ReceiversName = context.StringValue("QueryTaskByParam.Data["+ i +"].ReceiversName");
				task.TemplateName = context.StringValue("QueryTaskByParam.Data["+ i +"].TemplateName");
				task.TaskStatus = context.StringValue("QueryTaskByParam.Data["+ i +"].TaskStatus");
				task.CreateTime = context.StringValue("QueryTaskByParam.Data["+ i +"].CreateTime");
				task.UtcCreateTime = context.LongValue("QueryTaskByParam.Data["+ i +"].UtcCreateTime");
				task.AddressType = context.StringValue("QueryTaskByParam.Data["+ i +"].AddressType");
				task.TagName = context.StringValue("QueryTaskByParam.Data["+ i +"].TagName");
				task.RequestCount = context.StringValue("QueryTaskByParam.Data["+ i +"].RequestCount");

				queryTaskByParamResponse_data.Add(task);
			}
			queryTaskByParamResponse.Data = queryTaskByParamResponse_data;
        
			return queryTaskByParamResponse;
        }
    }
}
