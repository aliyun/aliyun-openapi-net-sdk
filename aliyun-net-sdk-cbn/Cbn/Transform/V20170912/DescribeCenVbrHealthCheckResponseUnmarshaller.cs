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
        public static DescribeCenVbrHealthCheckResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCenVbrHealthCheckResponse describeCenVbrHealthCheckResponse = new DescribeCenVbrHealthCheckResponse();

			describeCenVbrHealthCheckResponse.HttpResponse = _ctx.HttpResponse;
			describeCenVbrHealthCheckResponse.PageSize = _ctx.IntegerValue("DescribeCenVbrHealthCheck.PageSize");
			describeCenVbrHealthCheckResponse.RequestId = _ctx.StringValue("DescribeCenVbrHealthCheck.RequestId");
			describeCenVbrHealthCheckResponse.PageNumber = _ctx.IntegerValue("DescribeCenVbrHealthCheck.PageNumber");
			describeCenVbrHealthCheckResponse.TotalCount = _ctx.IntegerValue("DescribeCenVbrHealthCheck.TotalCount");

			List<DescribeCenVbrHealthCheckResponse.DescribeCenVbrHealthCheck_VbrHealthCheck> describeCenVbrHealthCheckResponse_vbrHealthChecks = new List<DescribeCenVbrHealthCheckResponse.DescribeCenVbrHealthCheck_VbrHealthCheck>();
			for (int i = 0; i < _ctx.Length("DescribeCenVbrHealthCheck.VbrHealthChecks.Length"); i++) {
				DescribeCenVbrHealthCheckResponse.DescribeCenVbrHealthCheck_VbrHealthCheck vbrHealthCheck = new DescribeCenVbrHealthCheckResponse.DescribeCenVbrHealthCheck_VbrHealthCheck();
				vbrHealthCheck.HealthCheckTargetIp = _ctx.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].HealthCheckTargetIp");
				vbrHealthCheck.VbrInstanceId = _ctx.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].VbrInstanceId");
				vbrHealthCheck.VbrInstanceRegionId = _ctx.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].VbrInstanceRegionId");
				vbrHealthCheck.Delay = _ctx.LongValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].Delay");
				vbrHealthCheck.LinkStatus = _ctx.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].LinkStatus");
				vbrHealthCheck.CenId = _ctx.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].CenId");
				vbrHealthCheck.HealthyThreshold = _ctx.IntegerValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].HealthyThreshold");
				vbrHealthCheck.HealthCheckInterval = _ctx.IntegerValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].HealthCheckInterval");
				vbrHealthCheck.HealthCheckSourceIp = _ctx.StringValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].HealthCheckSourceIp");
				vbrHealthCheck.PacketLoss = _ctx.LongValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].PacketLoss");
				vbrHealthCheck.HealthCheckOnly = _ctx.BooleanValue("DescribeCenVbrHealthCheck.VbrHealthChecks["+ i +"].HealthCheckOnly");

				describeCenVbrHealthCheckResponse_vbrHealthChecks.Add(vbrHealthCheck);
			}
			describeCenVbrHealthCheckResponse.VbrHealthChecks = describeCenVbrHealthCheckResponse_vbrHealthChecks;
        
			return describeCenVbrHealthCheckResponse;
        }
    }
}
