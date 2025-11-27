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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListDataTasksResponseUnmarshaller
    {
        public static ListDataTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataTasksResponse listDataTasksResponse = new ListDataTasksResponse();

			listDataTasksResponse.HttpResponse = _ctx.HttpResponse;
			listDataTasksResponse.RequestId = _ctx.StringValue("ListDataTasks.RequestId");

			List<ListDataTasksResponse.ListDataTasks_ResultItem> listDataTasksResponse_result = new List<ListDataTasksResponse.ListDataTasks_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDataTasks.Result.Length"); i++) {
				ListDataTasksResponse.ListDataTasks_ResultItem resultItem = new ListDataTasksResponse.ListDataTasks_ResultItem();
				resultItem.CreateTime = _ctx.StringValue("ListDataTasks.Result["+ i +"].createTime");
				resultItem.TaskId = _ctx.StringValue("ListDataTasks.Result["+ i +"].taskId");
				resultItem.Status = _ctx.StringValue("ListDataTasks.Result["+ i +"].status");

				ListDataTasksResponse.ListDataTasks_ResultItem.ListDataTasks_SinkCluster sinkCluster = new ListDataTasksResponse.ListDataTasks_ResultItem.ListDataTasks_SinkCluster();
				sinkCluster.Index = _ctx.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.index");
				sinkCluster.Type = _ctx.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.type");
				sinkCluster.Endpoint = _ctx.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.endpoint");
				sinkCluster.VpcId = _ctx.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.vpcId");
				sinkCluster.VpcInstancePort = _ctx.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.vpcInstancePort");
				sinkCluster.VpcInstanceId = _ctx.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.vpcInstanceId");
				sinkCluster.DataSourceType = _ctx.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.dataSourceType");
				resultItem.SinkCluster = sinkCluster;

				ListDataTasksResponse.ListDataTasks_ResultItem.ListDataTasks_SourceCluster sourceCluster = new ListDataTasksResponse.ListDataTasks_ResultItem.ListDataTasks_SourceCluster();
				sourceCluster.Index = _ctx.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.index");
				sourceCluster.Settings = _ctx.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.settings");
				sourceCluster.Mapping = _ctx.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.mapping");
				sourceCluster.Type = _ctx.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.type");
				sourceCluster.Routing = _ctx.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.routing");
				sourceCluster.DataSourceType = _ctx.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.dataSourceType");
				resultItem.SourceCluster = sourceCluster;

				listDataTasksResponse_result.Add(resultItem);
			}
			listDataTasksResponse.Result = listDataTasksResponse_result;
        
			return listDataTasksResponse;
        }
    }
}
