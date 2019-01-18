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
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeNqasResponseUnmarshaller
    {
        public static DescribeNqasResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNqasResponse describeNqasResponse = new DescribeNqasResponse();

			describeNqasResponse.HttpResponse = context.HttpResponse;
			describeNqasResponse.RequestId = context.StringValue("DescribeNqas.RequestId");
			describeNqasResponse.TotalCount = context.IntegerValue("DescribeNqas.TotalCount");
			describeNqasResponse.PageNumber = context.IntegerValue("DescribeNqas.PageNumber");
			describeNqasResponse.PageSize = context.IntegerValue("DescribeNqas.PageSize");

			List<DescribeNqasResponse.DescribeNqas_Nqa> describeNqasResponse_nqas = new List<DescribeNqasResponse.DescribeNqas_Nqa>();
			for (int i = 0; i < context.Length("DescribeNqas.Nqas.Length"); i++) {
				DescribeNqasResponse.DescribeNqas_Nqa nqa = new DescribeNqasResponse.DescribeNqas_Nqa();
				nqa.NqaId = context.StringValue("DescribeNqas.Nqas["+ i +"].NqaId");
				nqa.RegionId = context.StringValue("DescribeNqas.Nqas["+ i +"].RegionId");
				nqa.Status = context.StringValue("DescribeNqas.Nqas["+ i +"].Status");
				nqa.RouterId = context.StringValue("DescribeNqas.Nqas["+ i +"].RouterId");
				nqa.DestinationIp = context.StringValue("DescribeNqas.Nqas["+ i +"].DestinationIp");

				describeNqasResponse_nqas.Add(nqa);
			}
			describeNqasResponse.Nqas = describeNqasResponse_nqas;
        
			return describeNqasResponse;
        }
    }
}