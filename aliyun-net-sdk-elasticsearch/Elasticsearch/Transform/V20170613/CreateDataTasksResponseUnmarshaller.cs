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
        public static CreateDataTasksResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDataTasksResponse createDataTasksResponse = new CreateDataTasksResponse();

			createDataTasksResponse.HttpResponse = context.HttpResponse;
			createDataTasksResponse.RequestId = context.StringValue("CreateDataTasks.RequestId");

			List<CreateDataTasksResponse.CreateDataTasks_ResultItem> createDataTasksResponse_result = new List<CreateDataTasksResponse.CreateDataTasks_ResultItem>();
			for (int i = 0; i < context.Length("CreateDataTasks.Result.Length"); i++) {
				CreateDataTasksResponse.CreateDataTasks_ResultItem resultItem = new CreateDataTasksResponse.CreateDataTasks_ResultItem();

				CreateDataTasksResponse.CreateDataTasks_ResultItem.CreateDataTasks_SourceCluster sourceCluster = new CreateDataTasksResponse.CreateDataTasks_ResultItem.CreateDataTasks_SourceCluster();
				sourceCluster.DataSourceType = context.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.dataSourceType");
				sourceCluster.VpcInstancePort = context.IntegerValue("CreateDataTasks.Result["+ i +"].SourceCluster.vpcInstancePort");
				sourceCluster.VpcId = context.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.vpcId");
				sourceCluster.VpcInstanceId = context.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.vpcInstanceId");
				sourceCluster.Index = context.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.index");
				sourceCluster.Type = context.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.type");
				sourceCluster.Endpoint = context.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.endpoint");
				sourceCluster.Username = context.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.username");
				sourceCluster.Password = context.StringValue("CreateDataTasks.Result["+ i +"].SourceCluster.password");
				resultItem.SourceCluster = sourceCluster;

				CreateDataTasksResponse.CreateDataTasks_ResultItem.CreateDataTasks_SinkCluster sinkCluster = new CreateDataTasksResponse.CreateDataTasks_ResultItem.CreateDataTasks_SinkCluster();
				sinkCluster.DataSourceType = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.dataSourceType");
				sinkCluster.Index = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.index");
				sinkCluster.Type = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.type");
				sinkCluster.Settings = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.settings");
				sinkCluster.Mapping = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.mapping");
				sinkCluster.Routing = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.routing");
				sinkCluster.VpcId = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.vpcId");
				sinkCluster.VpcInstanceId = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.vpcInstanceId");
				sinkCluster.VpcInstancePort = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.vpcInstancePort");
				sinkCluster.Username = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.username");
				sinkCluster.Password = context.StringValue("CreateDataTasks.Result["+ i +"].SinkCluster.password");
				resultItem.SinkCluster = sinkCluster;

				createDataTasksResponse_result.Add(resultItem);
			}
			createDataTasksResponse.Result = createDataTasksResponse_result;
        
			return createDataTasksResponse;
        }
    }
}
