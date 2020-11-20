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
    public class CreateDataTasksResponseUnmarshaller
    {
        public static CreateDataTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDataTasksResponse createDataTasksResponse = new CreateDataTasksResponse();

			createDataTasksResponse.HttpResponse = _ctx.HttpResponse;
			createDataTasksResponse.RequestId = _ctx.StringValue("CreateDataTasks.RequestId");

			List<CreateDataTasksResponse.CreateDataTasks_ResultItem> createDataTasksResponse_result = new List<CreateDataTasksResponse.CreateDataTasks_ResultItem>();
			for (int i = 0; i < _ctx.Length("CreateDataTasks.Result.Length"); i++) {
				CreateDataTasksResponse.CreateDataTasks_ResultItem resultItem = new CreateDataTasksResponse.CreateDataTasks_ResultItem();

				CreateDataTasksResponse.CreateDataTasks_ResultItem.CreateDataTasks_SourceCluster sourceCluster = new CreateDataTasksResponse.CreateDataTasks_ResultItem.CreateDataTasks_SourceCluster();
				sourceCluster.DataSourceType = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.dataSourceType");
				sourceCluster.VpcInstancePort = _ctx.IntegerValue("CreateDataTasks.Result["+ i +"].SourceCluster.vpcInstancePort");
				sourceCluster.VpcId = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.vpcId");
				sourceCluster.VpcInstanceId = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.vpcInstanceId");
				sourceCluster.Index = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.index");
				sourceCluster.Type = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.type");
				sourceCluster.Endpoint = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.endpoint");
				sourceCluster.Username = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.username");
				sourceCluster.Password = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.password");
				resultItem.SourceCluster = sourceCluster;

				CreateDataTasksResponse.CreateDataTasks_ResultItem.CreateDataTasks_SinkCluster sinkCluster = new CreateDataTasksResponse.CreateDataTasks_ResultItem.CreateDataTasks_SinkCluster();
				sinkCluster.DataSourceType = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.dataSourceType");
				sinkCluster.Index = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.index");
				sinkCluster.Type = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.type");
				sinkCluster.Settings = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.settings");
				sinkCluster.Mapping = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.mapping");
				sinkCluster.Routing = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.routing");
				sinkCluster.VpcId = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.vpcId");
				sinkCluster.VpcInstanceId = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.vpcInstanceId");
				sinkCluster.VpcInstancePort = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.vpcInstancePort");
				sinkCluster.Username = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.username");
				sinkCluster.Password = _ctx.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.password");
				resultItem.SinkCluster = sinkCluster;

				createDataTasksResponse_result.Add(resultItem);
			}
			createDataTasksResponse.Result = createDataTasksResponse_result;
        
			return createDataTasksResponse;
        }
    }
}
