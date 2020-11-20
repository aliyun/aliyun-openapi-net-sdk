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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeUserBusinessStatusResponseUnmarshaller
    {
        public static DescribeUserBusinessStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserBusinessStatusResponse describeUserBusinessStatusResponse = new DescribeUserBusinessStatusResponse();

			describeUserBusinessStatusResponse.HttpResponse = context.HttpResponse;
			describeUserBusinessStatusResponse.RequestId = context.StringValue("DescribeUserBusinessStatus.RequestId");
			describeUserBusinessStatusResponse.Success = context.BooleanValue("DescribeUserBusinessStatus.Success");
			describeUserBusinessStatusResponse.Code = context.StringValue("DescribeUserBusinessStatus.Code");
			describeUserBusinessStatusResponse.Message = context.StringValue("DescribeUserBusinessStatus.Message");
			describeUserBusinessStatusResponse.IsEnabled = context.BooleanValue("DescribeUserBusinessStatus.IsEnabled");
			describeUserBusinessStatusResponse.IsIndebted = context.BooleanValue("DescribeUserBusinessStatus.IsIndebted");
			describeUserBusinessStatusResponse.IsIndebtedOverdue = context.BooleanValue("DescribeUserBusinessStatus.IsIndebtedOverdue");
			describeUserBusinessStatusResponse.IsRiskControl = context.BooleanValue("DescribeUserBusinessStatus.IsRiskControl");
        
			return describeUserBusinessStatusResponse;
        }
    }
}
