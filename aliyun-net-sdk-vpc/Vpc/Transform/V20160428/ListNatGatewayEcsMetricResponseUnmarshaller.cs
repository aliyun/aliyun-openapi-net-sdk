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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListNatGatewayEcsMetricResponseUnmarshaller
    {
        public static ListNatGatewayEcsMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNatGatewayEcsMetricResponse listNatGatewayEcsMetricResponse = new ListNatGatewayEcsMetricResponse();

			listNatGatewayEcsMetricResponse.HttpResponse = _ctx.HttpResponse;
			listNatGatewayEcsMetricResponse.RequestId = _ctx.StringValue("ListNatGatewayEcsMetric.RequestId");
			listNatGatewayEcsMetricResponse.NextToken = _ctx.StringValue("ListNatGatewayEcsMetric.NextToken");
			listNatGatewayEcsMetricResponse.MaxResults = _ctx.IntegerValue("ListNatGatewayEcsMetric.MaxResults");

			List<ListNatGatewayEcsMetricResponse.ListNatGatewayEcsMetric_MetricData> listNatGatewayEcsMetricResponse_metricDataList = new List<ListNatGatewayEcsMetricResponse.ListNatGatewayEcsMetric_MetricData>();
			for (int i = 0; i < _ctx.Length("ListNatGatewayEcsMetric.MetricDataList.Length"); i++) {
				ListNatGatewayEcsMetricResponse.ListNatGatewayEcsMetric_MetricData metricData = new ListNatGatewayEcsMetricResponse.ListNatGatewayEcsMetric_MetricData();
				metricData.NatGatewayId = _ctx.StringValue("ListNatGatewayEcsMetric.MetricDataList["+ i +"].NatGatewayId");
				metricData.PrivateIpAddress = _ctx.StringValue("ListNatGatewayEcsMetric.MetricDataList["+ i +"].PrivateIpAddress");
				metricData.Timestamp = _ctx.LongValue("ListNatGatewayEcsMetric.MetricDataList["+ i +"].Timestamp");
				metricData.ActiveSessionNum = _ctx.LongValue("ListNatGatewayEcsMetric.MetricDataList["+ i +"].ActiveSessionNum");
				metricData.NewSessionRate = _ctx.LongValue("ListNatGatewayEcsMetric.MetricDataList["+ i +"].NewSessionRate");
				metricData.RxBps = _ctx.LongValue("ListNatGatewayEcsMetric.MetricDataList["+ i +"].RxBps");
				metricData.TxBps = _ctx.LongValue("ListNatGatewayEcsMetric.MetricDataList["+ i +"].TxBps");
				metricData.RxPps = _ctx.LongValue("ListNatGatewayEcsMetric.MetricDataList["+ i +"].RxPps");
				metricData.TxPps = _ctx.LongValue("ListNatGatewayEcsMetric.MetricDataList["+ i +"].TxPps");

				listNatGatewayEcsMetricResponse_metricDataList.Add(metricData);
			}
			listNatGatewayEcsMetricResponse.MetricDataList = listNatGatewayEcsMetricResponse_metricDataList;
        
			return listNatGatewayEcsMetricResponse;
        }
    }
}
