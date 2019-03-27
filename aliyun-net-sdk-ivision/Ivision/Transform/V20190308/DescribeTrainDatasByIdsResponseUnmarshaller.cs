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
    public class DescribeTrainDatasByIdsResponseUnmarshaller
    {
        public static DescribeTrainDatasByIdsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTrainDatasByIdsResponse describeTrainDatasByIdsResponse = new DescribeTrainDatasByIdsResponse();

			describeTrainDatasByIdsResponse.HttpResponse = context.HttpResponse;
			describeTrainDatasByIdsResponse.RequestId = context.StringValue("DescribeTrainDatasByIds.RequestId");

			List<DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData> describeTrainDatasByIdsResponse_trainDatas = new List<DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData>();
			for (int i = 0; i < context.Length("DescribeTrainDatasByIds.TrainDatas.Length"); i++) {
				DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData trainData = new DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData();
				trainData.ProjectId = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].ProjectId");
				trainData.IterationId = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].IterationId");
				trainData.DataId = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].DataId");
				trainData.DataName = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].DataName");
				trainData.DataUrl = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].DataUrl");
				trainData.CreationTime = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].CreationTime");
				trainData.Status = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].Status");
				trainData.TagStatus = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].TagStatus");

				List<DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData.DescribeTrainDatasByIds_TagItem> trainData_tagItems = new List<DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData.DescribeTrainDatasByIds_TagItem>();
				for (int j = 0; j < context.Length("DescribeTrainDatasByIds.TrainDatas["+ i +"].TagItems.Length"); j++) {
					DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData.DescribeTrainDatasByIds_TagItem tagItem = new DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData.DescribeTrainDatasByIds_TagItem();
					tagItem.TagId = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].TagItems["+ j +"].TagId");
					tagItem.RegionType = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].TagItems["+ j +"].RegionType");

					DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData.DescribeTrainDatasByIds_TagItem.DescribeTrainDatasByIds_Region region = new DescribeTrainDatasByIdsResponse.DescribeTrainDatasByIds_TrainData.DescribeTrainDatasByIds_TagItem.DescribeTrainDatasByIds_Region();
					region.Left = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].TagItems["+ j +"].Region.Left");
					region.Top = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].TagItems["+ j +"].Region.Top");
					region.Width = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].TagItems["+ j +"].Region.Width");
					region.Height = context.StringValue("DescribeTrainDatasByIds.TrainDatas["+ i +"].TagItems["+ j +"].Region.Height");
					tagItem.Region = region;

					trainData_tagItems.Add(tagItem);
				}
				trainData.TagItems = trainData_tagItems;

				describeTrainDatasByIdsResponse_trainDatas.Add(trainData);
			}
			describeTrainDatasByIdsResponse.TrainDatas = describeTrainDatasByIdsResponse_trainDatas;
        
			return describeTrainDatasByIdsResponse;
        }
    }
}
