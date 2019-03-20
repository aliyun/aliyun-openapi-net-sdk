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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeGtmMonitorConfigResponseUnmarshaller
    {
        public static DescribeGtmMonitorConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmMonitorConfigResponse describeGtmMonitorConfigResponse = new DescribeGtmMonitorConfigResponse();

			describeGtmMonitorConfigResponse.HttpResponse = context.HttpResponse;
			describeGtmMonitorConfigResponse.RequestId = context.StringValue("DescribeGtmMonitorConfig.RequestId");
			describeGtmMonitorConfigResponse.MonitorConfigId = context.StringValue("DescribeGtmMonitorConfig.MonitorConfigId");
			describeGtmMonitorConfigResponse.CreateTime = context.StringValue("DescribeGtmMonitorConfig.CreateTime");
			describeGtmMonitorConfigResponse.CreateTimestamp = context.LongValue("DescribeGtmMonitorConfig.CreateTimestamp");
			describeGtmMonitorConfigResponse.UpdateTime = context.StringValue("DescribeGtmMonitorConfig.UpdateTime");
			describeGtmMonitorConfigResponse.UpdateTimestamp = context.LongValue("DescribeGtmMonitorConfig.UpdateTimestamp");
			describeGtmMonitorConfigResponse.Name = context.StringValue("DescribeGtmMonitorConfig.Name");
			describeGtmMonitorConfigResponse.ProtocolType = context.StringValue("DescribeGtmMonitorConfig.ProtocolType");
			describeGtmMonitorConfigResponse.Interval = context.IntegerValue("DescribeGtmMonitorConfig.Interval");
			describeGtmMonitorConfigResponse.EvaluationCount = context.IntegerValue("DescribeGtmMonitorConfig.EvaluationCount");
			describeGtmMonitorConfigResponse.Timeout = context.IntegerValue("DescribeGtmMonitorConfig.Timeout");
			describeGtmMonitorConfigResponse.MonitorExtendInfo = context.StringValue("DescribeGtmMonitorConfig.MonitorExtendInfo");

			List<DescribeGtmMonitorConfigResponse.DescribeGtmMonitorConfig_IspCityNode> describeGtmMonitorConfigResponse_ispCityNodes = new List<DescribeGtmMonitorConfigResponse.DescribeGtmMonitorConfig_IspCityNode>();
			for (int i = 0; i < context.Length("DescribeGtmMonitorConfig.IspCityNodes.Length"); i++) {
				DescribeGtmMonitorConfigResponse.DescribeGtmMonitorConfig_IspCityNode ispCityNode = new DescribeGtmMonitorConfigResponse.DescribeGtmMonitorConfig_IspCityNode();
				ispCityNode.CountryName = context.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].CountryName");
				ispCityNode.CountryCode = context.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].CountryCode");
				ispCityNode.CityName = context.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].CityName");
				ispCityNode.CityCode = context.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].CityCode");

				describeGtmMonitorConfigResponse_ispCityNodes.Add(ispCityNode);
			}
			describeGtmMonitorConfigResponse.IspCityNodes = describeGtmMonitorConfigResponse_ispCityNodes;
        
			return describeGtmMonitorConfigResponse;
        }
    }
}
