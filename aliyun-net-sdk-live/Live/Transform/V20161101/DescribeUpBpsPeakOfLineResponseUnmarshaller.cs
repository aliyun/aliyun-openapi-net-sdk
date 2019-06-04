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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeUpBpsPeakOfLineResponseUnmarshaller
    {
        public static DescribeUpBpsPeakOfLineResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUpBpsPeakOfLineResponse describeUpBpsPeakOfLineResponse = new DescribeUpBpsPeakOfLineResponse();

			describeUpBpsPeakOfLineResponse.HttpResponse = context.HttpResponse;
			describeUpBpsPeakOfLineResponse.RequestId = context.StringValue("DescribeUpBpsPeakOfLine.RequestId");

			List<DescribeUpBpsPeakOfLineResponse.DescribeUpBpsPeakOfLine_DescribeUpBpsPeakOfLine> describeUpBpsPeakOfLineResponse_describeUpBpsPeakOfLines = new List<DescribeUpBpsPeakOfLineResponse.DescribeUpBpsPeakOfLine_DescribeUpBpsPeakOfLine>();
			for (int i = 0; i < context.Length("DescribeUpBpsPeakOfLine.DescribeUpBpsPeakOfLines.Length"); i++) {
				DescribeUpBpsPeakOfLineResponse.DescribeUpBpsPeakOfLine_DescribeUpBpsPeakOfLine describeUpBpsPeakOfLine = new DescribeUpBpsPeakOfLineResponse.DescribeUpBpsPeakOfLine_DescribeUpBpsPeakOfLine();
				describeUpBpsPeakOfLine.BandWidth = context.FloatValue("DescribeUpBpsPeakOfLine.DescribeUpBpsPeakOfLines["+ i +"].BandWidth");
				describeUpBpsPeakOfLine.PeakTime = context.StringValue("DescribeUpBpsPeakOfLine.DescribeUpBpsPeakOfLines["+ i +"].PeakTime");
				describeUpBpsPeakOfLine.QueryTime = context.StringValue("DescribeUpBpsPeakOfLine.DescribeUpBpsPeakOfLines["+ i +"].QueryTime");
				describeUpBpsPeakOfLine.StatName = context.StringValue("DescribeUpBpsPeakOfLine.DescribeUpBpsPeakOfLines["+ i +"].StatName");

				describeUpBpsPeakOfLineResponse_describeUpBpsPeakOfLines.Add(describeUpBpsPeakOfLine);
			}
			describeUpBpsPeakOfLineResponse.DescribeUpBpsPeakOfLines = describeUpBpsPeakOfLineResponse_describeUpBpsPeakOfLines;
        
			return describeUpBpsPeakOfLineResponse;
        }
    }
}
