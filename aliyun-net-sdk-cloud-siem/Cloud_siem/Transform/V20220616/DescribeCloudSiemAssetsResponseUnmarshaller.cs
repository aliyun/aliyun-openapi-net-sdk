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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeCloudSiemAssetsResponseUnmarshaller
    {
        public static DescribeCloudSiemAssetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudSiemAssetsResponse describeCloudSiemAssetsResponse = new DescribeCloudSiemAssetsResponse();

			describeCloudSiemAssetsResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudSiemAssetsResponse.Success = _ctx.BooleanValue("DescribeCloudSiemAssets.Success");
			describeCloudSiemAssetsResponse.Code = _ctx.IntegerValue("DescribeCloudSiemAssets.Code");
			describeCloudSiemAssetsResponse.Message = _ctx.StringValue("DescribeCloudSiemAssets.Message");
			describeCloudSiemAssetsResponse.RequestId = _ctx.StringValue("DescribeCloudSiemAssets.RequestId");

			DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data data = new DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data();

			DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_PageInfo pageInfo = new DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeCloudSiemAssets.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeCloudSiemAssets.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("DescribeCloudSiemAssets.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_ResponseDataItem> data_responseData = new List<DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeCloudSiemAssets.Data.ResponseData.Length"); i++) {
				DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_ResponseDataItem responseDataItem = new DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.Aliuid = _ctx.LongValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].Aliuid");
				responseDataItem.SubUserId = _ctx.LongValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].SubUserId");
				responseDataItem.IncidentUuid = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].IncidentUuid");
				responseDataItem.AlertUuid = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].AlertUuid");
				responseDataItem.AssetName = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].AssetName");
				responseDataItem.AssetType = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].AssetType");
				responseDataItem.AssetId = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].AssetId");
				responseDataItem.CloudCode = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].CloudCode");

				List<DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_ResponseDataItem.DescribeCloudSiemAssets_AssetInfoItem> responseDataItem_assetInfo = new List<DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_ResponseDataItem.DescribeCloudSiemAssets_AssetInfoItem>();
				for (int j = 0; j < _ctx.Length("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].AssetInfo.Length"); j++) {
					DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_ResponseDataItem.DescribeCloudSiemAssets_AssetInfoItem assetInfoItem = new DescribeCloudSiemAssetsResponse.DescribeCloudSiemAssets_Data.DescribeCloudSiemAssets_ResponseDataItem.DescribeCloudSiemAssets_AssetInfoItem();
					assetInfoItem.Key = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].AssetInfo["+ j +"].Key");
					assetInfoItem.KeyName = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].AssetInfo["+ j +"].KeyName");
					assetInfoItem.Values = _ctx.StringValue("DescribeCloudSiemAssets.Data.ResponseData["+ i +"].AssetInfo["+ j +"].Values");

					responseDataItem_assetInfo.Add(assetInfoItem);
				}
				responseDataItem.AssetInfo = responseDataItem_assetInfo;

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			describeCloudSiemAssetsResponse.Data = data;
        
			return describeCloudSiemAssetsResponse;
        }
    }
}
