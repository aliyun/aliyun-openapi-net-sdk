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
        public static DescribeServiceDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeServiceDetailResponse describeServiceDetailResponse = new DescribeServiceDetailResponse();

			describeServiceDetailResponse.HttpResponse = context.HttpResponse;
			describeServiceDetailResponse.Code = context.IntegerValue("DescribeServiceDetail.Code");
			describeServiceDetailResponse.ErrMsg = context.StringValue("DescribeServiceDetail.ErrMsg");
			describeServiceDetailResponse.RequestId = context.StringValue("DescribeServiceDetail.RequestId");
			describeServiceDetailResponse.Success = context.BooleanValue("DescribeServiceDetail.Success");

			DescribeServiceDetailResponse.DescribeServiceDetail_Result result = new DescribeServiceDetailResponse.DescribeServiceDetail_Result();
			result.AppId = context.LongValue("DescribeServiceDetail.Result.AppId");
			result.EnvId = context.LongValue("DescribeServiceDetail.Result.EnvId");
			result.Headless = context.BooleanValue("DescribeServiceDetail.Result.Headless");
			result.K8sServiceId = context.StringValue("DescribeServiceDetail.Result.K8sServiceId");
			result.Name = context.StringValue("DescribeServiceDetail.Result.Name");
			result.ServiceId = context.LongValue("DescribeServiceDetail.Result.ServiceId");
			result.ServiceType = context.StringValue("DescribeServiceDetail.Result.ServiceType");

			List<DescribeServiceDetailResponse.DescribeServiceDetail_Result.DescribeServiceDetail_ServicePortMapping> result_portMappings = new List<DescribeServiceDetailResponse.DescribeServiceDetail_Result.DescribeServiceDetail_ServicePortMapping>();
			for (int i = 0; i < context.Length("DescribeServiceDetail.Result.PortMappings.Length"); i++) {
				DescribeServiceDetailResponse.DescribeServiceDetail_Result.DescribeServiceDetail_ServicePortMapping servicePortMapping = new DescribeServiceDetailResponse.DescribeServiceDetail_Result.DescribeServiceDetail_ServicePortMapping();
				servicePortMapping.Name = context.StringValue("DescribeServiceDetail.Result.PortMappings["+ i +"].Name");
				servicePortMapping.NodePort = context.IntegerValue("DescribeServiceDetail.Result.PortMappings["+ i +"].NodePort");
				servicePortMapping.Port = context.IntegerValue("DescribeServiceDetail.Result.PortMappings["+ i +"].Port");
				servicePortMapping.Protocol = context.StringValue("DescribeServiceDetail.Result.PortMappings["+ i +"].Protocol");
				servicePortMapping.TargetPort = context.StringValue("DescribeServiceDetail.Result.PortMappings["+ i +"].TargetPort");

				result_portMappings.Add(servicePortMapping);
			}
			result.PortMappings = result_portMappings;
			describeServiceDetailResponse.Result = result;
        
			return describeServiceDetailResponse;
        }
    }
}
