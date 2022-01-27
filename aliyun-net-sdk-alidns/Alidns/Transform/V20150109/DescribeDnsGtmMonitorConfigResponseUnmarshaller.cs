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
    public class DescribeDnsGtmMonitorConfigResponseUnmarshaller
    {
        public static DescribeDnsGtmMonitorConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmMonitorConfigResponse describeDnsGtmMonitorConfigResponse = new DescribeDnsGtmMonitorConfigResponse();

			describeDnsGtmMonitorConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmMonitorConfigResponse.RequestId = _ctx.StringValue("DescribeDnsGtmMonitorConfig.RequestId");
			describeDnsGtmMonitorConfigResponse.MonitorConfigId = _ctx.StringValue("DescribeDnsGtmMonitorConfig.MonitorConfigId");
			describeDnsGtmMonitorConfigResponse.CreateTime = _ctx.StringValue("DescribeDnsGtmMonitorConfig.CreateTime");
			describeDnsGtmMonitorConfigResponse.CreateTimestamp = _ctx.LongValue("DescribeDnsGtmMonitorConfig.CreateTimestamp");
			describeDnsGtmMonitorConfigResponse.UpdateTime = _ctx.StringValue("DescribeDnsGtmMonitorConfig.UpdateTime");
			describeDnsGtmMonitorConfigResponse.UpdateTimestamp = _ctx.LongValue("DescribeDnsGtmMonitorConfig.UpdateTimestamp");
			describeDnsGtmMonitorConfigResponse.ProtocolType = _ctx.StringValue("DescribeDnsGtmMonitorConfig.ProtocolType");
			describeDnsGtmMonitorConfigResponse.Interval = _ctx.IntegerValue("DescribeDnsGtmMonitorConfig.Interval");
			describeDnsGtmMonitorConfigResponse.EvaluationCount = _ctx.IntegerValue("DescribeDnsGtmMonitorConfig.EvaluationCount");
			describeDnsGtmMonitorConfigResponse.Timeout = _ctx.IntegerValue("DescribeDnsGtmMonitorConfig.Timeout");
			describeDnsGtmMonitorConfigResponse.MonitorExtendInfo = _ctx.StringValue("DescribeDnsGtmMonitorConfig.MonitorExtendInfo");

			List<DescribeDnsGtmMonitorConfigResponse.DescribeDnsGtmMonitorConfig_IspCityNode> describeDnsGtmMonitorConfigResponse_ispCityNodes = new List<DescribeDnsGtmMonitorConfigResponse.DescribeDnsGtmMonitorConfig_IspCityNode>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmMonitorConfig.IspCityNodes.Length"); i++) {
				DescribeDnsGtmMonitorConfigResponse.DescribeDnsGtmMonitorConfig_IspCityNode ispCityNode = new DescribeDnsGtmMonitorConfigResponse.DescribeDnsGtmMonitorConfig_IspCityNode();
				ispCityNode.CountryName = _ctx.StringValue("DescribeDnsGtmMonitorConfig.IspCityNodes["+ i +"].CountryName");
				ispCityNode.CountryCode = _ctx.StringValue("DescribeDnsGtmMonitorConfig.IspCityNodes["+ i +"].CountryCode");
				ispCityNode.CityName = _ctx.StringValue("DescribeDnsGtmMonitorConfig.IspCityNodes["+ i +"].CityName");
				ispCityNode.CityCode = _ctx.StringValue("DescribeDnsGtmMonitorConfig.IspCityNodes["+ i +"].CityCode");
				ispCityNode.IspCode = _ctx.StringValue("DescribeDnsGtmMonitorConfig.IspCityNodes["+ i +"].IspCode");
				ispCityNode.IspName = _ctx.StringValue("DescribeDnsGtmMonitorConfig.IspCityNodes["+ i +"].IspName");

				describeDnsGtmMonitorConfigResponse_ispCityNodes.Add(ispCityNode);
			}
			describeDnsGtmMonitorConfigResponse.IspCityNodes = describeDnsGtmMonitorConfigResponse_ispCityNodes;
        
			return describeDnsGtmMonitorConfigResponse;
        }
    }
}
