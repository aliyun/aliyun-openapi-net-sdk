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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodAIDataResponseUnmarshaller
    {
        public static DescribeVodAIDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodAIDataResponse describeVodAIDataResponse = new DescribeVodAIDataResponse();

			describeVodAIDataResponse.HttpResponse = context.HttpResponse;
			describeVodAIDataResponse.RequestId = context.StringValue("DescribeVodAIData.RequestId");
			describeVodAIDataResponse.DataInterval = context.StringValue("DescribeVodAIData.DataInterval");

			List<DescribeVodAIDataResponse.DescribeVodAIData_AIDataItem> describeVodAIDataResponse_aIData = new List<DescribeVodAIDataResponse.DescribeVodAIData_AIDataItem>();
			for (int i = 0; i < context.Length("DescribeVodAIData.AIData.Length"); i++) {
				DescribeVodAIDataResponse.DescribeVodAIData_AIDataItem aIDataItem = new DescribeVodAIDataResponse.DescribeVodAIData_AIDataItem();
				aIDataItem.TimeStamp = context.StringValue("DescribeVodAIData.AIData["+ i +"].TimeStamp");

				List<DescribeVodAIDataResponse.DescribeVodAIData_AIDataItem.DescribeVodAIData_DataItem> aIDataItem_data = new List<DescribeVodAIDataResponse.DescribeVodAIData_AIDataItem.DescribeVodAIData_DataItem>();
				for (int j = 0; j < context.Length("DescribeVodAIData.AIData["+ i +"].Data.Length"); j++) {
					DescribeVodAIDataResponse.DescribeVodAIData_AIDataItem.DescribeVodAIData_DataItem dataItem = new DescribeVodAIDataResponse.DescribeVodAIData_AIDataItem.DescribeVodAIData_DataItem();
					dataItem.Name = context.StringValue("DescribeVodAIData.AIData["+ i +"].Data["+ j +"].Name");
					dataItem._Value = context.StringValue("DescribeVodAIData.AIData["+ i +"].Data["+ j +"].Value");

					aIDataItem_data.Add(dataItem);
				}
				aIDataItem.Data = aIDataItem_data;

				describeVodAIDataResponse_aIData.Add(aIDataItem);
			}
			describeVodAIDataResponse.AIData = describeVodAIDataResponse_aIData;
        
			return describeVodAIDataResponse;
        }
    }
}
