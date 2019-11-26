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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeCustomLinesResponseUnmarshaller
    {
        public static DescribeCustomLinesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCustomLinesResponse describeCustomLinesResponse = new DescribeCustomLinesResponse();

			describeCustomLinesResponse.HttpResponse = context.HttpResponse;
			describeCustomLinesResponse.RequestId = context.StringValue("DescribeCustomLines.RequestId");
			describeCustomLinesResponse.TotalItems = context.IntegerValue("DescribeCustomLines.TotalItems");
			describeCustomLinesResponse.PageNumber = context.IntegerValue("DescribeCustomLines.PageNumber");
			describeCustomLinesResponse.PageSize = context.IntegerValue("DescribeCustomLines.PageSize");
			describeCustomLinesResponse.TotalPages = context.IntegerValue("DescribeCustomLines.TotalPages");

			List<DescribeCustomLinesResponse.DescribeCustomLines_CustomLine> describeCustomLinesResponse_customLines = new List<DescribeCustomLinesResponse.DescribeCustomLines_CustomLine>();
			for (int i = 0; i < context.Length("DescribeCustomLines.CustomLines.Length"); i++) {
				DescribeCustomLinesResponse.DescribeCustomLines_CustomLine customLine = new DescribeCustomLinesResponse.DescribeCustomLines_CustomLine();
				customLine.Id = context.LongValue("DescribeCustomLines.CustomLines["+ i +"].Id");
				customLine.Name = context.StringValue("DescribeCustomLines.CustomLines["+ i +"].Name");
				customLine.CreateTime = context.StringValue("DescribeCustomLines.CustomLines["+ i +"].CreateTime");
				customLine.CreateTimestamp = context.LongValue("DescribeCustomLines.CustomLines["+ i +"].CreateTimestamp");
				customLine.IpSegments = context.StringValue("DescribeCustomLines.CustomLines["+ i +"].IpSegments");
				customLine.Code = context.StringValue("DescribeCustomLines.CustomLines["+ i +"].Code");

				List<DescribeCustomLinesResponse.DescribeCustomLines_CustomLine.DescribeCustomLines_IpSegment> customLine_ipSegmentList = new List<DescribeCustomLinesResponse.DescribeCustomLines_CustomLine.DescribeCustomLines_IpSegment>();
				for (int j = 0; j < context.Length("DescribeCustomLines.CustomLines["+ i +"].IpSegmentList.Length"); j++) {
					DescribeCustomLinesResponse.DescribeCustomLines_CustomLine.DescribeCustomLines_IpSegment ipSegment = new DescribeCustomLinesResponse.DescribeCustomLines_CustomLine.DescribeCustomLines_IpSegment();
					ipSegment.Name = context.StringValue("DescribeCustomLines.CustomLines["+ i +"].IpSegmentList["+ j +"].Name");
					ipSegment.StartIp = context.StringValue("DescribeCustomLines.CustomLines["+ i +"].IpSegmentList["+ j +"].StartIp");
					ipSegment.EndIp = context.StringValue("DescribeCustomLines.CustomLines["+ i +"].IpSegmentList["+ j +"].EndIp");

					customLine_ipSegmentList.Add(ipSegment);
				}
				customLine.IpSegmentList = customLine_ipSegmentList;

				describeCustomLinesResponse_customLines.Add(customLine);
			}
			describeCustomLinesResponse.CustomLines = describeCustomLinesResponse_customLines;
        
			return describeCustomLinesResponse;
        }
    }
}
