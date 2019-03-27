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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class DescribeTrainDatasResponseUnmarshaller
    {
        public static DescribeTrainDatasResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTrainDatasResponse describeTrainDatasResponse = new DescribeTrainDatasResponse();

			describeTrainDatasResponse.HttpResponse = context.HttpResponse;
			describeTrainDatasResponse.RequestId = context.StringValue("DescribeTrainDatas.RequestId");
			describeTrainDatasResponse.TotalNum = context.LongValue("DescribeTrainDatas.TotalNum");
			describeTrainDatasResponse.CurrentPage = context.LongValue("DescribeTrainDatas.CurrentPage");
			describeTrainDatasResponse.PageSize = context.LongValue("DescribeTrainDatas.PageSize");
			describeTrainDatasResponse.NextPageToken = context.StringValue("DescribeTrainDatas.NextPageToken");

			List<DescribeTrainDatasResponse.DescribeTrainDatas_TrainData> describeTrainDatasResponse_trainDatas = new List<DescribeTrainDatasResponse.DescribeTrainDatas_TrainData>();
			for (int i = 0; i < context.Length("DescribeTrainDatas.TrainDatas.Length"); i++) {
				DescribeTrainDatasResponse.DescribeTrainDatas_TrainData trainData = new DescribeTrainDatasResponse.DescribeTrainDatas_TrainData();
				trainData.ProjectId = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].ProjectId");
				trainData.IterationId = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].IterationId");
				trainData.DataId = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].DataId");
				trainData.DataName = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].DataName");
				trainData.DataUrl = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].DataUrl");
				trainData.CreationTime = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].CreationTime");
				trainData.Status = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].Status");
				trainData.TagStatus = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].TagStatus");

				List<DescribeTrainDatasResponse.DescribeTrainDatas_TrainData.DescribeTrainDatas_TagItem> trainData_tagItems = new List<DescribeTrainDatasResponse.DescribeTrainDatas_TrainData.DescribeTrainDatas_TagItem>();
				for (int j = 0; j < context.Length("DescribeTrainDatas.TrainDatas["+ i +"].TagItems.Length"); j++) {
					DescribeTrainDatasResponse.DescribeTrainDatas_TrainData.DescribeTrainDatas_TagItem tagItem = new DescribeTrainDatasResponse.DescribeTrainDatas_TrainData.DescribeTrainDatas_TagItem();
					tagItem.TagId = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].TagItems["+ j +"].TagId");
					tagItem.RegionType = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].TagItems["+ j +"].RegionType");

					DescribeTrainDatasResponse.DescribeTrainDatas_TrainData.DescribeTrainDatas_TagItem.DescribeTrainDatas_Region region = new DescribeTrainDatasResponse.DescribeTrainDatas_TrainData.DescribeTrainDatas_TagItem.DescribeTrainDatas_Region();
					region.Left = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].TagItems["+ j +"].Region.Left");
					region.Top = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].TagItems["+ j +"].Region.Top");
					region.Width = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].TagItems["+ j +"].Region.Width");
					region.Height = context.StringValue("DescribeTrainDatas.TrainDatas["+ i +"].TagItems["+ j +"].Region.Height");
					tagItem.Region = region;

					trainData_tagItems.Add(tagItem);
				}
				trainData.TagItems = trainData_tagItems;

				describeTrainDatasResponse_trainDatas.Add(trainData);
			}
			describeTrainDatasResponse.TrainDatas = describeTrainDatasResponse_trainDatas;
        
			return describeTrainDatasResponse;
        }
    }
}
