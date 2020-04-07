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
    public class DescribeEipSegmentResponseUnmarshaller
    {
        public static DescribeEipSegmentResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEipSegmentResponse describeEipSegmentResponse = new DescribeEipSegmentResponse();

			describeEipSegmentResponse.HttpResponse = context.HttpResponse;
			describeEipSegmentResponse.RequestId = context.StringValue("DescribeEipSegment.RequestId");
			describeEipSegmentResponse.TotalCount = context.IntegerValue("DescribeEipSegment.TotalCount");
			describeEipSegmentResponse.PageNumber = context.IntegerValue("DescribeEipSegment.PageNumber");
			describeEipSegmentResponse.PageSize = context.IntegerValue("DescribeEipSegment.PageSize");

			List<DescribeEipSegmentResponse.DescribeEipSegment_EipSegment> describeEipSegmentResponse_eipSegments = new List<DescribeEipSegmentResponse.DescribeEipSegment_EipSegment>();
			for (int i = 0; i < context.Length("DescribeEipSegment.EipSegments.Length"); i++) {
				DescribeEipSegmentResponse.DescribeEipSegment_EipSegment eipSegment = new DescribeEipSegmentResponse.DescribeEipSegment_EipSegment();
				eipSegment.InstanceId = context.StringValue("DescribeEipSegment.EipSegments["+ i +"].InstanceId");
				eipSegment.Segment = context.StringValue("DescribeEipSegment.EipSegments["+ i +"].Segment");
				eipSegment.Status = context.StringValue("DescribeEipSegment.EipSegments["+ i +"].Status");
				eipSegment.RegionId = context.StringValue("DescribeEipSegment.EipSegments["+ i +"].RegionId");
				eipSegment.IpCount = context.StringValue("DescribeEipSegment.EipSegments["+ i +"].IpCount");
				eipSegment.Name = context.StringValue("DescribeEipSegment.EipSegments["+ i +"].Name");
				eipSegment.Descritpion = context.StringValue("DescribeEipSegment.EipSegments["+ i +"].Descritpion");
				eipSegment.CreationTime = context.StringValue("DescribeEipSegment.EipSegments["+ i +"].CreationTime");

				describeEipSegmentResponse_eipSegments.Add(eipSegment);
			}
			describeEipSegmentResponse.EipSegments = describeEipSegmentResponse_eipSegments;
        
			return describeEipSegmentResponse;
        }
    }
}
