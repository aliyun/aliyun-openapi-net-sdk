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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeFlowTotalCountResponseUnmarshaller
    {
        public static DescribeFlowTotalCountResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFlowTotalCountResponse describeFlowTotalCountResponse = new DescribeFlowTotalCountResponse();

			describeFlowTotalCountResponse.HttpResponse = context.HttpResponse;
			describeFlowTotalCountResponse.RequestId = context.StringValue("DescribeFlowTotalCount.RequestId");

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount flowCount = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount();

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub dataHub = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub();

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub.DescribeFlowTotalCount_Project project = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub.DescribeFlowTotalCount_Project();
			project.TotalCount = context.LongValue("DescribeFlowTotalCount.FlowCount.DataHub.Project.TotalCount");
			project.LastCount = context.LongValue("DescribeFlowTotalCount.FlowCount.DataHub.Project.LastCount");
			dataHub.Project = project;

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub.DescribeFlowTotalCount_Topic topic = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub.DescribeFlowTotalCount_Topic();
			topic.TotalCount = context.LongValue("DescribeFlowTotalCount.FlowCount.DataHub.Topic.TotalCount");
			topic.LastCount = context.LongValue("DescribeFlowTotalCount.FlowCount.DataHub.Topic.LastCount");
			dataHub.Topic = topic;

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub.DescribeFlowTotalCount_Subscription subscription = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub.DescribeFlowTotalCount_Subscription();
			subscription.TotalCount = context.LongValue("DescribeFlowTotalCount.FlowCount.DataHub.Subscription.TotalCount");
			subscription.LastCount = context.LongValue("DescribeFlowTotalCount.FlowCount.DataHub.Subscription.LastCount");
			dataHub.Subscription = subscription;

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub.DescribeFlowTotalCount_Connector connector = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_DataHub.DescribeFlowTotalCount_Connector();
			connector.TotalCount = context.LongValue("DescribeFlowTotalCount.FlowCount.DataHub.Connector.TotalCount");
			connector.LastCount = context.LongValue("DescribeFlowTotalCount.FlowCount.DataHub.Connector.LastCount");
			dataHub.Connector = connector;
			flowCount.DataHub = dataHub;

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP cDP = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP();

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP.DescribeFlowTotalCount_InputInstanceCount inputInstanceCount = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP.DescribeFlowTotalCount_InputInstanceCount();
			inputInstanceCount.TotalCount = context.LongValue("DescribeFlowTotalCount.FlowCount.CDP.InputInstanceCount.TotalCount");
			cDP.InputInstanceCount = inputInstanceCount;

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP.DescribeFlowTotalCount_InputRecordCount inputRecordCount = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP.DescribeFlowTotalCount_InputRecordCount();
			inputRecordCount.TotalCount = context.LongValue("DescribeFlowTotalCount.FlowCount.CDP.InputRecordCount.TotalCount");
			cDP.InputRecordCount = inputRecordCount;

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP.DescribeFlowTotalCount_OutputInstanceCount outputInstanceCount = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP.DescribeFlowTotalCount_OutputInstanceCount();
			outputInstanceCount.TotalCount = context.LongValue("DescribeFlowTotalCount.FlowCount.CDP.OutputInstanceCount.TotalCount");
			cDP.OutputInstanceCount = outputInstanceCount;

			DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP.DescribeFlowTotalCount_OutputRecordCount outputRecordCount = new DescribeFlowTotalCountResponse.DescribeFlowTotalCount_FlowCount.DescribeFlowTotalCount_CDP.DescribeFlowTotalCount_OutputRecordCount();
			outputRecordCount.TotalCount = context.LongValue("DescribeFlowTotalCount.FlowCount.CDP.OutputRecordCount.TotalCount");
			cDP.OutputRecordCount = outputRecordCount;
			flowCount.CDP = cDP;
			describeFlowTotalCountResponse.FlowCount = flowCount;
        
			return describeFlowTotalCountResponse;
        }
    }
}
