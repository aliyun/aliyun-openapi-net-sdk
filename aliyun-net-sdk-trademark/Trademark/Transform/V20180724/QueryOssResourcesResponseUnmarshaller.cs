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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryOssResourcesResponseUnmarshaller
    {
        public static QueryOssResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOssResourcesResponse queryOssResourcesResponse = new QueryOssResourcesResponse();

			queryOssResourcesResponse.HttpResponse = context.HttpResponse;
			queryOssResourcesResponse.RequestId = context.StringValue("QueryOssResources.RequestId");

			List<QueryOssResourcesResponse.QueryOssResources_TaskList> queryOssResourcesResponse_data = new List<QueryOssResourcesResponse.QueryOssResources_TaskList>();
			for (int i = 0; i < context.Length("QueryOssResources.Data.Length"); i++) {
				QueryOssResourcesResponse.QueryOssResources_TaskList taskList = new QueryOssResourcesResponse.QueryOssResources_TaskList();
				taskList.BizId = context.StringValue("QueryOssResources.Data["+ i +"].BizId");
				taskList.Name = context.StringValue("QueryOssResources.Data["+ i +"].Name");
				taskList.OssUrl = context.StringValue("QueryOssResources.Data["+ i +"].OssUrl");
				taskList.UpdateTime = context.LongValue("QueryOssResources.Data["+ i +"].UpdateTime");
				taskList.CreateTime = context.LongValue("QueryOssResources.Data["+ i +"].CreateTime");

				queryOssResourcesResponse_data.Add(taskList);
			}
			queryOssResourcesResponse.Data = queryOssResourcesResponse_data;
        
			return queryOssResourcesResponse;
        }
    }
}
