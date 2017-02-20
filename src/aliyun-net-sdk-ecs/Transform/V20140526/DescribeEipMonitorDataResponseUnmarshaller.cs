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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeEipMonitorDataResponseUnmarshaller
    {
        public static DescribeEipMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeEipMonitorDataResponse describeEipMonitorDataResponse = new DescribeEipMonitorDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeEipMonitorData.RequestId")
            };
            List<DescribeEipMonitorDataResponse.EipMonitorData> eipMonitorDatas = new List<DescribeEipMonitorDataResponse.EipMonitorData>();
			for (int i = 0; i < context.Length("DescribeEipMonitorData.EipMonitorDatas.Length"); i++) {
                DescribeEipMonitorDataResponse.EipMonitorData eipMonitorData = new DescribeEipMonitorDataResponse.EipMonitorData()
                {
                    EipRx = context.IntegerValue($"DescribeEipMonitorData.EipMonitorDatas[{i}].EipRX"),
                    EipTx = context.IntegerValue($"DescribeEipMonitorData.EipMonitorDatas[{i}].EipTX"),
                    EipFlow = context.IntegerValue($"DescribeEipMonitorData.EipMonitorDatas[{i}].EipFlow"),
                    EipBandwidth = context.IntegerValue($"DescribeEipMonitorData.EipMonitorDatas[{i}].EipBandwidth"),
                    EipPackets = context.IntegerValue($"DescribeEipMonitorData.EipMonitorDatas[{i}].EipPackets"),
                    TimeStamp = context.StringValue($"DescribeEipMonitorData.EipMonitorDatas[{i}].TimeStamp")
                };
                eipMonitorDatas.Add(eipMonitorData);
			}
			describeEipMonitorDataResponse.EipMonitorDatas = eipMonitorDatas;
        
			return describeEipMonitorDataResponse;
        }
    }
}