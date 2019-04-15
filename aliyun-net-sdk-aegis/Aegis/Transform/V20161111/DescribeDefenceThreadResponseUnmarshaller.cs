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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeDefenceThreadResponseUnmarshaller
    {
        public static DescribeDefenceThreadResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDefenceThreadResponse describeDefenceThreadResponse = new DescribeDefenceThreadResponse();

			describeDefenceThreadResponse.HttpResponse = context.HttpResponse;
			describeDefenceThreadResponse.RequestId = context.StringValue("DescribeDefenceThread.RequestId");
			describeDefenceThreadResponse.DefenceCountTotal = context.IntegerValue("DescribeDefenceThread.DefenceCountTotal");
			describeDefenceThreadResponse.TamperProofTotal = context.IntegerValue("DescribeDefenceThread.TamperProofTotal");

			List<string> describeDefenceThreadResponse_defenceAaggregatCountArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeDefenceThread.DefenceAaggregatCountArray.Length"); i++) {
				describeDefenceThreadResponse_defenceAaggregatCountArray.Add(context.StringValue("DescribeDefenceThread.DefenceAaggregatCountArray["+ i +"]"));
			}
			describeDefenceThreadResponse.DefenceAaggregatCountArray = describeDefenceThreadResponse_defenceAaggregatCountArray;

			List<string> describeDefenceThreadResponse_tamperProofArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeDefenceThread.TamperProofArray.Length"); i++) {
				describeDefenceThreadResponse_tamperProofArray.Add(context.StringValue("DescribeDefenceThread.TamperProofArray["+ i +"]"));
			}
			describeDefenceThreadResponse.TamperProofArray = describeDefenceThreadResponse_tamperProofArray;

			List<string> describeDefenceThreadResponse_dateArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeDefenceThread.DateArray.Length"); i++) {
				describeDefenceThreadResponse_dateArray.Add(context.StringValue("DescribeDefenceThread.DateArray["+ i +"]"));
			}
			describeDefenceThreadResponse.DateArray = describeDefenceThreadResponse_dateArray;

			List<string> describeDefenceThreadResponse_tamperProofAaggregateArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeDefenceThread.TamperProofAaggregateArray.Length"); i++) {
				describeDefenceThreadResponse_tamperProofAaggregateArray.Add(context.StringValue("DescribeDefenceThread.TamperProofAaggregateArray["+ i +"]"));
			}
			describeDefenceThreadResponse.TamperProofAaggregateArray = describeDefenceThreadResponse_tamperProofAaggregateArray;

			List<string> describeDefenceThreadResponse_defenceCountArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeDefenceThread.DefenceCountArray.Length"); i++) {
				describeDefenceThreadResponse_defenceCountArray.Add(context.StringValue("DescribeDefenceThread.DefenceCountArray["+ i +"]"));
			}
			describeDefenceThreadResponse.DefenceCountArray = describeDefenceThreadResponse_defenceCountArray;
        
			return describeDefenceThreadResponse;
        }
    }
}
