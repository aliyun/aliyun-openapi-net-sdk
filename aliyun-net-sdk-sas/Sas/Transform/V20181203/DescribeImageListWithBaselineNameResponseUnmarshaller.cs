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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeImageListWithBaselineNameResponseUnmarshaller
    {
        public static DescribeImageListWithBaselineNameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageListWithBaselineNameResponse describeImageListWithBaselineNameResponse = new DescribeImageListWithBaselineNameResponse();

			describeImageListWithBaselineNameResponse.HttpResponse = _ctx.HttpResponse;
			describeImageListWithBaselineNameResponse.RequestId = _ctx.StringValue("DescribeImageListWithBaselineName.RequestId");

			DescribeImageListWithBaselineNameResponse.DescribeImageListWithBaselineName_PageInfo pageInfo = new DescribeImageListWithBaselineNameResponse.DescribeImageListWithBaselineName_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeImageListWithBaselineName.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeImageListWithBaselineName.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeImageListWithBaselineName.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribeImageListWithBaselineName.PageInfo.Count");
			describeImageListWithBaselineNameResponse.PageInfo = pageInfo;

			List<DescribeImageListWithBaselineNameResponse.DescribeImageListWithBaselineName_ImageInfosItem> describeImageListWithBaselineNameResponse_imageInfos = new List<DescribeImageListWithBaselineNameResponse.DescribeImageListWithBaselineName_ImageInfosItem>();
			for (int i = 0; i < _ctx.Length("DescribeImageListWithBaselineName.ImageInfos.Length"); i++) {
				DescribeImageListWithBaselineNameResponse.DescribeImageListWithBaselineName_ImageInfosItem imageInfosItem = new DescribeImageListWithBaselineNameResponse.DescribeImageListWithBaselineName_ImageInfosItem();
				imageInfosItem.MiddleRiskImage = _ctx.IntegerValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].MiddleRiskImage");
				imageInfosItem.Endpoints = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].Endpoints");
				imageInfosItem.RiskStatus = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].RiskStatus");
				imageInfosItem.ImageCreate = _ctx.LongValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].ImageCreate");
				imageInfosItem.Digest = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].Digest");
				imageInfosItem.Tag = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].Tag");
				imageInfosItem.ImageUpdate = _ctx.LongValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].ImageUpdate");
				imageInfosItem.InstanceId = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].InstanceId");
				imageInfosItem.LowRiskImage = _ctx.IntegerValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].LowRiskImage");
				imageInfosItem.RepoType = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].RepoType");
				imageInfosItem.RegionId = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].RegionId");
				imageInfosItem.Uuid = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].Uuid");
				imageInfosItem.ImageSize = _ctx.IntegerValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].ImageSize");
				imageInfosItem.RepoId = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].RepoId");
				imageInfosItem.TotalItemCount = _ctx.IntegerValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].TotalItemCount");
				imageInfosItem.HighRiskImage = _ctx.IntegerValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].HighRiskImage");
				imageInfosItem.NoRiskImage = _ctx.IntegerValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].NoRiskImage");
				imageInfosItem.ImageId = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].ImageId");
				imageInfosItem.RepoName = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].RepoName");
				imageInfosItem.RepoNamespace = _ctx.StringValue("DescribeImageListWithBaselineName.ImageInfos["+ i +"].RepoNamespace");

				describeImageListWithBaselineNameResponse_imageInfos.Add(imageInfosItem);
			}
			describeImageListWithBaselineNameResponse.ImageInfos = describeImageListWithBaselineNameResponse_imageInfos;
        
			return describeImageListWithBaselineNameResponse;
        }
    }
}
