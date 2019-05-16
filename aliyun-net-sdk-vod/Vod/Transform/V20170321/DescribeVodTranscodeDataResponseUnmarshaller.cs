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
    public class DescribeVodTranscodeDataResponseUnmarshaller
    {
        public static DescribeVodTranscodeDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodTranscodeDataResponse describeVodTranscodeDataResponse = new DescribeVodTranscodeDataResponse();

			describeVodTranscodeDataResponse.HttpResponse = context.HttpResponse;
			describeVodTranscodeDataResponse.RequestId = context.StringValue("DescribeVodTranscodeData.RequestId");
			describeVodTranscodeDataResponse.DataInterval = context.StringValue("DescribeVodTranscodeData.DataInterval");

			List<DescribeVodTranscodeDataResponse.DescribeVodTranscodeData_TranscodeDataItem> describeVodTranscodeDataResponse_transcodeData = new List<DescribeVodTranscodeDataResponse.DescribeVodTranscodeData_TranscodeDataItem>();
			for (int i = 0; i < context.Length("DescribeVodTranscodeData.TranscodeData.Length"); i++) {
				DescribeVodTranscodeDataResponse.DescribeVodTranscodeData_TranscodeDataItem transcodeDataItem = new DescribeVodTranscodeDataResponse.DescribeVodTranscodeData_TranscodeDataItem();
				transcodeDataItem.TimeStamp = context.StringValue("DescribeVodTranscodeData.TranscodeData["+ i +"].TimeStamp");

				List<DescribeVodTranscodeDataResponse.DescribeVodTranscodeData_TranscodeDataItem.DescribeVodTranscodeData_DataItem> transcodeDataItem_data = new List<DescribeVodTranscodeDataResponse.DescribeVodTranscodeData_TranscodeDataItem.DescribeVodTranscodeData_DataItem>();
				for (int j = 0; j < context.Length("DescribeVodTranscodeData.TranscodeData["+ i +"].Data.Length"); j++) {
					DescribeVodTranscodeDataResponse.DescribeVodTranscodeData_TranscodeDataItem.DescribeVodTranscodeData_DataItem dataItem = new DescribeVodTranscodeDataResponse.DescribeVodTranscodeData_TranscodeDataItem.DescribeVodTranscodeData_DataItem();
					dataItem.Name = context.StringValue("DescribeVodTranscodeData.TranscodeData["+ i +"].Data["+ j +"].Name");
					dataItem._Value = context.StringValue("DescribeVodTranscodeData.TranscodeData["+ i +"].Data["+ j +"].Value");

					transcodeDataItem_data.Add(dataItem);
				}
				transcodeDataItem.Data = transcodeDataItem_data;

				describeVodTranscodeDataResponse_transcodeData.Add(transcodeDataItem);
			}
			describeVodTranscodeDataResponse.TranscodeData = describeVodTranscodeDataResponse_transcodeData;
        
			return describeVodTranscodeDataResponse;
        }
    }
}
