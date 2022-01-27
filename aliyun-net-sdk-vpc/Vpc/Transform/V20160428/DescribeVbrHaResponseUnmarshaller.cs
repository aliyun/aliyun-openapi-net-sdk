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
    public class DescribeVbrHaResponseUnmarshaller
    {
        public static DescribeVbrHaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVbrHaResponse describeVbrHaResponse = new DescribeVbrHaResponse();

			describeVbrHaResponse.HttpResponse = _ctx.HttpResponse;
			describeVbrHaResponse.RequestId = _ctx.StringValue("DescribeVbrHa.RequestId");
			describeVbrHaResponse.VbrHaId = _ctx.StringValue("DescribeVbrHa.VbrHaId");
			describeVbrHaResponse.RegionId = _ctx.StringValue("DescribeVbrHa.RegionId");
			describeVbrHaResponse.Name = _ctx.StringValue("DescribeVbrHa.Name");
			describeVbrHaResponse.Description = _ctx.StringValue("DescribeVbrHa.Description");
			describeVbrHaResponse.Status = _ctx.StringValue("DescribeVbrHa.Status");
			describeVbrHaResponse.VbrId = _ctx.StringValue("DescribeVbrHa.VbrId");
			describeVbrHaResponse.CreationTime = _ctx.StringValue("DescribeVbrHa.CreationTime");
			describeVbrHaResponse.PeerVbrId = _ctx.StringValue("DescribeVbrHa.PeerVbrId");
        
			return describeVbrHaResponse;
        }
    }
}
