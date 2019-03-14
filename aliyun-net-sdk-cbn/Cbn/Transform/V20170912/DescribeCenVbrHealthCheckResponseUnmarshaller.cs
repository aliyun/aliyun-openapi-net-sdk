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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeCenVbrHealthCheckResponseUnmarshaller
    {
        public static DescribeCenVbrHealthCheckResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCenVbrHealthCheckResponse describeCenVbrHealthCheckResponse = new DescribeCenVbrHealthCheckResponse();

			describeCenVbrHealthCheckResponse.HttpResponse = context.HttpResponse;
			describeCenVbrHealthCheckResponse.RequestId = context.StringValue("DescribeCenVbrHealthCheck.RequestId");
			describeCenVbrHealthCheckResponse.TotalCount = context.IntegerValue("DescribeCenVbrHealthCheck.TotalCount");
			describeCenVbrHealthCheckResponse.PageNumber = context.IntegerValue("DescribeCenVbrHealthCheck.PageNumber");
			describeCenVbrHealthCheckResponse.PageSize = context.IntegerValue("DescribeCenVbrHealthCheck.PageSize");

			List<DescribeCenVbrHealthCheckResponse.DescribeCenVbrHealthCheck_VbrHealthCheck> describeCenVbrHealthCheckResponse_vbrHealthChecks = new List<DescribeCenVbrHealthCheckResponse.DescribeCenVbrHealthCheck_VbrHealthCheck>();
			for (int i = 0; i < context.Length("DescribeCenVbrHealthCheck.VbrHealthChecks.Length"); i++) {
				DescribeCenVbrHealthCheckResponse.DescribeCenVbrHealthCheck_VbrHealthCheck vbrHealthCheck = new DescribeCenVbrHealthCheckResponse.DescribeCenVbrHealthCheck_VbrHealthCheck();
				vbrHealthCheck.CenId = context.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].CenId");
				vbrHealthCheck.VbrInstanceId = context.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].VbrInstanceId");
				vbrHealthCheck.LinkStatus = context.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].LinkStatus");
				vbrHealthCheck.PacketLoss = context.LongValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].PacketLoss");
				vbrHealthCheck.HealthCheckSourceIp = context.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].HealthCheckSourceIp");
				vbrHealthCheck.HealthCheckTargetIp = context.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].HealthCheckTargetIp");
				vbrHealthCheck.Delay = context.LongValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].Delay");

				describeCenVbrHealthCheckResponse_vbrHealthChecks.Add(vbrHealthCheck);
			}
			describeCenVbrHealthCheckResponse.VbrHealthChecks = describeCenVbrHealthCheckResponse_vbrHealthChecks;
        
			return describeCenVbrHealthCheckResponse;
        }
    }
}
