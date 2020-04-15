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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class CreateHealthCheckResponseUnmarshaller
    {
        public static CreateHealthCheckResponse Unmarshall(UnmarshallerContext context)
        {
			CreateHealthCheckResponse createHealthCheckResponse = new CreateHealthCheckResponse();

			createHealthCheckResponse.HttpResponse = context.HttpResponse;
			createHealthCheckResponse.RequestId = context.StringValue("CreateHealthCheck.RequestId");
			createHealthCheckResponse.CreateTime = context.LongValue("CreateHealthCheck.CreateTime");
			createHealthCheckResponse.InstanceId = context.StringValue("CreateHealthCheck.InstanceId");
			createHealthCheckResponse.SmartAGId = context.StringValue("CreateHealthCheck.SmartAGId");
			createHealthCheckResponse.Name = context.StringValue("CreateHealthCheck.Name");
			createHealthCheckResponse.RegionId = context.StringValue("CreateHealthCheck.RegionId");
			createHealthCheckResponse.Description = context.StringValue("CreateHealthCheck.Description");
			createHealthCheckResponse.Type = context.StringValue("CreateHealthCheck.Type");
			createHealthCheckResponse.DstIpAddr = context.StringValue("CreateHealthCheck.DstIpAddr");
			createHealthCheckResponse.DstPort = context.IntegerValue("CreateHealthCheck.DstPort");
			createHealthCheckResponse.SrcIpAddr = context.StringValue("CreateHealthCheck.SrcIpAddr");
			createHealthCheckResponse.SrcPort = context.IntegerValue("CreateHealthCheck.SrcPort");
			createHealthCheckResponse.ProbeInterval = context.IntegerValue("CreateHealthCheck.ProbeInterval");
			createHealthCheckResponse.ProbeCount = context.IntegerValue("CreateHealthCheck.ProbeCount");
			createHealthCheckResponse.ProbeTimeout = context.IntegerValue("CreateHealthCheck.ProbeTimeout");
			createHealthCheckResponse.RttThreshold = context.IntegerValue("CreateHealthCheck.RttThreshold");
			createHealthCheckResponse.RttFailThreshold = context.IntegerValue("CreateHealthCheck.RttFailThreshold");
			createHealthCheckResponse.FailCountThreshold = context.IntegerValue("CreateHealthCheck.FailCountThreshold");
        
			return createHealthCheckResponse;
        }
    }
}
