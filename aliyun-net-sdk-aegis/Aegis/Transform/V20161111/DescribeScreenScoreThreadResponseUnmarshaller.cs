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
    public class DescribeScreenScoreThreadResponseUnmarshaller
    {
        public static DescribeScreenScoreThreadResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScreenScoreThreadResponse describeScreenScoreThreadResponse = new DescribeScreenScoreThreadResponse();

			describeScreenScoreThreadResponse.HttpResponse = context.HttpResponse;
			describeScreenScoreThreadResponse.RequestId = context.StringValue("DescribeScreenScoreThread.RequestId");
			describeScreenScoreThreadResponse.Success = context.BooleanValue("DescribeScreenScoreThread.Success");

			DescribeScreenScoreThreadResponse.DescribeScreenScoreThread_Data data = new DescribeScreenScoreThreadResponse.DescribeScreenScoreThread_Data();

			List<string> data_socreThreadDate = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenScoreThread.Data.SocreThreadDate.Length"); i++) {
				data_socreThreadDate.Add(context.StringValue("DescribeScreenScoreThread.Data.SocreThreadDate["+ i +"]"));
			}
			data.SocreThreadDate = data_socreThreadDate;

			List<string> data_socreThread = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenScoreThread.Data.SocreThread.Length"); i++) {
				data_socreThread.Add(context.StringValue("DescribeScreenScoreThread.Data.SocreThread["+ i +"]"));
			}
			data.SocreThread = data_socreThread;
			describeScreenScoreThreadResponse.Data = data;
        
			return describeScreenScoreThreadResponse;
        }
    }
}
