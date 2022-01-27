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
        public static DescribeGtmMonitorConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGtmMonitorConfigResponse describeGtmMonitorConfigResponse = new DescribeGtmMonitorConfigResponse();

			describeGtmMonitorConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeGtmMonitorConfigResponse.RequestId = _ctx.StringValue("DescribeGtmMonitorConfig.RequestId");
			describeGtmMonitorConfigResponse.MonitorConfigId = _ctx.StringValue("DescribeGtmMonitorConfig.MonitorConfigId");
			describeGtmMonitorConfigResponse.CreateTime = _ctx.StringValue("DescribeGtmMonitorConfig.CreateTime");
			describeGtmMonitorConfigResponse.CreateTimestamp = _ctx.LongValue("DescribeGtmMonitorConfig.CreateTimestamp");
			describeGtmMonitorConfigResponse.UpdateTime = _ctx.StringValue("DescribeGtmMonitorConfig.UpdateTime");
			describeGtmMonitorConfigResponse.UpdateTimestamp = _ctx.LongValue("DescribeGtmMonitorConfig.UpdateTimestamp");
			describeGtmMonitorConfigResponse.ProtocolType = _ctx.StringValue("DescribeGtmMonitorConfig.ProtocolType");
			describeGtmMonitorConfigResponse.Interval = _ctx.IntegerValue("DescribeGtmMonitorConfig.Interval");
			describeGtmMonitorConfigResponse.EvaluationCount = _ctx.IntegerValue("DescribeGtmMonitorConfig.EvaluationCount");
			describeGtmMonitorConfigResponse.Timeout = _ctx.IntegerValue("DescribeGtmMonitorConfig.Timeout");
			describeGtmMonitorConfigResponse.MonitorExtendInfo = _ctx.StringValue("DescribeGtmMonitorConfig.MonitorExtendInfo");

			List<DescribeGtmMonitorConfigResponse.DescribeGtmMonitorConfig_IspCityNode> describeGtmMonitorConfigResponse_ispCityNodes = new List<DescribeGtmMonitorConfigResponse.DescribeGtmMonitorConfig_IspCityNode>();
			for (int i = 0; i < _ctx.Length("DescribeGtmMonitorConfig.IspCityNodes.Length"); i++) {
				DescribeGtmMonitorConfigResponse.DescribeGtmMonitorConfig_IspCityNode ispCityNode = new DescribeGtmMonitorConfigResponse.DescribeGtmMonitorConfig_IspCityNode();
				ispCityNode.CountryName = _ctx.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].CountryName");
				ispCityNode.CountryCode = _ctx.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].CountryCode");
				ispCityNode.CityName = _ctx.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].CityName");
				ispCityNode.CityCode = _ctx.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].CityCode");
				ispCityNode.IspCode = _ctx.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].IspCode");
				ispCityNode.IspName = _ctx.StringValue("DescribeGtmMonitorConfig.IspCityNodes["+ i +"].IspName");

				describeGtmMonitorConfigResponse_ispCityNodes.Add(ispCityNode);
			}
			describeGtmMonitorConfigResponse.IspCityNodes = describeGtmMonitorConfigResponse_ispCityNodes;
        
			return describeGtmMonitorConfigResponse;
        }
    }
}
