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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeNewProjectEipMonitorDataResponseUnmarshaller
    {
        public static DescribeNewProjectEipMonitorDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNewProjectEipMonitorDataResponse describeNewProjectEipMonitorDataResponse = new DescribeNewProjectEipMonitorDataResponse();

			describeNewProjectEipMonitorDataResponse.HttpResponse = _ctx.HttpResponse;
			describeNewProjectEipMonitorDataResponse.RequestId = _ctx.StringValue("DescribeNewProjectEipMonitorData.RequestId");

			List<DescribeNewProjectEipMonitorDataResponse.DescribeNewProjectEipMonitorData_EipMonitorData> describeNewProjectEipMonitorDataResponse_eipMonitorDatas = new List<DescribeNewProjectEipMonitorDataResponse.DescribeNewProjectEipMonitorData_EipMonitorData>();
			for (int i = 0; i < _ctx.Length("DescribeNewProjectEipMonitorData.EipMonitorDatas.Length"); i++) {
				DescribeNewProjectEipMonitorDataResponse.DescribeNewProjectEipMonitorData_EipMonitorData eipMonitorData = new DescribeNewProjectEipMonitorDataResponse.DescribeNewProjectEipMonitorData_EipMonitorData();
				eipMonitorData.EipTX = _ctx.IntegerValue("DescribeNewProjectEipMonitorData.EipMonitorDatas["+ i +"].EipTX");
				eipMonitorData.EipPackets = _ctx.IntegerValue("DescribeNewProjectEipMonitorData.EipMonitorDatas["+ i +"].EipPackets");
				eipMonitorData.EipBandwidth = _ctx.IntegerValue("DescribeNewProjectEipMonitorData.EipMonitorDatas["+ i +"].EipBandwidth");
				eipMonitorData.TimeStamp = _ctx.StringValue("DescribeNewProjectEipMonitorData.EipMonitorDatas["+ i +"].TimeStamp");
				eipMonitorData.EipFlow = _ctx.IntegerValue("DescribeNewProjectEipMonitorData.EipMonitorDatas["+ i +"].EipFlow");
				eipMonitorData.EipRX = _ctx.IntegerValue("DescribeNewProjectEipMonitorData.EipMonitorDatas["+ i +"].EipRX");

				describeNewProjectEipMonitorDataResponse_eipMonitorDatas.Add(eipMonitorData);
			}
			describeNewProjectEipMonitorDataResponse.EipMonitorDatas = describeNewProjectEipMonitorDataResponse_eipMonitorDatas;
        
			return describeNewProjectEipMonitorDataResponse;
        }
    }
}
