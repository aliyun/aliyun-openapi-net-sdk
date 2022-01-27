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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeServiceDetailResponseUnmarshaller
    {
        public static DescribeServiceDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeServiceDetailResponse describeServiceDetailResponse = new DescribeServiceDetailResponse();

			describeServiceDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeServiceDetailResponse.Code = _ctx.IntegerValue("DescribeServiceDetail.Code");
			describeServiceDetailResponse.ErrMsg = _ctx.StringValue("DescribeServiceDetail.ErrMsg");
			describeServiceDetailResponse.RequestId = _ctx.StringValue("DescribeServiceDetail.RequestId");
			describeServiceDetailResponse.Success = _ctx.BooleanValue("DescribeServiceDetail.Success");

			DescribeServiceDetailResponse.DescribeServiceDetail_Result result = new DescribeServiceDetailResponse.DescribeServiceDetail_Result();
			result.AppId = _ctx.LongValue("DescribeServiceDetail.Result.AppId");
			result.EnvId = _ctx.LongValue("DescribeServiceDetail.Result.EnvId");
			result.Headless = _ctx.BooleanValue("DescribeServiceDetail.Result.Headless");
			result.K8sServiceId = _ctx.StringValue("DescribeServiceDetail.Result.K8sServiceId");
			result.Name = _ctx.StringValue("DescribeServiceDetail.Result.Name");
			result.ServiceId = _ctx.LongValue("DescribeServiceDetail.Result.ServiceId");
			result.ServiceType = _ctx.StringValue("DescribeServiceDetail.Result.ServiceType");
			result.ClusterIP = _ctx.StringValue("DescribeServiceDetail.Result.ClusterIP");

			List<DescribeServiceDetailResponse.DescribeServiceDetail_Result.DescribeServiceDetail_ServicePortMapping> result_portMappings = new List<DescribeServiceDetailResponse.DescribeServiceDetail_Result.DescribeServiceDetail_ServicePortMapping>();
			for (int i = 0; i < _ctx.Length("DescribeServiceDetail.Result.PortMappings.Length"); i++) {
				DescribeServiceDetailResponse.DescribeServiceDetail_Result.DescribeServiceDetail_ServicePortMapping servicePortMapping = new DescribeServiceDetailResponse.DescribeServiceDetail_Result.DescribeServiceDetail_ServicePortMapping();
				servicePortMapping.Name = _ctx.StringValue("DescribeServiceDetail.Result.PortMappings["+ i +"].Name");
				servicePortMapping.NodePort = _ctx.IntegerValue("DescribeServiceDetail.Result.PortMappings["+ i +"].NodePort");
				servicePortMapping.Port = _ctx.IntegerValue("DescribeServiceDetail.Result.PortMappings["+ i +"].Port");
				servicePortMapping.Protocol = _ctx.StringValue("DescribeServiceDetail.Result.PortMappings["+ i +"].Protocol");
				servicePortMapping.TargetPort = _ctx.StringValue("DescribeServiceDetail.Result.PortMappings["+ i +"].TargetPort");

				result_portMappings.Add(servicePortMapping);
			}
			result.PortMappings = result_portMappings;
			describeServiceDetailResponse.Result = result;
        
			return describeServiceDetailResponse;
        }
    }
}
