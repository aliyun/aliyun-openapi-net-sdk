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
    public class DescribeLiveDetectPornDataResponseUnmarshaller
    {
        public static DescribeLiveDetectPornDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveDetectPornDataResponse describeLiveDetectPornDataResponse = new DescribeLiveDetectPornDataResponse();

			describeLiveDetectPornDataResponse.HttpResponse = context.HttpResponse;
			describeLiveDetectPornDataResponse.RequestId = context.StringValue("DescribeLiveDetectPornData.RequestId");

			List<DescribeLiveDetectPornDataResponse.DescribeLiveDetectPornData_DataModule> describeLiveDetectPornDataResponse_detectPornData = new List<DescribeLiveDetectPornDataResponse.DescribeLiveDetectPornData_DataModule>();
			for (int i = 0; i < context.Length("DescribeLiveDetectPornData.DetectPornData.Length"); i++) {
				DescribeLiveDetectPornDataResponse.DescribeLiveDetectPornData_DataModule dataModule = new DescribeLiveDetectPornDataResponse.DescribeLiveDetectPornData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeLiveDetectPornData.DetectPornData["+ i +"].TimeStamp");
				dataModule.App = context.StringValue("DescribeLiveDetectPornData.DetectPornData["+ i +"].App");
				dataModule.Domain = context.StringValue("DescribeLiveDetectPornData.DetectPornData["+ i +"].Domain");
				dataModule.Stream = context.StringValue("DescribeLiveDetectPornData.DetectPornData["+ i +"].Stream");
				dataModule.Fee = context.StringValue("DescribeLiveDetectPornData.DetectPornData["+ i +"].Fee");
				dataModule.Scene = context.StringValue("DescribeLiveDetectPornData.DetectPornData["+ i +"].Scene");
				dataModule.Region = context.StringValue("DescribeLiveDetectPornData.DetectPornData["+ i +"].Region");
				dataModule.Count = context.LongValue("DescribeLiveDetectPornData.DetectPornData["+ i +"].Count");

				describeLiveDetectPornDataResponse_detectPornData.Add(dataModule);
			}
			describeLiveDetectPornDataResponse.DetectPornData = describeLiveDetectPornDataResponse_detectPornData;
        
			return describeLiveDetectPornDataResponse;
        }
    }
}
