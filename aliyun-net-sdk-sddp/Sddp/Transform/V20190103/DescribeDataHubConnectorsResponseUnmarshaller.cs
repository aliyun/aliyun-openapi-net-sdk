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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDataHubConnectorsResponseUnmarshaller
    {
        public static DescribeDataHubConnectorsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataHubConnectorsResponse describeDataHubConnectorsResponse = new DescribeDataHubConnectorsResponse();

			describeDataHubConnectorsResponse.HttpResponse = context.HttpResponse;
			describeDataHubConnectorsResponse.RequestId = context.StringValue("DescribeDataHubConnectors.RequestId");
			describeDataHubConnectorsResponse.PageSize = context.IntegerValue("DescribeDataHubConnectors.PageSize");
			describeDataHubConnectorsResponse.CurrentPage = context.IntegerValue("DescribeDataHubConnectors.CurrentPage");
			describeDataHubConnectorsResponse.TotalCount = context.IntegerValue("DescribeDataHubConnectors.TotalCount");

			List<DescribeDataHubConnectorsResponse.DescribeDataHubConnectors_Connector> describeDataHubConnectorsResponse_items = new List<DescribeDataHubConnectorsResponse.DescribeDataHubConnectors_Connector>();
			for (int i = 0; i < context.Length("DescribeDataHubConnectors.Items.Length"); i++) {
				DescribeDataHubConnectorsResponse.DescribeDataHubConnectors_Connector connector = new DescribeDataHubConnectorsResponse.DescribeDataHubConnectors_Connector();
				connector.Id = context.LongValue("DescribeDataHubConnectors.Items["+ i +"].Id");
				connector.Name = context.StringValue("DescribeDataHubConnectors.Items["+ i +"].Name");
				connector.Description = context.StringValue("DescribeDataHubConnectors.Items["+ i +"].Description");
				connector.CreationTime = context.LongValue("DescribeDataHubConnectors.Items["+ i +"].CreationTime");
				connector.ConnectorProduct = context.StringValue("DescribeDataHubConnectors.Items["+ i +"].ConnectorProduct");
				connector.ConnectorPath = context.StringValue("DescribeDataHubConnectors.Items["+ i +"].ConnectorPath");
				connector.RiskLevelId = context.LongValue("DescribeDataHubConnectors.Items["+ i +"].RiskLevelId");
				connector.RiskLevelName = context.StringValue("DescribeDataHubConnectors.Items["+ i +"].RiskLevelName");
				connector.UserId = context.LongValue("DescribeDataHubConnectors.Items["+ i +"].UserId");
				connector.LoginName = context.StringValue("DescribeDataHubConnectors.Items["+ i +"].LoginName");
				connector.DisplayName = context.StringValue("DescribeDataHubConnectors.Items["+ i +"].DisplayName");

				describeDataHubConnectorsResponse_items.Add(connector);
			}
			describeDataHubConnectorsResponse.Items = describeDataHubConnectorsResponse_items;
        
			return describeDataHubConnectorsResponse;
        }
    }
}
